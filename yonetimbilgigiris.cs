using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Ekranı.Entity;

namespace Login_Ekranı
{
    public partial class yonetimbilgigiris : Form
    {
        public yonetimbilgigiris()
        {
            
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=OgrenciSinav;Integrated Security=True");

        private void rjButton3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TblOgretmen Where OgrtNumara=@p1 and OgrtSifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txt_id.Text);
            komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                yonetimpanel yonetimpanel = new yonetimpanel();
                yonetimpanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Numaranız Veya Parolanız Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baglanti.Close();
        }


        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }


        private void yonetimbilgigiris_Load(object sender, EventArgs e)
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
