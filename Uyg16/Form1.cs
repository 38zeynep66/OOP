using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double maty, matd, tury, turd;
            double mats, turs;
            maty = Convert.ToDouble(txtMatY.Text);
            matd = Convert.ToDouble(txtMatD.Text);
            tury = Convert.ToDouble(txtTürkçeY.Text);
            turd = Convert.ToDouble(txtTürkçeD.Text);
            
            mats = matd - (maty / 4);
            turs = turd - (tury / 4);
            txtMatS.Text = mats.ToString();        
            txtTürkçeS.Text = turs.ToString();

        }
    }
}
