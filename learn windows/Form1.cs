using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int a, b, c,d;
            a = Convert.ToInt32(txt1.Text);
            b = Convert.ToInt32(txt2.Text);
            d = Convert.ToInt32(txt3.Text);
            //c = a + b;
         //   txtans.Text = c.ToString();
            if(a>=b)
            {
                txtans.Text = a.ToString();
            }
            else if(b>=d)
            {
                txtans.Text = b.ToString();
            }
            else 
            {
                txtans.Text = d.ToString();
            }
        }

        private void txtans_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
