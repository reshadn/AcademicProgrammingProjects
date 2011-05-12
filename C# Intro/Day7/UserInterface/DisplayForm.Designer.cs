namespace UserInterface
{
    partial class DisplayForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageBoxShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.processToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAFormToolStripMenuItem,
            this.messageBoxShowToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // openAFormToolStripMenuItem
            // 
            this.openAFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formAToolStripMenuItem,
            this.formBToolStripMenuItem});
            this.openAFormToolStripMenuItem.Name = "openAFormToolStripMenuItem";
            this.openAFormToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.openAFormToolStripMenuItem.Text = "&Open a Form";
            // 
            // formAToolStripMenuItem
            // 
            this.formAToolStripMenuItem.Name = "formAToolStripMenuItem";
            this.formAToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formAToolStripMenuItem.Text = "Form &A";
            this.formAToolStripMenuItem.Click += new System.EventHandler(this.formAToolStripMenuItem_Click);
            // 
            // formBToolStripMenuItem
            // 
            this.formBToolStripMenuItem.Name = "formBToolStripMenuItem";
            this.formBToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.formBToolStripMenuItem.Text = "Form &B";
            this.formBToolStripMenuItem.Click += new System.EventHandler(this.formBToolStripMenuItem_Click);
            // 
            // messageBoxShowToolStripMenuItem
            // 
            this.messageBoxShowToolStripMenuItem.Name = "messageBoxShowToolStripMenuItem";
            this.messageBoxShowToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.messageBoxShowToolStripMenuItem.Text = "MessageBoxShow";
            this.messageBoxShowToolStripMenuItem.Click += new System.EventHandler(this.messageBoxShowToolStripMenuItem_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DisplayForm";
            this.Text = "User Interface";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageBoxShowToolStripMenuItem;
    }
}

