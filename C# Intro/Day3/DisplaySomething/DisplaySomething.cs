using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisplaySomething
{
    public partial class DisplaySomething : Form
    {
        int aNumber = 23; //a field

        public DisplaySomething()
        {
            InitializeComponent();
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("More");
        }

        private void stuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stuff");
        }

        private void moreStuffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("More Stuff");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Run Button");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObject_Click(object sender, EventArgs e)
        {
            MessageBox.Show(1.ToString());
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string s = @"c:tcsharp\ndata.com"; 
            MessageBox.Show (s);
        }
    }
}
