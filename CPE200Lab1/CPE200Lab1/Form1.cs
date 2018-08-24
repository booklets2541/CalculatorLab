using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        double result = 0;
        double equal;
        double hold;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        int check = 99;
        private void btnPlus_Click(object sender, EventArgs e)
        {
            check = 0;
            result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            equal = Double.Parse(lblDisplay.Text);

            if (check == 0)
            {
                result = result + equal;
            }
            else if (check == 1)
            {
                result = result - equal;

            }
            else if (check == 2)
            {
                result = result * equal;
            }
            else if (check == 3)
            {
                result = result / equal;
            }
            else if (check == 4)
            {
                result = result + (equal / 100);

            }
            if (result.ToString().Length <= 8)
            {
                lblDisplay.Text = result.ToString();
            }
            else
            {
                lblDisplay.Text = "ERROR";
            }

            }


        private void btnMinus_Click(object sender, EventArgs e)
        {
            check = 1;
            result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            check = 2;
            result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            check = 3;
            result = Double.Parse(lblDisplay.Text);
            lblDisplay.Text = "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            result = 0;
            check = 99;
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Contains('.') == false)
            {
                lblDisplay.Text += ".";
            }
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {

            if(lblDisplay.Text.Length < 8)
            {
                if(lblDisplay.Text == "0")
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else
                {
                    lblDisplay.Text += ((Button)sender).Text;
                }
            }    
        }
        
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text =="0")
            {
                lblDisplay.Text = "0";
            }
            else
            {
                hold = Convert.ToDouble(lblDisplay.Text);
                lblDisplay.Text = Convert.ToString(result * (hold / 100));
            }
        }

        private void Oper_Click(object sender, EventArgs e)
        {

        }
    }
}


        