using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GatesServicesExercise
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }


        #region Form DB Connection

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            string connectString =

@"Server=.\SQLEXPRESS; AttachDBFileName=C:\Reshad\01C#VisualStudio\2008C#II\Day6\GatesServicesExercise\northwnd.mdf;" +

"Database=Northwind; trusted_connection=true";


            string commandString = "SELECT FirstName, LastName FROM Employees";


            SqlConnection northwindConnection = new SqlConnection(connectString);

            northwindConnection.Open();

            SqlCommand cmd = new SqlCommand(commandString, northwindConnection);


            SqlDataReader aReader = cmd.ExecuteReader();


            try
            {

                while (aReader.Read())

                   comboBoxEmployee.Items.Add(aReader.GetString(1) +

                    ", " + aReader.GetString(0));


                if (comboBoxEmployee.Items.Count > 0)

                    comboBoxEmployee.SelectedIndex = 0;

            }

            catch (Exception eData)
            {

                MessageBox.Show("eData: {0}", eData.ToString());

            }

            finally
            {

                aReader.Close();

                northwindConnection.Close();

            }
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Add Item List
        private void addListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add item to list

            bool itemFoundBoolean = false;

            int counterInt = 0;


            if (comboBoxEmployee.Text == "")
            {

                MessageBox.Show("Please add an item for ComboBox!",

                "Problem", MessageBoxButtons.OK,

                MessageBoxIcon.Error);

            }

            else
            {

                while (!itemFoundBoolean && counterInt < comboBoxEmployee.Items.Count)
                {

                    if (comboBoxEmployee.Text.Equals(comboBoxEmployee.Items[counterInt++].ToString()))
                    {

                        itemFoundBoolean = true;

                    }

                }


                if (!itemFoundBoolean)
                {

                    comboBoxEmployee.Items.Add(comboBoxEmployee.Text);

                    comboBoxEmployee.Text = "";

                }

                else
                {

                    MessageBox.Show("Item already in the list!" +

                    "\nClear ComboBox and then add new item",

                    "Problem", MessageBoxButtons.OK,

                    MessageBoxIcon.Error);

                    comboBoxEmployee.Text = "";

                }

            }
        }
        #endregion

        #region Remove Item

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Remove item from list

            if (comboBoxEmployee.SelectedIndex != -1)
            {

                comboBoxEmployee.Items.RemoveAt(comboBoxEmployee.SelectedIndex);

            }

            else
            {

                MessageBox.Show("Please select item to remove!",

                "Problem", MessageBoxButtons.OK,

                MessageBoxIcon.Error);

            }

        }
#endregion

        #region Clear Item
       
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear list

            DialogResult aDialogResult;


            aDialogResult = MessageBox.Show("Are you sure?",

            "Confirm Clear", MessageBoxButtons.YesNo,

            MessageBoxIcon.Question);

            if (aDialogResult == DialogResult.Yes)
            {

                comboBoxEmployee.Items.Clear();

                comboBoxEmployee.Text = "";
            }
        
        } 
  
        #endregion

        #region Print Preview

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Setup print preview area

            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
        }
        #endregion 

        #region Count
        private void countToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Display List Count

            MessageBox.Show("Current count: " + comboBoxEmployee.Items.Count,

            "Total Items in List", MessageBoxButtons.OK,

            MessageBoxIcon.Information);

        }
        #endregion

        #region About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutGatesForm = new AboutForm();
            aboutGatesForm.ShowDialog();
        }
        #endregion

        #region Print
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        //Print List

            Font titleFont = new Font("Arial", 26, FontStyle.Bold);

            Font detailFont = new Font("Arial", 16);


            float leftEdgeFloat = e.MarginBounds.Left;

            float topEdgeFloat = e.MarginBounds.Top;

            float betweenLinesSpacerFloat = 5;


            e.Graphics.DrawString("Employee List", titleFont, Brushes.Black, 100, 100);

            topEdgeFloat += 25;


            // Loop thru list and print CD area

            for (int loopInteger = 0; loopInteger < comboBoxEmployee.Items.Count; loopInteger++)
            {

                e.Graphics.DrawString(comboBoxEmployee.Items[loopInteger].ToString(),

                detailFont, Brushes.Black, leftEdgeFloat,

                topEdgeFloat += detailFont.GetHeight() + betweenLinesSpacerFloat);

            }

        }
        #endregion


    }
}
