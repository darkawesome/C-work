using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double dbldue = 0;
            double dblAllow = 2000;
            double dblPrice = 0;
            double dblExtras = 0;
            double dblTotal = 0;
            double dblSub = 0;
            double dblTax = 0;
            double dblAccess = 0;

            if (chkLeather.Checked)
            {
                dblPrice += 987.41;
            }
            else if (chkNav.Checked) 
            {
                dblPrice += 1741.23;
            }
            else if (chkStereo.Checked)
            {
                dblPrice += 425.76;
            }
            if(rdbCustom.Checked)
            {
                dblExtras += 599.99;
            }
            else if(rdbPearl.Checked)
            {
                dblExtras += 345.72;
            }
            else if (rdbStd.Checked)
            {
                dblExtras += 0;
            }

            dblAccess = (dblPrice + dblExtras);
            dblSub = (dblPrice+dblExtras + 20000);
            dblTax = (dblSub * 0.08);
            dblTotal = (dblSub + dblTax);
            dbldue = (dblTotal - dblAllow);

            textBox1.Text = "20000";
            textBox2.Text =string.Format ("{0}", dblAccess);
            textBox3.Text =string.Format("{0}", dblSub);
            textBox4.Text = string.Format("{0}", dblTax);
            textBox5.Text = string.Format("{0}", dblTotal);
            textBox6.Text = string.Format("{0}", dblAllow);
            textBox7.Text = string.Format("{0}", dbldue);




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
    }
}
