using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EventHandlingExercise1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void csharpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Correct", "Answer", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
        }

        private void vbButton_MouseMove(object sender, MouseEventArgs e)
        {
            vbButton.Top -= e.Y;
            vbButton.Left += e.X;

            if (vbButton.Top < -16 || vbButton.Top > 160)
                vbButton.Top = 73;
            if (vbButton.Left < -64 || vbButton.Left > 384)
                vbButton.Left = 160;
        }
    }
}
