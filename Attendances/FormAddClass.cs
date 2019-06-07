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
    public partial class FormAddClass : Form
    {

        public int UserId { get; set; }
        public FormAddClass()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.ClasseTBLTableAdapter ada = new DataSet1TableAdapters.ClasseTBLTableAdapter();
            ada.Addclass(metroTextBox1.Text, UserId);
            Close();
        }
    }
}
