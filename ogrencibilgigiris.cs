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
    public partial class ogrencibilgigiris : Form
    {
        public ogrencibilgigiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "Ramazan";
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
            }
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
    }
}
