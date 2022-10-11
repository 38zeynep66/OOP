using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace goldsoru3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int etiketfiyati;
            int yapılacakindirim;
            double indirimlihali;
            etiketfiyati = Convert.ToInt32(txtEtiket.Text);
            yapılacakindirim = Convert.ToInt32(txtİndirim.Text);
            indirimlihali = etiketfiyati -etiketfiyati * yapılacakindirim/100;
            label3.Text=(indirimlihali.ToString());
        }
    }
}
