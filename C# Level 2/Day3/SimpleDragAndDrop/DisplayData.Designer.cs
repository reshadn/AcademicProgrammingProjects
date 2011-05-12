namespace SimpleDragAndDrop
{
    partial class DisplayData
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.sourceDataTextBox = new System.Windows.Forms.TextBox();
            this.cantDropHereTextBox = new System.Windows.Forms.TextBox();
            this.dropHereTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Data: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Can\'t Drop Here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Drop Here:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(290, 207);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sourceDataTextBox
            // 
            this.sourceDataTextBox.Location = new System.Drawing.Point(130, 36);
            this.sourceDataTextBox.Name = "sourceDataTextBox";
            this.sourceDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.sourceDataTextBox.TabIndex = 1;
            this.sourceDataTextBox.Text = "default data...";
            this.sourceDataTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sourceDataTextBox_MouseDown);
            // 
            // cantDropHereTextBox
            // 
            this.cantDropHereTextBox.Location = new System.Drawing.Point(130, 118);
            this.cantDropHereTextBox.Name = "cantDropHereTextBox";
            this.cantDropHereTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantDropHereTextBox.TabIndex = 3;
            // 
            // dropHereTextBox
            // 
            this.dropHereTextBox.AllowDrop = true;
            this.dropHereTextBox.Location = new System.Drawing.Point(130, 162);
            this.dropHereTextBox.Name = "dropHereTextBox";
            this.dropHereTextBox.Size = new System.Drawing.Size(100, 20);
            this.dropHereTextBox.TabIndex = 5;
            this.dropHereTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.dropHereTextBox_DragDrop);
            this.dropHereTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.dropHereTextBox_DragEnter);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(27, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(338, 10);
            this.label4.TabIndex = 7;
            // 
            // DisplayData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 267);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dropHereTextBox);
            this.Controls.Add(this.cantDropHereTextBox);
            this.Controls.Add(this.sourceDataTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DisplayData";
            this.Text = "Display Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox sourceDataTextBox;
        private System.Windows.Forms.TextBox cantDropHereTextBox;
        private System.Windows.Forms.TextBox dropHereTextBox;
        private System.Windows.Forms.Label label4;
    }
}

