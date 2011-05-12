using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingWindowsControls
{
    public partial class Display : Form
    {
        string outputText = DateTime.Now.ToString("d");

        public Display()
        {
            InitializeComponent();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = outputText;
        }

        private void dateRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("d");
        }

        private void timeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            outputText = DateTime.Now.ToString("t");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            dateRadioButton.Select();
        }
    }
}
