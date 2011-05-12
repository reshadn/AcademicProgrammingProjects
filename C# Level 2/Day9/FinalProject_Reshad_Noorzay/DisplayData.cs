using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject_Reshad_Noorzay
{
    public partial class DisplayData : Form
    {
        public DisplayData()
        {
            InitializeComponent();
        }

        private void DisplayData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'officeRequestDataSet3.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.officeRequestDataSet3.Department);
            // TODO: This line of code loads data into the 'officeRequestDataSet3.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter1.Fill(this.officeRequestDataSet3.Department);
            // TODO: This line of code loads data into the 'officeRequestDataSet2.RequestType' table. You can move, or remove it, as needed.
            this.requestTypeTableAdapter.Fill(this.officeRequestDataSet2.RequestType);
            // TODO: This line of code loads data into the 'officeRequestDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.officeRequestDataSet.Employee);

        }

        private void buttonAddData_Click(object sender, EventArgs e)
        {
            AddData addingData = new AddData();
            addingData.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
