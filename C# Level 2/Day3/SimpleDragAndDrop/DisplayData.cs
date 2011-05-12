using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleDragAndDrop
{
    public partial class DisplayData : Form
    {
        public DisplayData()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sourceDataTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            sourceDataTextBox.DoDragDrop(sourceDataTextBox.Text,
                DragDropEffects.Copy);
        }

        private void dropHereTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dropHereTextBox_DragDrop(object sender, DragEventArgs e)
        {
            dropHereTextBox.Text = e.Data.GetData(DataFormats.Text).ToString();
        }
    }
}
