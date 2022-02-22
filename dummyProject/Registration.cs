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
    public partial class Registration : Form
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { set; get; }
        private string Query { set; get; }
        private string Sql { get; set; }
        public Registration()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //this.PopulateGridView();
            this.IdGenerate();
        }
        private void IdGenerate()
        {
            this.Query = "select * from Users order by Id desc";
            this.Ds = this.Da.ExecuteQuery(this.Query);

            string previousId = this.Ds.Tables[0].Rows[0]["Id"].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "U-" + (++serialNo).ToString("000");
            this.txtId.Text = nextId;

        }

        private void btnResistration_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(this.txtId.Text) || String.IsNullOrEmpty(this.txtName.Text) ||
                String.IsNullOrEmpty(this.txtPassword.Text) )
                {
                    MessageBox.Show("please fill all the information.");
                    return;
                }


                //Insert Code
                //int balance = 0;
                    string query = "insert into Users values ('" + this.txtId.Text + "','" + this.txtName.Text + "','" +
                     this.txtPassword.Text + "','0'); ";

                    int count = this.Da.ExecuteDML(query);

                    if (count == 1)
                    {
                        MessageBox.Show("Record Inserted Successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record Insertion Failed.");
                    }
                

               
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login wf = new Login();
            wf.Visible = true;

        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ClearAll()
        {
            
            this.txtId.Text = "";
            this.txtPassword.Text = "";
           
            this.txtName.Text = "";
           
            this.IdGenerate();



        }
    }
}
