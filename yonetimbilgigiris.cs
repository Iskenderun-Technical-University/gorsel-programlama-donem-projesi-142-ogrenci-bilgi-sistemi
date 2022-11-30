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

namespace Login_Ekranı
{
    public partial class yonetimbilgigiris : Form
    {
        public yonetimbilgigiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=142_E_okul;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string parola = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT OgretmenSifre FROM TblOgretmenGirisBilgileri WHERE OgretmenID = @p1 ", baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", txt_id.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    parola = sqlDataReader[0].ToString();
                }
                //label4.Text = parola;

                if (parola == txt_sifre.Text)
                {
                    yonetimpanel yonetimpanel = new yonetimpanel();
                    yonetimpanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adınız Veya Parolanız Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası!" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            /*string id = "Ramazan";
            string sifre = "Ramazan46";

            if(txt_id.Text == id && txt_sifre.Text == sifre)
            {
                yonetimpanel yonetimpanel = new yonetimpanel();
                yonetimpanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız Veya Parolanız Hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/


        }

        private void txt_sifre_TextChanged(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = true;
        }

        private void button_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yonetimbilgigiris_Load(object sender, EventArgs e)
        {

        }
    }
}
