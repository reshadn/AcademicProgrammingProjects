using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeDataExercise
{
    public partial class EmployeeData : Form
    {
        private Label bonusLabel;
        private TextBox bonusTextBox;
        private bool isExecutive = false;

        public EmployeeData()
        {
            InitializeComponent();
        }

        private void executiveButton_Click(object sender, EventArgs e)
        {
            isExecutive = true;
            bonusLabel = new Label();
            bonusLabel.Left = salaryLabel.Left;
            bonusLabel.Top = salaryLabel.Top + 40;
            bonusLabel.Text = "Bonus:";
            bonusLabel.TextAlign = salaryLabel.TextAlign;
            bonusLabel.Size = salaryLabel.Size;

            this.Controls.Add(bonusLabel);

            bonusTextBox = new TextBox();
            bonusTextBox.Left = salaryTextBox.Left;
            bonusTextBox.Top = salaryTextBox.Top + 40;
            bonusTextBox.Size = salaryTextBox.Size;

            this.Controls.Add(bonusTextBox);
        }

        private void totalSalaryButton_Click(object sender, EventArgs e)
        {
            decimal decTotalSalary;
            if (isExecutive)
                decTotalSalary = decimal.Parse(salaryTextBox.Text,
                    System.Globalization.NumberStyles.Currency) +
                    decimal.Parse(bonusTextBox.Text,
                    System.Globalization.NumberStyles.Currency);
            else
                decTotalSalary = decimal.Parse(salaryTextBox.Text,
                    System.Globalization.NumberStyles.Currency);

            lblTotalSalary.Text = decTotalSalary.ToString("C");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
