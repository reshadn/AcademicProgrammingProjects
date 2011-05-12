using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DialogueUsage
{
    public partial class DisplayData : Form
    {
        public DisplayData()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            dataTextBox.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            dataTextBox.Font = fontDialog1.Font;
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string fileData = openFileDialog1.FileName;
            StreamReader sr = new StreamReader(fileData);
            dataTextBox.Text = sr.ReadToEnd();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataTextBox.ResetText();
        }
    }
}
