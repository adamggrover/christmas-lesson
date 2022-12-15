using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            People objPerson = new People(txtbFirstName.Text, txbLastName.Text);

            lblOutput.Visible = true;

            
            lblOutput.Text = objPerson.FName + " " + objPerson.LName;
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

            if (this.txtbFirstName.Text != "" && this.txbLastName.Text != "")
            {
                btnExecute.Enabled = true;
            }
            else
            {
                btnExecute.Enabled = false;
            }



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
