namespace OnlineExamSystem
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.jThinButton1 = new JThinButton.JThinButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jMaterialTextbox1 = new JMaterialTextbox.JMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.jImageButton1 = new JImageButton.JImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.jThinButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.jMaterialTextbox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.jMaterialTextbox1);
            this.panel1.Location = new System.Drawing.Point(164, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 326);
            this.panel1.TabIndex = 0;
            // 
            // jThinButton1
            // 
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BackgroundColor = System.Drawing.Color.White;
            this.jThinButton1.BorderColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.BorderRadius = 16;
            this.jThinButton1.ButtonText = "Login";
            this.jThinButton1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.Font_Size = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jThinButton1.ForeColors = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.HoverBackground = System.Drawing.Color.White;
            this.jThinButton1.HoverBorder = System.Drawing.Color.Empty;
            this.jThinButton1.HoverFontColor = System.Drawing.SystemColors.Highlight;
            this.jThinButton1.LineThickness = 2;
            this.jThinButton1.Location = new System.Drawing.Point(128, 239);
            this.jThinButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.Size = new System.Drawing.Size(365, 35);
            this.jThinButton1.TabIndex = 13;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "User Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(193, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // jMaterialTextbox2
            // 
            this.jMaterialTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.ForeColors = System.Drawing.Color.LightSkyBlue;
            this.jMaterialTextbox2.HintText = null;
            this.jMaterialTextbox2.IsPassword = true;
            this.jMaterialTextbox2.LineBackColor = System.Drawing.SystemColors.Highlight;
            this.jMaterialTextbox2.LineThickness = 2;
            this.jMaterialTextbox2.Location = new System.Drawing.Point(219, 179);
            this.jMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox2.MaxLength = 12;
            this.jMaterialTextbox2.Name = "jMaterialTextbox2";
            this.jMaterialTextbox2.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.ReadOnly = false;
            this.jMaterialTextbox2.Size = new System.Drawing.Size(308, 24);
            this.jMaterialTextbox2.TabIndex = 9;
            this.jMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox2.TextName = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // jMaterialTextbox1
            // 
            this.jMaterialTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.ForeColors = System.Drawing.Color.LightSteelBlue;
            this.jMaterialTextbox1.HintText = null;
            this.jMaterialTextbox1.IsPassword = false;
            this.jMaterialTextbox1.LineBackColor = System.Drawing.SystemColors.Highlight;
            this.jMaterialTextbox1.LineThickness = 2;
            this.jMaterialTextbox1.Location = new System.Drawing.Point(219, 107);
            this.jMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox1.MaxLength = 15;
            this.jMaterialTextbox1.Name = "jMaterialTextbox1";
            this.jMaterialTextbox1.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.ReadOnly = false;
            this.jMaterialTextbox1.Size = new System.Drawing.Size(308, 26);
            this.jMaterialTextbox1.TabIndex = 7;
            this.jMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox1.TextName = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(280, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 72);
            this.label2.TabIndex = 9;
            this.label2.Text = "Admin Login";
            // 
            // jImageButton1
            // 
            this.jImageButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.jImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.jImageButton1.CausesValidation = false;
            this.jImageButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.jImageButton1.ErrorImage = null;
            this.jImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("jImageButton1.Image")));
            this.jImageButton1.ImageHover = null;
            this.jImageButton1.InitialImage = null;
            this.jImageButton1.Location = new System.Drawing.Point(23, 22);
            this.jImageButton1.Name = "jImageButton1";
            this.jImageButton1.Size = new System.Drawing.Size(40, 39);
            this.jImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.jImageButton1.TabIndex = 8;
            this.jImageButton1.Zoom = 4;
            this.jImageButton1.Click += new System.EventHandler(this.jImageButton1_Click);
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(936, 504);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jImageButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private JThinButton.JThinButton jThinButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox1;
        private JImageButton.JImageButton jImageButton1;
        private System.Windows.Forms.Label label2;
    }
}