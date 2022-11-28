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
    public partial class yonetimpanel : Form
    {
        public yonetimpanel()
        {
            InitializeComponent();
        }

        private void button_kapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void yonetimpanel_Load(object sender, EventArgs e)
        {

        }
    }
}
