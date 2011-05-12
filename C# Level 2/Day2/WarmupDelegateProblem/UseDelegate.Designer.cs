namespace WarmupDelegateProblem
{
    partial class UseDelegate
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.formatButton = new System.Windows.Forms.Button();
            this.percentRadioButton = new System.Windows.Forms.RadioButton();
            this.dollarRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(26, 23);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "1.25";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(284, 23);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputTextBox.TabIndex = 1;
            // 
            // formatButton
            // 
            this.formatButton.Location = new System.Drawing.Point(169, 20);
            this.formatButton.Name = "formatButton";
            this.formatButton.Size = new System.Drawing.Size(75, 23);
            this.formatButton.TabIndex = 2;
            this.formatButton.Text = "Format Text";
            this.formatButton.UseVisualStyleBackColor = true;
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click);
            // 
            // percentRadioButton
            // 
            this.percentRadioButton.AutoSize = true;
            this.percentRadioButton.Checked = true;
            this.percentRadioButton.Location = new System.Drawing.Point(26, 84);
            this.percentRadioButton.Name = "percentRadioButton";
            this.percentRadioButton.Size = new System.Drawing.Size(128, 17);
            this.percentRadioButton.TabIndex = 3;
            this.percentRadioButton.TabStop = true;
            this.percentRadioButton.Text = "Format as percentage";
            this.percentRadioButton.UseVisualStyleBackColor = true;
            this.percentRadioButton.CheckedChanged += new System.EventHandler(this.percentRadioButton_CheckedChanged);
            // 
            // dollarRadioButton
            // 
            this.dollarRadioButton.AutoSize = true;
            this.dollarRadioButton.Location = new System.Drawing.Point(26, 120);
            this.dollarRadioButton.Name = "dollarRadioButton";
            this.dollarRadioButton.Size = new System.Drawing.Size(137, 17);
            this.dollarRadioButton.TabIndex = 4;
            this.dollarRadioButton.TabStop = true;
            this.dollarRadioButton.Text = "Format as dollar amount";
            this.dollarRadioButton.UseVisualStyleBackColor = true;
            this.dollarRadioButton.CheckedChanged += new System.EventHandler(this.dollarRadioButton_CheckedChanged);
            // 
            // UseDelegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 175);
            this.Controls.Add(this.dollarRadioButton);
            this.Controls.Add(this.percentRadioButton);
            this.Controls.Add(this.formatButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "UseDelegate";
            this.Text = "Use a Delegate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button formatButton;
        private System.Windows.Forms.RadioButton percentRadioButton;
        private System.Windows.Forms.RadioButton dollarRadioButton;
    }
}

