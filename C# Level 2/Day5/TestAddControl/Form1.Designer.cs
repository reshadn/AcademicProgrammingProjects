namespace TestAddControl
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.ucAddControl1 = new AddControl.ucAddControl();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(51, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ucAddControl1
            // 
            this.ucAddControl1.Location = new System.Drawing.Point(13, 13);
            this.ucAddControl1.Name = "ucAddControl1";
            this.ucAddControl1.Size = new System.Drawing.Size(587, 114);
            this.ucAddControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 272);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ucAddControl1);
            this.Name = "Form1";
            this.Text = "Test Add User Control";
            this.ResumeLayout(false);

        }

        #endregion

        private AddControl.ucAddControl ucAddControl1;
        private System.Windows.Forms.Button btnAdd;
    }
}

