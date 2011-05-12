using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void formAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormA aformA = new FormA();
            aformA.Show();
        }

        private void formBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormB aformB = new FormB();
            aformB.ShowDialog();
        }

        private void messageBoxShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message box.");
        }
    }
}
