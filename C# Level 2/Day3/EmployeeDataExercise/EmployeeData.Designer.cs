namespace EmployeeDataExercise
{
    partial class EmployeeData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.executiveButton = new System.Windows.Forms.Button();
            this.employeeTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.totalSalaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name:";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(46, 93);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(39, 13);
            this.salaryLabel.TabIndex = 1;
            this.salaryLabel.Text = "Salary:";
            // 
            // executiveButton
            // 
            this.executiveButton.Location = new System.Drawing.Point(358, 43);
            this.executiveButton.Name = "executiveButton";
            this.executiveButton.Size = new System.Drawing.Size(75, 23);
            this.executiveButton.TabIndex = 2;
            this.executiveButton.Text = "&Executive";
            this.executiveButton.UseVisualStyleBackColor = true;
            this.executiveButton.Click += new System.EventHandler(this.executiveButton_Click);
            // 
            // employeeTextBox
            // 
            this.employeeTextBox.Location = new System.Drawing.Point(143, 46);
            this.employeeTextBox.Name = "employeeTextBox";
            this.employeeTextBox.Size = new System.Drawing.Size(142, 20);
            this.employeeTextBox.TabIndex = 3;
            this.employeeTextBox.Text = "John Smith";
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(143, 90);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(142, 20);
            this.salaryTextBox.TabIndex = 4;
            this.salaryTextBox.Text = "67000";
            // 
            // totalSalaryButton
            // 
            this.totalSalaryButton.Location = new System.Drawing.Point(279, 180);
            this.totalSalaryButton.Name = "totalSalaryButton";
            this.totalSalaryButton.Size = new System.Drawing.Size(131, 23);
            this.totalSalaryButton.TabIndex = 5;
            this.totalSalaryButton.Text = "&Calculate Total Salary";
            this.totalSalaryButton.UseVisualStyleBackColor = true;
            this.totalSalaryButton.Click += new System.EventHandler(this.totalSalaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(416, 180);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(60, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total Salary:";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.Location = new System.Drawing.Point(118, 224);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(142, 20);
            this.lblTotalSalary.TabIndex = 8;
            // 
            // EmployeeData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 266);
            this.Controls.Add(this.lblTotalSalary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalSalaryButton);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.employeeTextBox);
            this.Controls.Add(this.executiveButton);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeData";
            this.Text = "Employee Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Button executiveButton;
        private System.Windows.Forms.TextBox employeeTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.Button totalSalaryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalSalary;
    }
}

