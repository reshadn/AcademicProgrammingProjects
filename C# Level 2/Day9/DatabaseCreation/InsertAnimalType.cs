using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseCreation
{
    public partial class InsertAnimalType : Form
    {
        private static int countTypes = 0;
        private string insertString = "INSERT INTO [AnimalType] ([Description])" +
            "VALUES (@Description)";

        public InsertAnimalType()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connString = 
                @"Server=.\SQLEXPRESS; AttachDBFileName=c:\Reshad\Day9\DatabaseCreation\Databases\zoo.mdf;
                trusted_connection=true";

            SqlConnection myConnection = new SqlConnection();
            myConnection.ConnectionString = connString;
            myConnection.Open();

            SqlCommand insertCommand = new SqlCommand();
            insertCommand.CommandText = insertString;
            insertCommand.Connection = myConnection;

            insertCommand.Parameters.AddWithValue("@Description",
                textBoxAnimalType.Text);

            insertCommand.ExecuteNonQuery();

            myConnection.Close();

            labelStatus.Text = "Animal Type added: " + (++countTypes).ToString();
        }
    }
}
