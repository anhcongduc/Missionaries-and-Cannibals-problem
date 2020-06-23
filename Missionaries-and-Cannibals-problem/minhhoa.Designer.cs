namespace pplt
{
    partial class minhhoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(minhhoa));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.thuyen = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.nguoitrenthuyen1 = new System.Windows.Forms.PictureBox();
            this.nguoitrenthuyen2 = new System.Windows.Forms.PictureBox();
            this.nguoi2 = new System.Windows.Forms.PictureBox();
            this.nguoi3 = new System.Windows.Forms.PictureBox();
            this.quy1 = new System.Windows.Forms.PictureBox();
            this.quy2 = new System.Windows.Forms.PictureBox();
            this.quy3 = new System.Windows.Forms.PictureBox();
            this.nguoi1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.thuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoitrenthuyen1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoitrenthuyen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoi3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(101, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(164, 29);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(332, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(651, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 68);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thuyen
            // 
            this.thuyen.BackColor = System.Drawing.Color.Transparent;
            this.thuyen.BackgroundImage = global::pplt.Properties.Resources.pbbg;
            this.thuyen.Image = global::pplt.Properties.Resources.thuyen;
            this.thuyen.Location = new System.Drawing.Point(414, 325);
            this.thuyen.Name = "thuyen";
            this.thuyen.Size = new System.Drawing.Size(170, 36);
            this.thuyen.TabIndex = 11;
            this.thuyen.TabStop = false;
            this.thuyen.Click += new System.EventHandler(this.thuyen_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::pplt.Properties.Resources.pbbg;
            this.pictureBox2.Image = global::pplt.Properties.Resources.bo21;
            this.pictureBox2.Location = new System.Drawing.Point(848, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 202);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::pplt.Properties.Resources.pbbg;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Image = global::pplt.Properties.Resources.bo12;
            this.pictureBox4.Location = new System.Drawing.Point(-7, 331);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(420, 198);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // nguoitrenthuyen1
            // 
            this.nguoitrenthuyen1.BackColor = System.Drawing.Color.Transparent;
            this.nguoitrenthuyen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nguoitrenthuyen1.BackgroundImage")));
            this.nguoitrenthuyen1.Location = new System.Drawing.Point(423, 211);
            this.nguoitrenthuyen1.Name = "nguoitrenthuyen1";
            this.nguoitrenthuyen1.Size = new System.Drawing.Size(60, 120);
            this.nguoitrenthuyen1.TabIndex = 15;
            this.nguoitrenthuyen1.TabStop = false;
            // 
            // nguoitrenthuyen2
            // 
            this.nguoitrenthuyen2.BackColor = System.Drawing.Color.Transparent;
            this.nguoitrenthuyen2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nguoitrenthuyen2.BackgroundImage")));
            this.nguoitrenthuyen2.Location = new System.Drawing.Point(524, 211);
            this.nguoitrenthuyen2.Name = "nguoitrenthuyen2";
            this.nguoitrenthuyen2.Size = new System.Drawing.Size(60, 120);
            this.nguoitrenthuyen2.TabIndex = 14;
            this.nguoitrenthuyen2.TabStop = false;
            // 
            // nguoi2
            // 
            this.nguoi2.BackColor = System.Drawing.Color.Transparent;
            this.nguoi2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nguoi2.BackgroundImage")));
            this.nguoi2.Image = global::pplt.Properties.Resources.nhasu1;
            this.nguoi2.Location = new System.Drawing.Point(82, 211);
            this.nguoi2.Name = "nguoi2";
            this.nguoi2.Size = new System.Drawing.Size(60, 120);
            this.nguoi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nguoi2.TabIndex = 10;
            this.nguoi2.TabStop = false;
            // 
            // nguoi3
            // 
            this.nguoi3.BackColor = System.Drawing.Color.Transparent;
            this.nguoi3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nguoi3.BackgroundImage")));
            this.nguoi3.Image = global::pplt.Properties.Resources.nhasu1;
            this.nguoi3.Location = new System.Drawing.Point(148, 211);
            this.nguoi3.Name = "nguoi3";
            this.nguoi3.Size = new System.Drawing.Size(60, 120);
            this.nguoi3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nguoi3.TabIndex = 9;
            this.nguoi3.TabStop = false;
            // 
            // quy1
            // 
            this.quy1.BackColor = System.Drawing.Color.Transparent;
            this.quy1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quy1.BackgroundImage")));
            this.quy1.Image = global::pplt.Properties.Resources.quy1;
            this.quy1.InitialImage = global::pplt.Properties.Resources.quy1;
            this.quy1.Location = new System.Drawing.Point(337, 211);
            this.quy1.Name = "quy1";
            this.quy1.Size = new System.Drawing.Size(60, 120);
            this.quy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quy1.TabIndex = 8;
            this.quy1.TabStop = false;
            // 
            // quy2
            // 
            this.quy2.BackColor = System.Drawing.Color.Transparent;
            this.quy2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quy2.BackgroundImage")));
            this.quy2.Image = global::pplt.Properties.Resources.quy1;
            this.quy2.Location = new System.Drawing.Point(205, 211);
            this.quy2.Name = "quy2";
            this.quy2.Size = new System.Drawing.Size(60, 120);
            this.quy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quy2.TabIndex = 7;
            this.quy2.TabStop = false;
            // 
            // quy3
            // 
            this.quy3.BackColor = System.Drawing.Color.Transparent;
            this.quy3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quy3.BackgroundImage")));
            this.quy3.Image = global::pplt.Properties.Resources.quy1;
            this.quy3.Location = new System.Drawing.Point(271, 211);
            this.quy3.Name = "quy3";
            this.quy3.Size = new System.Drawing.Size(60, 120);
            this.quy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.quy3.TabIndex = 6;
            this.quy3.TabStop = false;
            // 
            // nguoi1
            // 
            this.nguoi1.BackColor = System.Drawing.Color.Transparent;
            this.nguoi1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nguoi1.BackgroundImage")));
            this.nguoi1.Image = global::pplt.Properties.Resources.nhasu1;
            this.nguoi1.Location = new System.Drawing.Point(16, 211);
            this.nguoi1.Name = "nguoi1";
            this.nguoi1.Size = new System.Drawing.Size(60, 120);
            this.nguoi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nguoi1.TabIndex = 5;
            this.nguoi1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::pplt.Properties.Resources.song1;
            this.pictureBox3.Location = new System.Drawing.Point(414, 361);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(436, 168);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::pplt.Properties.Resources.tải_xuống__1_;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1028, 528);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // minhhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 528);
            this.Controls.Add(this.thuyen);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nguoitrenthuyen1);
            this.Controls.Add(this.nguoitrenthuyen2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nguoi2);
            this.Controls.Add(this.nguoi3);
            this.Controls.Add(this.quy1);
            this.Controls.Add(this.quy2);
            this.Controls.Add(this.quy3);
            this.Controls.Add(this.nguoi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "minhhoa";
            this.Text = "minhhoa";
            this.Load += new System.EventHandler(this.minhhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoitrenthuyen1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoitrenthuyen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoi3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox nguoi1;
        private System.Windows.Forms.PictureBox quy2;
        private System.Windows.Forms.PictureBox quy1;
        private System.Windows.Forms.PictureBox nguoi3;
        private System.Windows.Forms.PictureBox nguoi2;
        private System.Windows.Forms.PictureBox thuyen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox nguoitrenthuyen1;
        private System.Windows.Forms.PictureBox nguoitrenthuyen2;
        public System.Windows.Forms.PictureBox quy3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}