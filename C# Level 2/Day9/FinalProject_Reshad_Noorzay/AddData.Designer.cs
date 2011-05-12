namespace FinalProject_Reshad_Noorzay
{
    partial class AddData
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.buttonEmployeeAdd = new System.Windows.Forms.Button();
            this.labelEmployeeStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.groupBoxDepartment = new System.Windows.Forms.GroupBox();
            this.buttonDepartmentAdd = new System.Windows.Forms.Button();
            this.labelDepartmentStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRegion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAreaCode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxRequestType = new System.Windows.Forms.GroupBox();
            this.buttonRequestAdd = new System.Windows.Forms.Button();
            this.comboBoxRequestType = new System.Windows.Forms.ComboBox();
            this.labelRequestStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxDepartment.SuspendLayout();
            this.groupBoxRequestType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name: ";
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.buttonEmployeeAdd);
            this.groupBoxEmployee.Controls.Add(this.labelEmployeeStatus);
            this.groupBoxEmployee.Controls.Add(this.label4);
            this.groupBoxEmployee.Controls.Add(this.textBoxLName);
            this.groupBoxEmployee.Controls.Add(this.label3);
            this.groupBoxEmployee.Controls.Add(this.textBoxPhoneNumber);
            this.groupBoxEmployee.Controls.Add(this.label2);
            this.groupBoxEmployee.Controls.Add(this.textBoxFName);
            this.groupBoxEmployee.Controls.Add(this.label1);
            this.groupBoxEmployee.Location = new System.Drawing.Point(12, 152);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(388, 134);
            this.groupBoxEmployee.TabIndex = 1;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Employee Information";
            // 
            // buttonEmployeeAdd
            // 
            this.buttonEmployeeAdd.Location = new System.Drawing.Point(250, 59);
            this.buttonEmployeeAdd.Name = "buttonEmployeeAdd";
            this.buttonEmployeeAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonEmployeeAdd.TabIndex = 6;
            this.buttonEmployeeAdd.Text = "Add &Employee";
            this.buttonEmployeeAdd.UseVisualStyleBackColor = true;
            this.buttonEmployeeAdd.Click += new System.EventHandler(this.buttonEmployeeAdd_Click);
            // 
            // labelEmployeeStatus
            // 
            this.labelEmployeeStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelEmployeeStatus.Location = new System.Drawing.Point(59, 100);
            this.labelEmployeeStatus.Name = "labelEmployeeStatus";
            this.labelEmployeeStatus.Size = new System.Drawing.Size(291, 23);
            this.labelEmployeeStatus.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status: ";
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(250, 30);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name: ";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(84, 62);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone Number: ";
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(75, 30);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFName.TabIndex = 1;
            // 
            // groupBoxDepartment
            // 
            this.groupBoxDepartment.Controls.Add(this.buttonDepartmentAdd);
            this.groupBoxDepartment.Controls.Add(this.labelDepartmentStatus);
            this.groupBoxDepartment.Controls.Add(this.label6);
            this.groupBoxDepartment.Controls.Add(this.textBoxRegion);
            this.groupBoxDepartment.Controls.Add(this.label7);
            this.groupBoxDepartment.Controls.Add(this.textBoxAreaCode);
            this.groupBoxDepartment.Controls.Add(this.label8);
            this.groupBoxDepartment.Controls.Add(this.textBoxDepartment);
            this.groupBoxDepartment.Controls.Add(this.label9);
            this.groupBoxDepartment.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDepartment.Name = "groupBoxDepartment";
            this.groupBoxDepartment.Size = new System.Drawing.Size(388, 134);
            this.groupBoxDepartment.TabIndex = 0;
            this.groupBoxDepartment.TabStop = false;
            this.groupBoxDepartment.Text = "Department Information";
            // 
            // buttonDepartmentAdd
            // 
            this.buttonDepartmentAdd.Location = new System.Drawing.Point(250, 59);
            this.buttonDepartmentAdd.Name = "buttonDepartmentAdd";
            this.buttonDepartmentAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonDepartmentAdd.TabIndex = 6;
            this.buttonDepartmentAdd.Text = "Add &Department";
            this.buttonDepartmentAdd.UseVisualStyleBackColor = true;
            this.buttonDepartmentAdd.Click += new System.EventHandler(this.buttonDepartmentAdd_Click);
            // 
            // labelDepartmentStatus
            // 
            this.labelDepartmentStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDepartmentStatus.Location = new System.Drawing.Point(59, 100);
            this.labelDepartmentStatus.Name = "labelDepartmentStatus";
            this.labelDepartmentStatus.Size = new System.Drawing.Size(291, 23);
            this.labelDepartmentStatus.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Status: ";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.Location = new System.Drawing.Point(250, 30);
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.Size = new System.Drawing.Size(100, 20);
            this.textBoxRegion.TabIndex = 3;
            this.textBoxRegion.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxRegion_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Region: ";
            // 
            // textBoxAreaCode
            // 
            this.textBoxAreaCode.Location = new System.Drawing.Point(75, 62);
            this.textBoxAreaCode.Name = "textBoxAreaCode";
            this.textBoxAreaCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxAreaCode.TabIndex = 5;
            this.textBoxAreaCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAreaCode_KeyPress);
            this.textBoxAreaCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAreaCode_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Area Code: ";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(75, 30);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(100, 20);
            this.textBoxDepartment.TabIndex = 1;
            this.textBoxDepartment.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDepartment_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Department: ";
            // 
            // groupBoxRequestType
            // 
            this.groupBoxRequestType.Controls.Add(this.buttonRequestAdd);
            this.groupBoxRequestType.Controls.Add(this.comboBoxRequestType);
            this.groupBoxRequestType.Controls.Add(this.labelRequestStatus);
            this.groupBoxRequestType.Controls.Add(this.label10);
            this.groupBoxRequestType.Controls.Add(this.textBoxDate);
            this.groupBoxRequestType.Controls.Add(this.label12);
            this.groupBoxRequestType.Controls.Add(this.label13);
            this.groupBoxRequestType.Location = new System.Drawing.Point(12, 292);
            this.groupBoxRequestType.Name = "groupBoxRequestType";
            this.groupBoxRequestType.Size = new System.Drawing.Size(388, 134);
            this.groupBoxRequestType.TabIndex = 2;
            this.groupBoxRequestType.TabStop = false;
            this.groupBoxRequestType.Text = "Request Type";
            // 
            // buttonRequestAdd
            // 
            this.buttonRequestAdd.Location = new System.Drawing.Point(261, 62);
            this.buttonRequestAdd.Name = "buttonRequestAdd";
            this.buttonRequestAdd.Size = new System.Drawing.Size(89, 23);
            this.buttonRequestAdd.TabIndex = 4;
            this.buttonRequestAdd.Text = "Add &Request";
            this.buttonRequestAdd.UseVisualStyleBackColor = true;
            this.buttonRequestAdd.Click += new System.EventHandler(this.buttonRequestAdd_Click);
            // 
            // comboBoxRequestType
            // 
            this.comboBoxRequestType.FormattingEnabled = true;
            this.comboBoxRequestType.Items.AddRange(new object[] {
            "Update",
            "New Page",
            "Broken Link",
            "Other"});
            this.comboBoxRequestType.Location = new System.Drawing.Point(84, 33);
            this.comboBoxRequestType.Name = "comboBoxRequestType";
            this.comboBoxRequestType.Size = new System.Drawing.Size(160, 21);
            this.comboBoxRequestType.TabIndex = 1;
            // 
            // labelRequestStatus
            // 
            this.labelRequestStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRequestStatus.Location = new System.Drawing.Point(59, 100);
            this.labelRequestStatus.Name = "labelRequestStatus";
            this.labelRequestStatus.Size = new System.Drawing.Size(291, 23);
            this.labelRequestStatus.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Status: ";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(84, 62);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Date: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Request Type: ";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(287, 432);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 460);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBoxRequestType);
            this.Controls.Add(this.groupBoxDepartment);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "AddData";
            this.Text = "Add New Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddData_FormClosing);
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.groupBoxDepartment.ResumeLayout(false);
            this.groupBoxDepartment.PerformLayout();
            this.groupBoxRequestType.ResumeLayout(false);
            this.groupBoxRequestType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.Button buttonEmployeeAdd;
        private System.Windows.Forms.Label labelEmployeeStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxDepartment;
        private System.Windows.Forms.Button buttonDepartmentAdd;
        private System.Windows.Forms.Label labelDepartmentStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRegion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAreaCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxRequestType;
        private System.Windows.Forms.Label labelRequestStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxRequestType;
        private System.Windows.Forms.Button buttonRequestAdd;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}