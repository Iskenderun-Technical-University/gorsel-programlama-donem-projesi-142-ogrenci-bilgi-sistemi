using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "Ramazan";
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
            }


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
    }
}
