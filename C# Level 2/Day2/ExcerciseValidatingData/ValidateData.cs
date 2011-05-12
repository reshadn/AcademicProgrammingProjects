using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcerciseValidatingData
{
    public partial class ValidateData : Form
    {
        public ValidateData()
        {
            InitializeComponent();
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Processing data...");
        }

        private void lastNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            //Validate for required entry.
            //Cancel any previous error.

            this.errorProvider1.SetError(this.lastNameTextBox, "");

            if (lastNameTextBox.Text == string.Empty)
            {
                e.Cancel = true; // Cancels the event.
                this.errorProvider1.SetError(lastNameTextBox, "Required Field");
            }

        }

        private void firstNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            //Validate for required entry.
            //Cancel any previous error.

            this.errorProvider1.SetError(this.firstNameTextBox, "");

            if (firstNameTextBox.Text == string.Empty)
            {
                e.Cancel = true; // Cancels the event.
                this.errorProvider1.SetError(firstNameTextBox, "Required Field");
            }
        }

        private void employeeNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider1.SetError(this.employeeNumberTextBox, "");

            if (employeeNumberTextBox.Text == string.Empty)
            {
                e.Cancel = true;
                this.errorProvider1.SetError(employeeNumberTextBox, "Required Field");
            }
        }

        private void employeeNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !e.KeyChar.Equals('-'))
                e.Handled = true;
            //this.errorProvider1.SetError(employeeNumberTextBox, "Must enter a number");
        }

        private void ValidateData_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Allow user to close the form while there is an error.
            e.Cancel = false;
        }
    }
}
