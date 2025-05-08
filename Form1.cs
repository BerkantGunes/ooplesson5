using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,sonuc;

            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);

            sonuc = sayi1 + sayi2;

            MessageBox.Show(sonuc.ToString());
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);

            sonuc = sayi1 - sayi2;

            MessageBox.Show(sonuc.ToString());
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;

            sayi1 = int.Parse(txtSayi1.Text);
            sayi2 = int.Parse(txtSayi2.Text);

            sonuc = sayi1 * sayi2;

            MessageBox.Show(sonuc.ToString());
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;

            sayi1 = double.Parse(txtSayi1.Text);
            sayi2 = double.Parse(txtSayi2.Text);

            sonuc = sayi1 / sayi2;

            MessageBox.Show(sonuc.ToString());
        }
    }
}
