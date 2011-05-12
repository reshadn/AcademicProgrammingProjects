using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIExercise
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void toggleColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toggleColorToolStripMenuItem.Checked)
            {
                toggleColorToolStripMenuItem.Checked = false;
                richTextBox1.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                toggleColorToolStripMenuItem.Checked = true;
                richTextBox1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
