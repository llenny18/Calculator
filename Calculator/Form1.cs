using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataClass dc = new DataClass();

        private void button9_Click(object sender, EventArgs e)
        {
            txtCalc.Text += dc.num1.ToString();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCalc.Text += dc.num2.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCalc.Text += dc.num3.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCalc.Text += dc.num4.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCalc.Text += dc.num5.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            

            txtCalc.Text += dc.num6.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            txtCalc.Text += dc.num7.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCalc.Text +=dc.num8.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCalc.Text += dc.num9.ToString();

        }

         




        private void button16_Click(object sender, EventArgs e)
        {

            double result;
            string lamsz = txtCalc.Text;




            int cb = 0;
            int addcb = 0;
            foreach (char o in txtCalc.Text)
            {

                if (o == '^')
                {
                    cb += 1;

                }
                else if (o == '³')
                {
                    cb += 1;
                    txtCalc.Text = txtCalc.Text.Remove(addcb - 1);
                }

                addcb += 1;
            }

            if (cb > 1)
            {
                result = Convert.ToDouble(txtCalc.Text) * Convert.ToDouble(txtCalc.Text) * Convert.ToDouble(txtCalc.Text);
                txtCalc.Text = result.ToString();
                cb = 0;
            }


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
                result = Convert.ToDouble(lams[0]) + Convert.ToDouble(lams[1]);
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





            //sqrt
            

            int sq = 0;
            int addsq = 0;
            foreach (char i in txtCalc.Text)
            {
                
                if (i == '^')
                {
                    sq += 1;
                    txtCalc.Text = txtCalc.Text.Remove(addsq);
                }
                else if (i == '²')
                {
                    sq += 1;
                   
                }

                addsq += 1;
            }

            if (sq >1)
            {
                result = Convert.ToDouble(txtCalc.Text) * Convert.ToDouble(txtCalc.Text);
                txtCalc.Text = result.ToString();
                sq = 0;
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
            txtCalc.Text += dc.num0.ToString();
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
            txtCalc.Text += "^²";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "^³";
        }





    }
}
