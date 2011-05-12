using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ValidatingData
{
    public partial class DisplayData : Form
    {
        public DisplayData()
        {
            InitializeComponent();
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (txtLastName.Text == "")
            {
                errorProvider1.SetError(txtLastName,
                    "Please enter your last name");
            }
            else
                errorProvider1.SetError(txtLastName, "");
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                errorProvider1.SetError(txtFirstName,
                    "Please enter your first name.");
            }
            else
                errorProvider1.SetError(txtFirstName, "");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string holdString = "Name: " + txtLastName.Text +
                ", " + txtFirstName.Text + "\n" +
                "Salary (txtSalary): " + txtSalary.Text + "\n" +
                "Salary (maskedTextBox): " + mtxtSalary.Text;
            MessageBox.Show(this, holdString, "Employee Information",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            int anInterger = Convert.ToInt32(e.KeyChar);
            if (anInterger >= 47 && anInterger <= 57)
            {
                e.Handled = false;
                return;
            }
            if (anInterger == 8)  // 8 is ASCII character BackSpace
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;      // true means it's a bad character
        }

    }
}
