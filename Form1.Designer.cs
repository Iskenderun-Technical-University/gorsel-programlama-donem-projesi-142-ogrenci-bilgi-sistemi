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
            this.yonetim_buton = new System.Windows.Forms.Button();
            this.yonetimpng = new System.Windows.Forms.ImageList(this.components);
            this.ogrenci_buton = new System.Windows.Forms.Button();
            this.ogrenci = new System.Windows.Forms.ImageList(this.components);
            this.button_kapat = new System.Windows.Forms.Button();
            this.kapatma_butonu = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // yonetim_buton
            // 
            this.yonetim_buton.BackColor = System.Drawing.Color.White;
            this.yonetim_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.yonetim_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yonetim_buton.ImageIndex = 0;
            this.yonetim_buton.ImageList = this.yonetimpng;
            this.yonetim_buton.Location = new System.Drawing.Point(33, 61);
            this.yonetim_buton.Name = "yonetim_buton";
            this.yonetim_buton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yonetim_buton.Size = new System.Drawing.Size(244, 105);
            this.yonetim_buton.TabIndex = 0;
            this.yonetim_buton.Text = "Yönetim Bilgi\r\nSistemi Giriş";
            this.yonetim_buton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yonetim_buton.UseVisualStyleBackColor = false;
            this.yonetim_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // yonetimpng
            // 
            this.yonetimpng.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("yonetimpng.ImageStream")));
            this.yonetimpng.TransparentColor = System.Drawing.Color.Transparent;
            this.yonetimpng.Images.SetKeyName(0, "stock-vector-toilet-restroom-wc-icon-set-in-thin-line-style-1226443066.png");
            // 
            // ogrenci_buton
            // 
            this.ogrenci_buton.BackColor = System.Drawing.Color.White;
            this.ogrenci_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.ogrenci_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ogrenci_buton.ImageIndex = 0;
            this.ogrenci_buton.ImageList = this.ogrenci;
            this.ogrenci_buton.Location = new System.Drawing.Point(327, 61);
            this.ogrenci_buton.Name = "ogrenci_buton";
            this.ogrenci_buton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ogrenci_buton.Size = new System.Drawing.Size(244, 105);
            this.ogrenci_buton.TabIndex = 0;
            this.ogrenci_buton.Text = "Öğrenci Bilgi \r\nSistemi Giriş";
            this.ogrenci_buton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ogrenci_buton.UseVisualStyleBackColor = false;
            this.ogrenci_buton.Click += new System.EventHandler(this.ogrenci_buton_Click);
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
            this.Controls.Add(this.ogrenci_buton);
            this.Controls.Add(this.yonetim_buton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yonetim_buton;
        private System.Windows.Forms.ImageList yonetimpng;
        private System.Windows.Forms.Button ogrenci_buton;
        private System.Windows.Forms.ImageList ogrenci;
        private System.Windows.Forms.Button button_kapat;
        private System.Windows.Forms.ImageList kapatma_butonu;
    }
}

