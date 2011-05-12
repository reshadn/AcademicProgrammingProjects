using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void Garbage(object sender, EventArgs e)
        {
            MessageBox.Show("Garbage!");
        }
    }
}
