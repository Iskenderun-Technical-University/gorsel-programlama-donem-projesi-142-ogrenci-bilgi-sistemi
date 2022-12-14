using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Ekranı
{
    public partial class ogrencibilgigiris : Form
    {
        public ogrencibilgigiris()
        {
            
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");



        private void rjButton3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOgrenci Where OgrNumara=@p1 and OgrSifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",mtxtbox_giris.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr =komut.ExecuteReader();
            if(dr.Read())
            {
                ogrencibilgiekran ogrencibilgiekran = new ogrencibilgiekran();
                ogrencibilgiekran.numara = mtxtbox_giris.Text;
                ogrencibilgiekran.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Numaranız Veya Parolanız Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
                /* string id = "Ramazan";
             string sifre = "Ramazan46";

             if (txt_id.Text == id && txt_sifre.Text == sifre)
             {
                 ogrencibilgiekran ogrencibilgiekran = new ogrencibilgiekran();
                 ogrencibilgiekran.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Kullanıcı Adınız Veya Parolanız Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }

        private void ogrencibilgigiris_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        
    }
}
