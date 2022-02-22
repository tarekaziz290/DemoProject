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
    public partial class Login : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public Login()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "select * from Users where Id = '" + this.txtId.Text + "' and Password = '" + this.txtPassword.Text + "';";

            this.Ds = this.Da.ExecuteQuery(sql);
            if (this.Ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Login Successful");
                this.Visible = false;
                Form1 wf = new Form1();
                wf.Visible = true;


            }
            else
            {
                MessageBox.Show("Login Failed\n Please Try Again");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtId.Text = "";
            this.txtPassword.Text = "";

        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Registration wf = new Registration();
            wf.Visible = true;
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
