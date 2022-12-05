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

            string[] lams = new string[1000];
            int forad = 0;
            int forsub = 0;
            int formul = 0;
            int fordid = 0;
            double result;
            string lamsz = txtCalc.Text;
            lams = lamsz.Split('+');

            foreach(char i in txtCalc.Text)
            {
                if (i == '+')
                {
                    forad += 1;
                }
            }

            if (forad > 0)
            {
                result = Convert.ToDouble(lams[0]) + Convert.ToDouble(lams[1]);
                txtCalc.Text = result.ToString();
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
