using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace picture
{
    public partial class Form1 : Form
    {
        private Image _currentImage;
        private List<FileInfo> _imageList;
        private int _imageIndex;
        public Form1()
        {
            InitializeComponent();
            _imageList = new List<FileInfo>();
        }

        private void ViewImage()
        {
           
            var image = _imageList.ElementAtOrDefault(_imageIndex);
            if (_imageList.Count == 0)
            {
                return;
            }
            if (image == default)
            {
                return;
            }

            pictureBox1.Image?.Dispose();
            _currentImage = Image.FromFile(image.FullName);
            pictureBox1.Image = Image.FromFile(image.FullName);
        }

        private void ImageSelector_click(object sender, EventArgs e)
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "left":
                    _imageIndex--;
                    break;
                case "right":
                    _imageIndex++;
                    break;


            }
            if (_imageIndex < 0)
            {
                _imageIndex = 0;
                return;
            }

            if (_imageIndex > _imageList.Count() - 1)
            {
                _imageIndex = _imageList.Count - 1;
                return;
            }

            ViewImage();
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemBox = sender as ListBox;
            _imageIndex = itemBox.SelectedIndex;
            Debug.WriteLine(itemBox.SelectedItem);
            ViewImage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fd = new FolderBrowserDialog();
            _imageList.Clear();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                var dInfo = new DirectoryInfo(fd.SelectedPath);
                _imageList.Clear();
                _imageList.AddRange(
                    dInfo.GetFiles()
                    .Where(c => c.Extension == ".png" || c.Extension == ".jpg"));
                var fileNames = _imageList.Select(c => c.FullName).ToList();
                listBox1.Items.Clear();
                foreach (var item in _imageList)
                {
                    listBox1.Items.Add(item.FullName);
                }
                ViewImage();
            }
           
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var bitmap = new Bitmap(_currentImage); 

            if (checkBox1.Checked == true)
            {

                for (int i=0; i < (bitmap.Width*bitmap.Height)/8;i++)
                {
                    Color curr = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                    bitmap.SetPixel(rnd.Next(bitmap.Width), rnd.Next(bitmap.Height), curr);
                }

               pictureBox1.Image= bitmap;
            }
            else
            {
                ViewImage();
            }

        }


        private void BrightSlider_ValueChanged(object sender, EventArgs e)
        {
            var slider = sender as TrackBar;
            var currentImage = new Bitmap(_currentImage);
            float bright = 0;
            float transparency = 0;
           

            ImageAttributes imageattributes = new ImageAttributes();
            int width = currentImage.Width;
            int height = currentImage.Height;
            if (slider.Name == "Bright") { bright = Math.Abs(slider.Value-100) * 0.01f; }
            if (slider.Name == "transparency") {
                currentImage = new Bitmap(_currentImage);
                transparency = slider.Value * 0.01f; }
            ViewImage();
            float[][] colormatrixBrightness = {
                new float []{ bright,0,0,0,0},
                new float []{0, bright,0,0,0},
                new float []{0,0, bright,0,0},
                new float []{0,0,0,1,0},
                new float []{ 0,0,0,0,1}
            };

            float[][] colormatrixGrey = {
                new float []{0.3086f, 0.3086f, 0.3086f, 0,0},
                new float []{0.6094f, 0.6094f, 0.6094f, 0,0},
                new float []{ 0.6094f, 0.6094f, 0.6094f, 0,0},
                new float []{0,0,0,1,0},
                new float []{0,0,0,0,1 }
            };

            float[][] colormatrixTransparency = {
               new float []{ 1,0,0,0,0},
                new float []{0,1,0,0,0},
                new float []{0,0,1,0,0},
                new float []{transparency, transparency, transparency, 1,0},
                new float []{0,0,0,0,1}
            };

            ColorMatrix colormatrix = null;
            if (slider.Name =="Bright")
            {
                colormatrix = new ColorMatrix(colormatrixBrightness);
            }
            else if (slider.Name == "transparency")
            {
                colormatrix = new ColorMatrix(colormatrixTransparency);
            }
            else if (slider.Name == "grey")
            {
                colormatrix = new ColorMatrix(colormatrixGrey);
            }


            imageattributes.SetColorMatrix(
                colormatrix,
                ColorMatrixFlag.Default,
                ColorAdjustType.Bitmap);
            Graphics graphics = Graphics.FromImage(currentImage);
            graphics.DrawImage(currentImage,
                new Rectangle(0, 0, width, height),
                0,
                0,
                width,
                height,
                GraphicsUnit.Pixel,
                imageattributes);
            pictureBox1.Image = currentImage;
        }

       
       
       

        private void bright_Scroll(object sender, EventArgs e)
        {

        }
    }
}
