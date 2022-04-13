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
    public partial class Welcome : Form
    {
        private int count = 1;
        public Welcome()
        {
            InitializeComponent();

        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
            string path = "D:\\project thesis\\webAppThesis\\dummyProject\\ProjectImage\\" + count + ".jpg";
            this.pbox.Image = Image.FromFile(path);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 5;
            if (this.progressBar1.Value >= 100)
            {
                //this.timer1.Stop();
                this.progressBar1.Value = 0;
                count++;
                if (count == 14)
                { 
                    //count = 1;
                    Form1 fl = new Form1();
                    fl.Visible = true;
                    this.Visible = false;
                   // count = 1;
                    this.timer1.Stop();
                    
                }
                string path = "D:\\project thesis\\webAppThesis\\dummyProject\\ProjectImage\\" + count + ".jpg";

                this.pbox.Image = Image.FromFile(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fl = new Form1();
            fl.Visible = true;
            this.Visible = false;
            this.timer1.Stop();
        }

        private void Welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to close Application?", "Application Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://final.tnrsoft.com");
        }
    }
}
