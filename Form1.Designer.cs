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
            this.yonetimpng = new System.Windows.Forms.ImageList(this.components);
            this.ogrenci = new System.Windows.Forms.ImageList(this.components);
            this.kapatma_butonu = new System.Windows.Forms.ImageList(this.components);
            this.ogrenci_buton = new System.Windows.Forms.Button();
            this.yonetim_buton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_kapat = new CustomControls.RJControls.RJButton();
            this.Kapat_buton = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // yonetimpng
            // 
            this.yonetimpng.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("yonetimpng.ImageStream")));
            this.yonetimpng.TransparentColor = System.Drawing.Color.Transparent;
            this.yonetimpng.Images.SetKeyName(0, "teach.png");
            // 
            // ogrenci
            // 
            this.ogrenci.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ogrenci.ImageStream")));
            this.ogrenci.TransparentColor = System.Drawing.Color.Transparent;
            this.ogrenci.Images.SetKeyName(0, "study.png");
            // 
            // kapatma_butonu
            // 
            this.kapatma_butonu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kapatma_butonu.ImageStream")));
            this.kapatma_butonu.TransparentColor = System.Drawing.Color.Transparent;
            this.kapatma_butonu.Images.SetKeyName(0, "458594.png");
            // 
            // ogrenci_buton
            // 
            this.ogrenci_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(189)))), ((int)(((byte)(233)))));
            this.ogrenci_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenci_buton.ForeColor = System.Drawing.Color.White;
            this.ogrenci_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ogrenci_buton.ImageIndex = 0;
            this.ogrenci_buton.ImageList = this.ogrenci;
            this.ogrenci_buton.Location = new System.Drawing.Point(494, 107);
            this.ogrenci_buton.Name = "ogrenci_buton";
            this.ogrenci_buton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ogrenci_buton.Size = new System.Drawing.Size(255, 105);
            this.ogrenci_buton.TabIndex = 0;
            this.ogrenci_buton.Text = "Öğrenci Bilgi \r\nSistemi Giriş";
            this.ogrenci_buton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ogrenci_buton.UseVisualStyleBackColor = false;
            this.ogrenci_buton.Click += new System.EventHandler(this.ogrenci_buton_Click);
            // 
            // yonetim_buton
            // 
            this.yonetim_buton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(189)))), ((int)(((byte)(233)))));
            this.yonetim_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetim_buton.ForeColor = System.Drawing.Color.White;
            this.yonetim_buton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.yonetim_buton.ImageIndex = 0;
            this.yonetim_buton.ImageList = this.yonetimpng;
            this.yonetim_buton.Location = new System.Drawing.Point(24, 107);
            this.yonetim_buton.Name = "yonetim_buton";
            this.yonetim_buton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.yonetim_buton.Size = new System.Drawing.Size(255, 105);
            this.yonetim_buton.TabIndex = 0;
            this.yonetim_buton.Text = "Yönetim Bilgi\r\nSistemi Giriş";
            this.yonetim_buton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yonetim_buton.UseVisualStyleBackColor = false;
            this.yonetim_buton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(785, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_kapat
            // 
            this.button_kapat.BackColor = System.Drawing.Color.Black;
            this.button_kapat.BackgroundColor = System.Drawing.Color.Black;
            this.button_kapat.BorderColor = System.Drawing.Color.Black;
            this.button_kapat.BorderRadius = 0;
            this.button_kapat.BorderSize = 0;
            this.button_kapat.FlatAppearance.BorderSize = 0;
            this.button_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kapat.ForeColor = System.Drawing.Color.Transparent;
            this.button_kapat.ImageIndex = 0;
            this.button_kapat.ImageList = this.Kapat_buton;
            this.button_kapat.Location = new System.Drawing.Point(727, -1);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(39, 33);
            this.button_kapat.TabIndex = 3;
            this.button_kapat.TextColor = System.Drawing.Color.Transparent;
            this.button_kapat.UseVisualStyleBackColor = false;
            this.button_kapat.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Kapat_buton
            // 
            this.Kapat_buton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Kapat_buton.ImageStream")));
            this.Kapat_buton.TransparentColor = System.Drawing.Color.Transparent;
            this.Kapat_buton.Images.SetKeyName(0, "eahaetyt.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(144)))), ((int)(((byte)(171)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(227, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bu Uygulamanın Telif Hakları Mevlana42© Yazılım Şirketine Aittir";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(764, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_kapat);
            this.Controls.Add(this.ogrenci_buton);
            this.Controls.Add(this.yonetim_buton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yonetim_buton;
        private System.Windows.Forms.ImageList yonetimpng;
        private System.Windows.Forms.Button ogrenci_buton;
        private System.Windows.Forms.ImageList ogrenci;
        private System.Windows.Forms.ImageList kapatma_butonu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton button_kapat;
        private System.Windows.Forms.ImageList Kapat_buton;
        private System.Windows.Forms.Label label1;
    }
}

