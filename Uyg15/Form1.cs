using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi ;
            sayi = Convert.ToInt32(txtUrunFıyatı.Text);
            double indirimlifiyat;
            indirimlifiyat=sayi-sayi*0.10;
            label3.Text = indirimlifiyat.ToString() ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(txtUrunFıyatı.Text);
            double indirimlifiyat;
            indirimlifiyat = sayi - sayi * 0.25;
            label3.Text = indirimlifiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(txtUrunFıyatı.Text);
            double indirimlifiyat;
            indirimlifiyat = sayi - sayi * 0.50;
            label3.Text = indirimlifiyat.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(txtUrunFıyatı.Text);
            double indirimlifiyat;
            indirimlifiyat = sayi - sayi * 0.75;
            label3.Text = indirimlifiyat.ToString();
        }
    }
}
