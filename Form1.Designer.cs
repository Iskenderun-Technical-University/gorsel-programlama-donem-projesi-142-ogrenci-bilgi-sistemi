namespace Login_Ekranı
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.yonetimpng = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.ogrenci = new System.Windows.Forms.ImageList(this.components);
            this.button_kapat = new System.Windows.Forms.Button();
            this.kapatma_butonu = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.yonetimpng;
            this.button1.Location = new System.Drawing.Point(33, 61);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button1.Size = new System.Drawing.Size(244, 105);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yönetim Bilgi\r\nSistemi Giriş";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yonetimpng
            // 
            this.yonetimpng.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("yonetimpng.ImageStream")));
            this.yonetimpng.TransparentColor = System.Drawing.Color.Transparent;
            this.yonetimpng.Images.SetKeyName(0, "stock-vector-toilet-restroom-wc-icon-set-in-thin-line-style-1226443066.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.ogrenci;
            this.button2.Location = new System.Drawing.Point(327, 61);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(244, 105);
            this.button2.TabIndex = 0;
            this.button2.Text = "Öğrenci Bilgi \r\nSistemi Giriş";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ogrenci
            // 
            this.ogrenci.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ogrenci.ImageStream")));
            this.ogrenci.TransparentColor = System.Drawing.Color.Transparent;
            this.ogrenci.Images.SetKeyName(0, "stock-vector-family-avatar-characters-vector-line-icons-2041700969.png");
            // 
            // button_kapat
            // 
            this.button_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_kapat.ImageKey = "458594.png";
            this.button_kapat.ImageList = this.kapatma_butonu;
            this.button_kapat.Location = new System.Drawing.Point(573, 12);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(34, 33);
            this.button_kapat.TabIndex = 1;
            this.button_kapat.UseVisualStyleBackColor = false;
            this.button_kapat.Click += new System.EventHandler(this.button3_Click);
            // 
            // kapatma_butonu
            // 
            this.kapatma_butonu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kapatma_butonu.ImageStream")));
            this.kapatma_butonu.TransparentColor = System.Drawing.Color.Transparent;
            this.kapatma_butonu.Images.SetKeyName(0, "458594.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(619, 233);
            this.Controls.Add(this.button_kapat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList yonetimpng;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList ogrenci;
        private System.Windows.Forms.Button button_kapat;
        private System.Windows.Forms.ImageList kapatma_butonu;
    }
}

