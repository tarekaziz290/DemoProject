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
    public partial class Form1 : Form
    {
        public static double x ;
        public Form1()
        {
            InitializeComponent();
            this.txtValue.Text = x.ToString();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSelect.SelectedItem.ToString() == "Location")
            {
                x= x+10;


            }
            else if (this.cmbSelect.SelectedItem.ToString() == "Camera")
            {
                x= x+5;
            }

            else if (this.cmbSelect.SelectedItem.ToString() == "Storage")
            {
                x= x+5;
            }

            else if (this.cmbSelect.SelectedItem.ToString() == "Contacts")
            {
                x= x+5;
            }


            else if (this.cmbSelect.SelectedItem.ToString() == "Calender")
            {
                x= x+2;

            }

            else if (this.cmbSelect.SelectedItem.ToString() == "Microphone")
            {
                x= x+10;

            }
            else if (this.cmbSelect.SelectedItem.ToString() == "Picture")
            {
                x= x+15;

            }
            else if (this.cmbSelect.SelectedItem.ToString() == "Video")
            {
                x= x+20;

            }
            else if (this.cmbSelect.SelectedItem.ToString() == "NID Info")
            {
                x= x+30;

            }
            else if (this.cmbSelect.SelectedItem.ToString() == "BirthCertificate")
            {
                x= x+25;


            }
            else if (this.cmbSelect.SelectedItem.ToString() == "Passport")
            {
                x= x+30;

            }

            else if (this.cmbSelect.SelectedItem.ToString() == "DrivingLicence")
            {
                x= x+20;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.txtValue.Text = x.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you want to use features?\n you need spend 30 points", "User Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (x >= 30)
                {
                    x = x - 30;
                    next fl = new next();
                    fl.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("you have not enough point ");
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to use features?\n you need spend 50 points", "User Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (x >= 50)
                {
                    x = x - 50;
                    Calculator fl = new Calculator();
                    fl.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("you have not enough point ");
                }
            }
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you want to use features?\n you need spend 80 points", "User Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (x >= 80)
                {
                    x = x - 80;
                    Welcome fl = new Welcome();
                    fl.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("you have not enough point ");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      




        











        
    }
}
