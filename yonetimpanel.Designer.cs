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
            this.kapat_ico = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.page_notgiris = new System.Windows.Forms.TabPage();
            this.page_devamsizlikgiris = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kapat_ico
            // 
            this.kapat_ico.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("kapat_ico.ImageStream")));
            this.kapat_ico.TransparentColor = System.Drawing.Color.Transparent;
            this.kapat_ico.Images.SetKeyName(0, "458594.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.page_notgiris);
            this.tabControl1.Controls.Add(this.page_devamsizlikgiris);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 130);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(832, 482);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // page_notgiris
            // 
            this.page_notgiris.Location = new System.Drawing.Point(134, 4);
            this.page_notgiris.Name = "page_notgiris";
            this.page_notgiris.Padding = new System.Windows.Forms.Padding(3);
            this.page_notgiris.Size = new System.Drawing.Size(694, 474);
            this.page_notgiris.TabIndex = 0;
            this.page_notgiris.Text = "Not Giriş Ekranı";
            this.page_notgiris.UseVisualStyleBackColor = true;
            // 
            // page_devamsizlikgiris
            // 
            this.page_devamsizlikgiris.Location = new System.Drawing.Point(134, 4);
            this.page_devamsizlikgiris.Name = "page_devamsizlikgiris";
            this.page_devamsizlikgiris.Padding = new System.Windows.Forms.Padding(3);
            this.page_devamsizlikgiris.Size = new System.Drawing.Size(694, 474);
            this.page_devamsizlikgiris.TabIndex = 1;
            this.page_devamsizlikgiris.Text = "Devamsızlık Girişi";
            this.page_devamsizlikgiris.UseVisualStyleBackColor = true;
            // 
            // yonetimpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 482);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "yonetimpanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "yonetimpanel";
            this.Load += new System.EventHandler(this.yonetimpanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList kapat_ico;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage page_notgiris;
        private System.Windows.Forms.TabPage page_devamsizlikgiris;
    }
}