using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dummyProject
{
    public partial class Calculator : Form
    {
        private String operatorInput;
        private double input1 = 0;
        private double input2 = 0;
        private double result = 0;


        public Calculator()
        {
            InitializeComponent();
        }
        private void calculate()
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "0";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "0";
            }
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "1";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "1";
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "2";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "3";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "4";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "5";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "6";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "7";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "8";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text == "0")
            {
                this.txtScreen.Text = "9";
            }
            else
            {
                this.txtScreen.Text = this.txtScreen.Text + "9";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (this.btnDot.Text == ".")
            {
                if (!this.txtScreen.Text.Contains("."))
                {
                    this.txtScreen.Text = this.txtScreen.Text + this.btnDot.Text;

                }
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (operatorInput == "")
            {
                input1 = Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "-")
            {
                input1 -= Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "*")
            {
                input1 *= Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "/")
            {
                input1 /= Convert.ToDouble(this.txtScreen.Text);
            }
            else
            {
                input1 += Convert.ToDouble(this.txtScreen.Text);
            }
            this.btnDisplay.Text = input1.ToString();
            txtScreen.Text = "";
            operatorInput = "+";

        }

        private void btnSub_Click(object sender, EventArgs e)
        {

            if (operatorInput == "")
            {
                input1 = Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "+")
            {
                input1 += Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "*")
            {
                input1 *= Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "/")
            {
                input1 /= Convert.ToDouble(this.txtScreen.Text);
            }
            else
            {
                input1 -= Convert.ToDouble(this.txtScreen.Text);
            }
            this.btnDisplay.Text = input1.ToString();
            txtScreen.Text = "";
            operatorInput = "-";


        }

        private void btnMulti_Click(object sender, EventArgs e)
        {


            if (operatorInput == "")
            {
                input1 = Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "-")
            {
                input1 -= Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "+")
            {
                input1 += Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "/")
            {
                input1 /= Convert.ToDouble(this.txtScreen.Text);
            }
            else
            {
                input1 *= Convert.ToDouble(this.txtScreen.Text);
            }
            this.btnDisplay.Text = input1.ToString();
            txtScreen.Text = "";
            operatorInput = "*";


        }

        private void btnDiv_Click(object sender, EventArgs e)
        {


            if (operatorInput == "")
            {
                input1 = Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "-")
            {
                input1 -= Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "*")
            {
                input1 *= Convert.ToDouble(this.txtScreen.Text);
            }
            else if (operatorInput == "+")
            {
                input1 += Convert.ToDouble(this.txtScreen.Text);
            }
            else
            {
                input1 /= Convert.ToDouble(this.txtScreen.Text);
            }
            this.btnDisplay.Text = input1.ToString();
            txtScreen.Text = "";
            operatorInput = "/";


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtScreen.Text = "0";
            input1 = 0;
            input2 = 0;
            this.btnDisplay.Text = "";
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.txtScreen.Text.Length > 0)
            {
                this.txtScreen.Text = this.txtScreen.Text.Remove(this.txtScreen.Text.Length - 1, 1);
            }
            if (this.txtScreen.Text == "")
            {
                this.txtScreen.Text = "0";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            input2 = Double.Parse(this.txtScreen.Text);
            switch (operatorInput)
            {
                case "+":
                    {
                        result = input1 + input2;
                        break;
                    }

                case "-":
                    {
                        result = input1 - input2;
                        break;
                    }
                case "*":
                    {
                        result = input1 * input2;
                        break;
                    }
                case "/":
                    {
                        result = input1 / input2;
                        break;
                    }
            }
            this.txtScreen.Text = result.ToString();
            this.btnDisplay.Text = this.txtScreen.Text;
            operatorInput = "";
            input2 = 0;
            input1 = 0;



        }

        private void Calculator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to back?", "Owner Use", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 fl = new Form1();
                fl.Visible = true;
                this.Visible = false;
            }
        }

       
    }
}
