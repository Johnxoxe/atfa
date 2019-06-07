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
        public int UserId { get; set; }
        public MainForm()
        {
            loggedIn = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ClasseTBL' table. You can move, or remove it, as needed.
            this.classeTBLTableAdapter.Fill(this.dataSet1.ClasseTBL);

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
                    UserId = newLogin.UserId;
                    statLbUser.Text = UserId.ToString();
                    loggedIn = 1;
                }
            }
        }

        private void MetroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {

        }

        private void MetroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            FormAddClass addClass = new FormAddClass();
            addClass.UserId = this.UserId;
            addClass.ShowDialog();
        }
    }
}
