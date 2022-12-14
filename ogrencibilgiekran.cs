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
                                    x.Ogrenci,
                                    

                                }).Where(y => y.Ogrenci == ogrid).ToList();
            dataGridView1.DataSource = sinavnotlari;
            dataGridView1.Columns["Ogrenci"].Visible = false;//ogrenci ıd gizlendi.


        }
        private void rjButton1_Click(object sender, EventArgs e)//şifre güncelleme işlemi
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

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Öğeyi koleksiyondan alın.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Sekme dikdörtgeni için gerçek sınırları alın.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Farklı bir arka plan rengi çizin ve odak dikdörtgeni çizmeyin.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Kendi yazı tipimizi kullanın.
            Font _tabFont = new Font("Arial", 15.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            //Dize çizin. Metni ortalayın.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
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


        //panel çerçevelerini ve arka plan rengini değiştirme bölümü
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


        //panel çerçevelerini ve arka plan rengini değiştirme bölümü
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


        //panel çerçevelerini ve arka plan rengini değiştirme bölümü
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


        //panel çerçevelerini ve arka plan rengini değiştirme bölümü
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



        //panel çerçevelerini ve arka plan rengini değiştirme bölümü
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

       

    }
}
