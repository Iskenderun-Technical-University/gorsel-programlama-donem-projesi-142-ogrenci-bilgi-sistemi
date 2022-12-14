using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Ekranı.Entity;

namespace Login_Ekranı
{
    public partial class ogrencibilgiekran : Form
    {
        public ogrencibilgiekran()
        {
            
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }
        public string numara;
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        int ogrid;


        private void ogrencibilgiekran_Load(object sender, EventArgs e)
        {
            mtxtbox_numara.Text = numara; //numarayı taşıdık giriş formundan 
            txt_ad.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrAd).FirstOrDefault();
            txt_soyad.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSoyad).FirstOrDefault();
            txt_sifre1.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSifre).FirstOrDefault();
            comboBox2.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSinif).FirstOrDefault().ToString();
            lbl_ozursuz_devamsizlik.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrDevamsizlik).FirstOrDefault().ToString();
            lbl_toplam_devamsizlik.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrDevamsizlik).FirstOrDefault().ToString();
            ort4_lbl.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.Ort9).FirstOrDefault().ToString();
            ort5_lbl.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.Ort10).FirstOrDefault().ToString();
            ort6_lbl.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.Ort11).FirstOrDefault().ToString();
            ort7_lbl.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.Ort12).FirstOrDefault().ToString();
            ort8_lbl.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.Ort13).FirstOrDefault().ToString();
            ogrid = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrID).FirstOrDefault();
            var sinavnotlari = (from x in db.TblNotlar
                                select new
                                {
                                    x.TblDersler.DersAdi,
                                    x.Yazili1,
                                    x.Yazili2,
                                    x.Performans,
                                    x.Proje,
                                    x.Ortalama,
                                    x.Ogrenci

                                }).Where(y => y.Ogrenci == ogrid).ToList();
            dataGridView1.DataSource = sinavnotlari;
            dataGridView1.Columns["Ogrenci"].Visible = false;//ogrenci ıd gizlendi.


        }
        private void btn_sifreguncelle_Click(object sender, EventArgs e)// öğrenci formuna ait şifre değiştirme işlemi yapıldı
        {
            

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", 15.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void page_duyurular_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click_2(object sender, EventArgs e)
        {

        }
        //panel çerçevelerini ve arka plan rengini değiştirme bölümü
        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Row) % 2 == 0)
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

            if (true)
            {
                var rectangle = e.CellBounds;

                ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Gray, ButtonBorderStyle.Solid); 
            }
        }

        private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Row) % 2 == 0)
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

            if (true)
            {
                var rectangle = e.CellBounds;

                ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Gray, ButtonBorderStyle.Solid);
            }
        }

        private void tableLayoutPanel4_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Row) % 2 == 0)
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

            if (true)
            {
                var rectangle = e.CellBounds;

                ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Gray, ButtonBorderStyle.Solid);
            }
        }

        private void label15_Click_3(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Row) % 2 == 0)
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

            if (true)
            {
                var rectangle = e.CellBounds;

                ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Gray, ButtonBorderStyle.Solid);
            }
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel6_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Row) % 2 == 0)
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

            if (true)
            {
                var rectangle = e.CellBounds;

                ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Gray, ButtonBorderStyle.Solid);
            }
        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel7_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            if ((e.Row) % 2 == 0)
                e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
            else
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);

            if (true)
            {
                var rectangle = e.CellBounds;

                ControlPaint.DrawBorder(e.Graphics, rectangle, Color.Gray, ButtonBorderStyle.Solid);
            }
        }

        private void page_subeortalama_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_anaekran_Click(object sender, EventArgs e)
        {
            Form1 formgoster = new Form1();
            this.Close();
            formgoster.Show();
        }

        private void btn_kilit_Click(object sender, EventArgs e)
        {
            ogrencibilgigiris ogrencibilgigiris = new ogrencibilgigiris();
            this.Close();
            ogrencibilgigiris.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            Ogrencibilgi info = new Ogrencibilgi();
            info.Show();
            
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (txt_yenisifre1.Text == txt_yenisifre2.Text)
            {
                var deger = db.TblOgrenci.Find(ogrid);
                deger.OgrSifre = txt_yenisifre1.Text;
                db.SaveChanges();
                MessageBox.Show("Şifre değiştirme işlemi başarılı bir şekilde gerçekleşti");
            }
            else
            {
                MessageBox.Show("Girdiğiniz yeni şifreler birbiriyle uyuşmuyor!");
            }
        }
    }
}
