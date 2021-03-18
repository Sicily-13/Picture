
namespace picture
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Bright = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.transparency = new System.Windows.Forms.TrackBar();
            this.grey = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(51, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 340);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(312, 400);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(103, 32);
            this.left.TabIndex = 2;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = true;
            this.left.Click += new System.EventHandler(this.ImageSelector_click);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(618, 400);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(103, 32);
            this.right.TabIndex = 3;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = true;
            this.right.Click += new System.EventHandler(this.ImageSelector_click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(823, 253);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "noise";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 480);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "selected";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(312, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Bright
            // 
            this.Bright.Location = new System.Drawing.Point(842, 40);
            this.Bright.Maximum = 100;
            this.Bright.Name = "Bright";
            this.Bright.Size = new System.Drawing.Size(232, 56);
            this.Bright.TabIndex = 11;
            this.Bright.Scroll += new System.EventHandler(this.bright_Scroll);
            this.Bright.ValueChanged += new System.EventHandler(this.BrightSlider_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            // 
            // transparency
            // 
            this.transparency.Location = new System.Drawing.Point(842, 119);
            this.transparency.Maximum = 100;
            this.transparency.Name = "transparency";
            this.transparency.Size = new System.Drawing.Size(232, 56);
            this.transparency.TabIndex = 13;
            this.transparency.ValueChanged += new System.EventHandler(this.BrightSlider_ValueChanged);
            // 
            // grey
            // 
            this.grey.Location = new System.Drawing.Point(842, 191);
            this.grey.Maximum = 100;
            this.grey.Name = "grey";
            this.grey.Size = new System.Drawing.Size(232, 56);
            this.grey.TabIndex = 14;
            this.grey.ValueChanged += new System.EventHandler(this.BrightSlider_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 480);
            this.Controls.Add(this.grey);
            this.Controls.Add(this.transparency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bright);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar Bright;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar transparency;
        private System.Windows.Forms.TrackBar grey;
    }
}

