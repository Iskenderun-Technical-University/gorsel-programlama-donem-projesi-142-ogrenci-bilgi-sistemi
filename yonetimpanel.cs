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
using System.Data.SqlClient;
namespace Login_Ekranı
{
    public partial class yonetimpanel : Form
    {
        public yonetimpanel()
        {
            InitializeComponent();
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        OgrenciSinavEntities db = new OgrenciSinavEntities();


        private void button_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        void listele()
        {
            var degerler = from x in db.TblOgrenci
                           select new
                           {
                               x.OgrID,
                               x.OgrAd,
                               x.OgrSoyad,
                               x.OgrNumara,
                               x.OgrSifre,
                               x.OgrSinif,
                               x.TblSinif.SinifAd,
                               x.OgrDurum
                           };
            dataGridView1.DataSource = degerler.Where(x=>x.OgrDurum==true).ToList();
        }
        //Data Source=.\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");
        //SqlConnection baglanti = new SqlConnection("Data Source=25.42.111.49,1433;Network Library=DBMSSOCN;Initial Catalog=OgrenciSinav;User Id = ADMIN; Password=1;");

        private void yonetimpanel_Load(object sender, EventArgs e)
        {

            listele();
            dataGridView1.Columns["OgrDurum"].Visible = false;//durumu false olanları getirmiyoruz.
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblSinif", baglanti);
            SqlDataAdapter da=new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox2.ValueMember = "SinifID";   //comboboxlara sınıfları getiriyoruz.
            comboBox2.DisplayMember = "SinifAd";
            comboBox2.DataSource = dt;
            
            sinif.ValueMember = "SinifID";
            sinif.DisplayMember = "SinifAd";
            sinif.DataSource = dt;

            comboBox1.DisplayMember = "DersAdi"; //comboboxlara sınıfları getiriyoruz.
            comboBox1.ValueMember = "DersID";
            comboBox1.DataSource = db.TblDersler.ToList();

            comboBox3.DisplayMember = "DersAdi"; //comboboxlara sınıfları getiriyoruz.
            comboBox3.ValueMember = "DersID";
            comboBox3.DataSource = db.TblDersler.ToList();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            mtxtbox_numara.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_sifre1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox2.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sifre1.Text==sifre2.Text)//öğrenci kayıt yapıyor.
            {
                TblOgrenci t = new TblOgrenci();
                t.OgrAd = ad.Text;
                t.OgrSoyad = soyad.Text;
                t.OgrNumara = masked_numara.Text;
                t.OgrSifre = sifre1.Text;
                t.OgrSinif = int.Parse(sinif.SelectedValue.ToString());
                t.OgrDurum = true;
                db.TblOgrenci.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci bilgileri sisteme başarılı bir şekilde kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Girdiğiniz şifreler uyuşmuyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            listele();
        }
        private void guncel_Click_1(object sender, EventArgs e)// öğrenci bilgilerini güncelliyor
        {

            int id = int.Parse(txt_ıd.Text);
            var x = db.TblOgrenci.Find(id);
            x.OgrAd = txt_ad.Text;
            x.OgrSoyad = txt_soyad.Text;
            x.OgrNumara = mtxtbox_numara.Text;
            x.OgrSifre = txt_sifre1.Text;
            x.OgrSinif = int.Parse(comboBox2.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarılı bir şekilde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();

        }
        private void btn_sil_Click_1(object sender, EventArgs e)//Öğrenci Siliyor.
        {
            int id = int.Parse(txt_ıd.Text);
            var x = db.TblOgrenci.Find(id);
            x.OgrDurum = false;
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarılı bir şekilde sistemden silindi,silinen öğrencilere pasif öğrenciler listesi üzerinden erişim sağlayabilirsiniz", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            listele();
        }
        
        private void btn_ekle_Click(object sender, EventArgs e)// öğrenci notları ekleme ıd e göre yapıyoruz
        {
            TblNotlar t = new TblNotlar();
            t.Yazili1 = byte.Parse(txt_yazili1.Text);
            t.Yazili2 = byte.Parse(txt_yazili2.Text);
            t.Proje = byte.Parse(txt_proje.Text);
            t.Performans = byte.Parse(txt_performans.Text);
            t.Ders = int.Parse(comboBox1.SelectedValue.ToString());
            t.Ogrenci = int.Parse(txt_ogrenci.Text);
            t.Ortalama=int.Parse(txt_ortalama.Text);
            db.TblNotlar.Add(t);
            db.SaveChanges();
            MessageBox.Show("Öğrenci not bilgisi için sisteme kayıt edildi");
        }
        private void btn_hesapla_Click(object sender, EventArgs e)//ortalamayı hesaplıyor
        {
            byte y1, y2, per, pro;
            double ort;

            y1 = byte.Parse(txt_yazili1.Text);
            y2 = byte.Parse(txt_yazili2.Text);
            per = byte.Parse(txt_performans.Text);
            pro = byte.Parse(txt_proje.Text);
            ort = (y1 + y2 + per + pro) / 4;
            txt_ortalama.Text = ort.ToString();
        }
        private void btn_listele_Click(object sender, EventArgs e)//öğrencileri listeliyor
        {
         
            listele();
        }
        private void btn_list_Click(object sender, EventArgs e)// tüm notları listeliyor
        {
            //dataGridView2.DataSource = db.View_1.ToList();
            dataGridView2.DataSource = db.Notlar3();
        }
        private void btn_ara_Click(object sender, EventArgs e)// numaraya göre öğrenci bulup tüm notları getiriyor.
        {
            string no = mtxtbox_numara.Text;

            var deger = db.TblOgrenci.Where(x => x.OgrNumara == no).Select(y => y.OgrID).FirstOrDefault();
            var not = from x in db.TblNotlar
                      select new
                      {
                          x.NotID,
                          x.TblDersler.DersAdi,
                          Öğrenci_Adı = x.TblOgrenci.OgrAd + " " + x.TblOgrenci.OgrSoyad,
                          x.Yazili1,
                          x.Yazili2,
                          x.Performans,
                          x.Proje,
                          x.Ortalama,
                          x.Ogrenci,

                      };
            dataGridView2.DataSource = not.Where(z => z.Ogrenci == deger).ToList();
            dataGridView2.Columns["Ogrenci"].Visible = false;
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//seçilen derse göre tüm notlar getiriliyor
        {
            var degerler = from x in db.TblNotlar
                           select new
                           {

                               x.NotID,
                               x.TblDersler.DersAdi,
                               Öğrenci_Adı = x.TblOgrenci.OgrAd + " " + x.TblOgrenci.OgrSoyad,
                               x.Yazili1,
                               x.Yazili2,
                               x.Performans,
                               x.Proje,
                               x.Ortalama,
                               x.Ders,
                           };

            int d = int.Parse(comboBox3.SelectedValue.ToString());
            dataGridView2.DataSource = degerler.Where(y => y.Ders == d).ToList();
            dataGridView2.Columns["Ders"].Visible = false;//ders ıd gizlendi.

        }

        private void btn_guncel_Click(object sender, EventArgs e)//öğrenci sınavları güncelleme.çift tık yap txt ıd ye al 
        {
            int id = int.Parse(txtID.Text);
            var x = db.TblNotlar.Find(id);
            x.Yazili1 = int.Parse(txt_yazili1.Text);
            x.Yazili2 = int.Parse(txt_yazili2.Text);
            x.Performans = int.Parse(txt_performans.Text);
            x.Proje = int.Parse(txt_proje.Text);
            x.Ortalama = int.Parse(txt_ortalama.Text);
            db.SaveChanges();
            MessageBox.Show("Öğrenci notları başarılı bir şekilde güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtID.Text = null;
            txt_yazili1.Text = null;
            txt_yazili2.Text = null;
            txt_performans.Text= null;
            txt_proje.Text = null;
            txt_ortalama.Text = null;

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)//data griwden txtboxlara bilgileri çekiyoruz.
        {
            txtID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_yazili1.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_yazili2.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_performans.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_proje.Text = dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_ogrenci.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ortalama.Text = dataGridView2.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

    
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

               
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

        
            Font _tabFont = new Font("Arial", 15.0f, FontStyle.Bold, GraphicsUnit.Pixel);

            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void page_girisekran_Click(object sender, EventArgs e)
        {

        }

        

        private void btnderslistele_Click(object sender, EventArgs e)// dersleri listeliyoruz.
        {
            var derslistesi = from x in db.TblDersler
                              select new
                              {
                                  x.DersID,
                                  x.DersAdi
                              };
            dataGridView3.DataSource = derslistesi.ToList();
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
            yonetimbilgigiris yonetimgoster = new yonetimbilgigiris();
            yonetimgoster.Show();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            YonetimInfo yonetiminfo = new YonetimInfo();
            this.Close();
            yonetiminfo.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
