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

        DataClass num = new DataClass()
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCalc.Text += num.;
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



            double result;
            string lamsz = txtCalc.Text;

            //addition
            string[] lams = new string[1000];
            lams = lamsz.Split('+');
            int forad = 0;
           
            foreach (char i in txtCalc.Text)
            {
                if (i == '+')
                {
                    forad += 1;
                }
            }

            if (forad > 0)
            {
                result = Convert.ToDouble(lamss[0]) - Convert.ToDouble(lamss[1]);
                txtCalc.Text = result.ToString();
            }







            //subtraction
            string[] lamss = new string[1000];
            lamss = lamsz.Split('-');

            int forsub = 0;
            foreach (char i in txtCalc.Text)
            {
                if (i == '-')
                {
                    forsub += 1;
                }
            }

            if (forsub > 0)
            {
                result = Convert.ToDouble(lamss[0]) - Convert.ToDouble(lamss[1]);
                txtCalc.Text = result.ToString();
            }




            //multiplication
            int formul = 0;
            string[] lamsss = new string[1000];
            lamsss = lamsz.Split('x');
           

            foreach (char i in txtCalc.Text)
            {
                if (i == 'x')
                {
                    formul += 1;
                }
            }

            if (formul > 0)
            {
                result = Convert.ToDouble(lamsss[0]) * Convert.ToDouble(lamsss[1]);
                txtCalc.Text = result.ToString();
            }




            //division
            int fordid = 0;
            string[] lamssss = new string[1000];
            lamssss = lamsz.Split('÷');
            foreach (char i in txtCalc.Text)
            {
                if (i == '÷')
                {
                    fordid += 1;
                }
            }

            if (fordid > 0)
            {
                result = Convert.ToDouble(lamssss[0]) / Convert.ToDouble(lamssss[1]);
                txtCalc.Text = result.ToString();
            }


            string[] sqrts = new string[1000];
            
            

           



           



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

        private void button19_Click(object sender, EventArgs e)
        {
            txtCalc.Text = "√" + txtCalc.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "^2";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "^3";
        }
    }
}
