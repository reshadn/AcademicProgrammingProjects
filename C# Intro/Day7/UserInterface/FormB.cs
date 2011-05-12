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
    public partial class FormB : Form
    {
        public FormB()
        {
            InitializeComponent();
        }

        private void messageBosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox1 was selected.");
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MessageBox2 was selected.");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
