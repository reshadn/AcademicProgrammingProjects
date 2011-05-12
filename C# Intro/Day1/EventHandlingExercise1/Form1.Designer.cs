namespace EventHandlingExercise1
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
            this.csharpButton = new System.Windows.Forms.Button();
            this.vbButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // csharpButton
            // 
            this.csharpButton.Location = new System.Drawing.Point(65, 55);
            this.csharpButton.Name = "csharpButton";
            this.csharpButton.Size = new System.Drawing.Size(75, 23);
            this.csharpButton.TabIndex = 0;
            this.csharpButton.Text = "C#";
            this.csharpButton.UseVisualStyleBackColor = true;
            this.csharpButton.Click += new System.EventHandler(this.csharpButton_Click);
            // 
            // vbButton
            // 
            this.vbButton.Location = new System.Drawing.Point(309, 54);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(75, 23);
            this.vbButton.TabIndex = 1;
            this.vbButton.Text = "VB";
            this.vbButton.UseVisualStyleBackColor = true;
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 173);
            this.Controls.Add(this.vbButton);
            this.Controls.Add(this.csharpButton);
            this.Name = "Form1";
            this.Text = "Which Language Is Better: C# or VB?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button csharpButton;
        private System.Windows.Forms.Button vbButton;
    }
}

