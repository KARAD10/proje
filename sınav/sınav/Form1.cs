using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            Form2 oyunEkrani = new Form2();
            oyunEkrani.Show();

            this.Hide();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            bool cikisOnayi = MessageBox.Show(
        "Çıkış yapmak istediğinize emin misiniz?",
        "Çıkış Onayı",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question) == DialogResult.Yes;

            if (cikisOnayi)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Oyuna devam ediliyor.");
            }
        }
    }
}
