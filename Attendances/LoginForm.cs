﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendances
{
    public partial class LoginForm : Form
    {
        public bool loginFlaf { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            loginFlaf = false;
        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void MetroButtonLogin_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.UsersTableAdapter userAda = new DataSet1TableAdapters.UsersTableAdapter();
            DataTable dt = userAda.GetDataByUserAndPass(metroTextBoxUser.Text, metroTextBoxPassword.Text);

            if (dt.Rows.Count > 0)
            {
                //Valid
                MessageBox.Show("Loged in!");
                loginFlaf = true;
            }
            else
            {
                //not valid
                MessageBox.Show("Try again");
                loginFlaf = false;
            }
            Close();
        }
    }
}
