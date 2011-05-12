namespace UserInterface
{
    partial class FormB
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
            this.lblFormB = new System.Windows.Forms.Label();
            this.lblRightClick = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.messageBosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFormB
            // 
            this.lblFormB.AutoSize = true;
            this.lblFormB.Location = new System.Drawing.Point(37, 34);
            this.lblFormB.Name = "lblFormB";
            this.lblFormB.Size = new System.Drawing.Size(65, 13);
            this.lblFormB.TabIndex = 0;
            this.lblFormB.Text = "Form B Area";
            // 
            // lblRightClick
            // 
            this.lblRightClick.AutoSize = true;
            this.lblRightClick.ContextMenuStrip = this.contextMenuStrip1;
            this.lblRightClick.Location = new System.Drawing.Point(40, 72);
            this.lblRightClick.Name = "lblRightClick";
            this.lblRightClick.Size = new System.Drawing.Size(78, 13);
            this.lblRightClick.TabIndex = 1;
            this.lblRightClick.Text = "Right click Me!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageBosToolStripMenuItem,
            this.xToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // messageBosToolStripMenuItem
            // 
            this.messageBosToolStripMenuItem.Name = "messageBosToolStripMenuItem";
            this.messageBosToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.messageBosToolStripMenuItem.Text = "MessageBox1";
            this.messageBosToolStripMenuItem.Click += new System.EventHandler(this.messageBosToolStripMenuItem_Click);
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.xToolStripMenuItem.Text = "MessageBox2";
            this.xToolStripMenuItem.Click += new System.EventHandler(this.xToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(43, 143);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblRightClick);
            this.Controls.Add(this.lblFormB);
            this.Name = "FormB";
            this.Text = "FormB";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormB;
        private System.Windows.Forms.Label lblRightClick;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem messageBosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
    }
}