using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject_Reshad_Noorzay
{
    public partial class AddData : Form
    {

        private static int countTypes = 0;
        //private static int countTypesEmployee = 0;
        private string insertStringDepartment = "INSERT INTO [Department] ([Department], [Region], [AreaCode])" +
            "VALUES (@Department, @Region, @AreaCode)";
        //private string insertStringEmployee = "INSERT INTO [Employee] ([FirstName], [LastName], [Phone])" +
        //    "VALUES (@FirstName, @LastName, @Phone)";

        public AddData()
        {
            InitializeComponent();
        }

        private void buttonDepartmentAdd_Click(object sender, EventArgs e)
        {
            string connString =
            @"Server=.\SQLEXPRESS; AttachDBFileName=e:\FinalProject_Reshad_Noorzay\Databases\OfficeRequest.mdf;
                trusted_connection=true";

            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = connString;
            myConnection.Open();

            SqlCommand insertCommand = new SqlCommand();
            insertCommand.CommandText = insertStringDepartment;
            insertCommand.Connection = myConnection;

            insertCommand.Parameters.AddWithValue("@Department",
                textBoxDepartment.Text);
            insertCommand.Parameters.AddWithValue("@Region",
                textBoxRegion.Text);
            insertCommand.Parameters.AddWithValue("@AreaCode",
                textBoxAreaCode.Text);

            insertCommand.ExecuteNonQuery();

            myConnection.Close();

            labelDepartmentStatus.Text = "Department(s) added: " + (++countTypes).ToString();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEmployeeAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently inactive.");
//            string connStringEmployee = @"Server=.\SQLEXPRESS; AttachDBFileName=c:\Reshad\01C#VisualStudio\2008C#II\Day9\FinalProject_Reshad_Noorzay\Databases\OfficeRequest.mdf;
//                trusted_connection=true";

//            SqlConnection myConnectionEmployee = new SqlConnection();
//            myConnectionEmployee.ConnectionString = connStringEmployee;
//            myConnectionEmployee.Open();

//            SqlCommand insertCommandEmployee = new SqlCommand();
//            insertCommandEmployee.CommandText = insertStringEmployee;
//            insertCommandEmployee.Connection = myConnectionEmployee;

//            insertCommandEmployee.Parameters.AddWithValue("@FirstName",
//                textBoxDepartment.Text);
//            insertCommandEmployee.Parameters.AddWithValue("@LastName",
//                textBoxRegion.Text);
//            insertCommandEmployee.Parameters.AddWithValue("@Phone",
//                textBoxAreaCode.Text);

//            insertCommandEmployee.ExecuteNonQuery();

//            myConnectionEmployee.Close();

//            labelEmployeeStatus.Text = "Employee(s) added: " + (++countTypesEmployee).ToString();

        }

        private void buttonRequestAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently inactive.");
        }

        private void textBoxDepartment_Validating(object sender, CancelEventArgs e)
        {
            //Validate for required entry.
            this.errorProvider1.SetError(this.textBoxDepartment, "");

            if (textBoxDepartment.Text == string.Empty)
            {
                e.Cancel = true; // Cancels the event.
                this.errorProvider1.SetError(textBoxDepartment, "Required Field");
            }
        }

        private void textBoxRegion_Validating(object sender, CancelEventArgs e)
        {
            //Validate for required entry.
            this.errorProvider1.SetError(this.textBoxRegion, "");

            if (textBoxRegion.Text == string.Empty)
            {
                e.Cancel = true; // Cancels the event.
                this.errorProvider1.SetError(textBoxRegion, "Required Field");
            }
        }

        private void textBoxAreaCode_Validating(object sender, CancelEventArgs e)
        {
            //Validate for required entry.
            this.errorProvider1.SetError(this.textBoxAreaCode, "");

            if (textBoxAreaCode.Text == string.Empty)
            {
                e.Cancel = true; // Cancels the event.
                this.errorProvider1.SetError(textBoxAreaCode, "Required Field");
            }

        }

        private void AddData_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Allow user to close the form while there is an error.
            e.Cancel = false;
        }

        private void textBoxAreaCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
