namespace EnumerationsCreditCardType
{
    partial class CreditCardType
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
            this.comboBoxCreditCard = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCreditCard = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Credit Card Type:";
            // 
            // comboBoxCreditCard
            // 
            this.comboBoxCreditCard.FormattingEnabled = true;
            this.comboBoxCreditCard.Location = new System.Drawing.Point(29, 67);
            this.comboBoxCreditCard.Name = "comboBoxCreditCard";
            this.comboBoxCreditCard.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCreditCard.TabIndex = 1;
            this.comboBoxCreditCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxCreditCard_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selected Card Type is: ";
            // 
            // labelCreditCard
            // 
            this.labelCreditCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCreditCard.Location = new System.Drawing.Point(153, 116);
            this.labelCreditCard.Name = "labelCreditCard";
            this.labelCreditCard.Size = new System.Drawing.Size(147, 23);
            this.labelCreditCard.TabIndex = 3;
            // 
            // btnTest
            // 
            this.btnTest.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.Location = new System.Drawing.Point(59, 174);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(98, 42);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "&Exit";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // CreditCardType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 281);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.labelCreditCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCreditCard);
            this.Controls.Add(this.label1);
            this.Name = "CreditCardType";
            this.Text = "Credit Card Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCreditCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCreditCard;
        private System.Windows.Forms.Button btnTest;
    }
}

