﻿using System;
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
    public partial class next : Form
    {
        public int count = 16;
        public next()
        {  
            InitializeComponent();
            string path = "C:\\Users\\TAREK PC\\Desktop\\ProjectImage\\" + count + ".jpg";
            this.pbox.Image = Image.FromFile(path);
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

        private void next_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

      
    }
}
