using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dummyProject
{
    public partial class Form1 : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { set; get; }
        public SqlCommand Sqlcom { set; get; }
        private string Query { set; get; }
        private string Sql { get; set; }
        public static double x ;
        public string TId { set; get; }
        public Form1()
        {
            InitializeComponent();
            //lblTest.Text = TId;
            this.Da = new DataAccess();
           //this.txtValue.Text = x.ToString();
            //this.txtValue.Text = @"select Balance from User where Id = '" + this.TId + "';";
            balance();
            //this.txtValue.Text = x.ToString();
        }

        private void cmbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbSelect.SelectedItem.ToString() == "Location")
            {
                x= x+5;


            }
            else if (this.cmbSelect.SelectedItem.ToString() == "Camera")
            {
                x= x+5;
            }

            else if (this.cmbSelect.SelectedItem.ToString() == "Storage")
            {
                x= x+7.5;
            }

            else if (this.cmbSelect.SelectedItem.ToString() == "Contacts")
            {
                x= x+10;
            }


            else if (this.cmbSelect.SelectedItem.ToString() == "Calender")
            {
                x= x+5;

            }

            else if (this.cmbSelect.SelectedItem.ToString() == "Microphone")
            {
                x= x+5;

            }
            else if (this.cmbSelect.SelectedItem.ToString() == "Picture")
            {
                x= x+12.50;

            }
            else if (this.cmbSelect.SelectedItem.ToString() == "Video")
            {
                x= x+12.50;

            }
            else if (this.cmbSelect.SelectedItem.ToString() == "NID Info")
            {
                x= x+25;

            }
            else if (this.cmbSelect.SelectedItem.ToString() == "BirthCertificate")
            {
                x= x+25;


            }
            else if (this.cmbSelect.SelectedItem.ToString() == "Passport")
            {
                x= x+25;

            }

            else if (this.cmbSelect.SelectedItem.ToString() == "DrivingLicence")
            {
                x= x+25;

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.txtValue.Text = x.ToString();
            string query = "update Users set Balance = '" + this.txtValue.Text + "'where Id = '" + this.TId + "';";
            int count = this.Da.ExecuteDML(query);


        }

        private void btnNext_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you want to use features?\n you need spend 30 points", "User Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (x >= 30)
                {
                    x = x - 30;
                    string query = "update Users set Balance = '" + this.txtValue.Text + "'where Id = '" + this.TId + "';";
                    int count = this.Da.ExecuteDML(query);
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
            if (MessageBox.Show("Are you want to use features?\n you need spend 40 points", "User Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (x >= 40)
                {
                    x = x - 40;
                    string query = "update Users set Balance = '" + this.txtValue.Text + "'where Id = '" + this.TId + "';";
                    int count = this.Da.ExecuteDML(query);
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
            if (MessageBox.Show("Are you want to use features?\n you need spend 60 points", "User Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (x >= 60)
                {
                    x = x - 60;
                    string query = "update Users set Balance = '" + this.txtValue.Text + "'where Id = '" + this.TId + "';";
                    int count = this.Da.ExecuteDML(query);
                    Welcome fl = new Welcome();
                     fl.Visible = true;
                     this.Visible = false;
                    //System.Diagnostics.Process.Start("https://final.tnrsoft.com");
                }
                else
                {
                    MessageBox.Show("you have not enough point ");
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            SqlConnection Sqlcon = new SqlConnection(@"Data Source=DESKTOP-SGI1TQE;Initial Catalog=projectthesis;Persist Security Info=True;User ID=sa;Password=P@ssword");
            Sqlcon.Open();
            SqlCommand s = new SqlCommand("select Balance from Users where Id = '" + TId + "'; ", Sqlcon);

            SqlDataReader sdr = s.ExecuteReader();
            while (sdr.Read())
            {
                txtValue.Text = sdr.GetValue(0).ToString();
                x = x + Convert.ToDouble(txtValue.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string data = TId;
            lblTest.Text = data;
            balance();
        }
       public void balance()
        {
            SqlConnection Sqlcon = new SqlConnection(@"Data Source=DESKTOP-SGI1TQE;Initial Catalog=projectthesis;Persist Security Info=True;User ID=sa;Password=P@ssword");
            Sqlcon.Open();
            SqlCommand s = new SqlCommand("select Balance from Users where Id = '" + TId + "'; ", Sqlcon);

            SqlDataReader sdr = s.ExecuteReader();
            while (sdr.Read())
            {
                txtValue.Text = sdr.GetValue(0).ToString();
                x = x + Convert.ToDouble(txtValue.Text);
            }
        }
    }
}
