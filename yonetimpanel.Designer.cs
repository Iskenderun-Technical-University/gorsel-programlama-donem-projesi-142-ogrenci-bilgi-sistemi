namespace Login_Ekranı
{
    partial class yonetimpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yonetimpanel));
            this.button_kapat = new System.Windows.Forms.Button();
            this.kapat_ico = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button_kapat
            // 
            this.button_kapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_kapat.ImageKey = "458594.png";
            this.button_kapat.ImageList = this.kapat_ico;
            this.button_kapat.Location = new System.Drawing.Point(786, 12);
            this.button_kapat.Name = "button_kapat";
            this.button_kapat.Size = new System.Drawing.Size(34, 33);
            this.button_kapat.TabIndex = 7;
            this.button_kapat.UseVisualStyleBackColor = false;
            this.button_kapat.Click += new System.EventHandler(this.button_kapat_Click);
            // 
            // kapat_ico
            // 
            this.kapat_ico.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kapat_ico.ImageStream")));
            this.kapat_ico.TransparentColor = System.Drawing.Color.Transparent;
            this.kapat_ico.Images.SetKeyName(0, "458594.png");
            // 
            // yonetimpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 482);
            this.Controls.Add(this.button_kapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "yonetimpanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yonetimpanel";
            this.Load += new System.EventHandler(this.yonetimpanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_kapat;
        private System.Windows.Forms.ImageList kapat_ico;
    }
}