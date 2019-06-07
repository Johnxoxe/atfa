using System;
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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public int loggedIn { get; set; }
        public MainForm()
        {
            loggedIn = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {

            if(loggedIn == 0)
            {
                //open the login form 
                LoginForm newLogin = new LoginForm();
                newLogin.ShowDialog();

                bool ver = newLogin.loginFlaf;

                if (ver == false)
                {
                    Close();
                }
                else
                {
                    loggedIn = 1;
                }
            }
        }
    }
}
