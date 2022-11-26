using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "9";
            
        }

        private void button16_Click(object sender, EventArgs e)
        {

            char[] lams = new char[1000];
            int forad = 0;
            int forsub = 0;
            int formul = 0;
            int fordid = 0;
            string lamsz = txtCalc.Text;
            //for(int h = 0; h<lamsz.Length;h++) { lams.Append(lamsz[h]); }
            foreach(char tr in lamsz) { if (tr == '+') { forad = forad + 1; } }
            foreach (char tr in lamsz) { if (tr == '-') { forsub = forsub + 1; } }
            foreach (char tr in lamsz) { if (tr == 'x') { formul = formul + 1; } }
            foreach (char tr in lamsz) { if (tr == '÷') { fordid = fordid + 1; } }


            if (forad > 0)
            {
                string lam = txtCalc.Text;
                var adds = lam.Split('+');
                double sums = Convert.ToDouble(adds[0]) + Convert.ToDouble(adds[1]);
                txtCalc.Text = sums.ToString();
            }
            else if (forsub > 0)
            {
                string lam = txtCalc.Text;
                var adds = lam.Split('-');
                double mins = Convert.ToDouble(adds[0]) - Convert.ToDouble(adds[1]);
                txtCalc.Text = mins.ToString();
            }
            else if (formul > 0)
            {
                string lam = txtCalc.Text;
                var adds = lam.Split('x');
                double prods = Convert.ToDouble(adds[0]) * Convert.ToDouble(adds[1]);
                txtCalc.Text = prods.ToString();
            }
            else if (fordid > 0)
            {
                string lam = txtCalc.Text;
                var adds = lam.Split('÷');
                double quos = Convert.ToDouble(adds[0]) / Convert.ToDouble(adds[1]);
                txtCalc.Text = quos.ToString();
            }


            else
            {
                txtCalc.Text = txtCalc.Text;
            }
        }
          
        private void button15_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(txtCalc.Text);
            txtCalc.Text += "+";





        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtCalc.Text += ".";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "-";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "x";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "÷";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "";
        }
    }
}
