using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Process1
{
    public partial class MainDisplay : Form
    {
        public MainDisplay()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message run...");
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            MyForm aForm = new MyForm();
            aForm.ShowDialog();
            //MyForm bForm = new MyForm();
            //bForm.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForm cForm = new MyForm();
            cForm.ShowDialog();
        }
    }
}
