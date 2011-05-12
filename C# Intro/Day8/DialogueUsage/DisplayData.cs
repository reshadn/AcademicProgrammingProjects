using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            label1.ForeColor = colorDialog1.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            dataTextBox.Font = fontDialog1.Font;
            label1.Font = fontDialog1.Font;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();                   // reading text files
            string fileData = openFileDialog1.FileName;
            StreamReader sr = new StreamReader(fileData);  
            dataTextBox.Text = sr.ReadToEnd();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
