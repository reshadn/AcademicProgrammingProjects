using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WarmupDelegateProblem
{
    public partial class UseDelegate : Form
    {
        internal FormatNumbers.FormatSingle formatText;

        public UseDelegate()
        {
            InitializeComponent();
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = formatText(Convert.ToSingle(inputTextBox.Text));
        }

        private void percentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.percentRadioButton.Checked)
            {
                formatText = new FormatNumbers.FormatSingle(FormatNumbers.returnPercentage);
            }
        }

        private void dollarRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dollarRadioButton.Checked)
            {
                formatText = new FormatNumbers.FormatSingle(FormatNumbers.returnDollars);
            }
        }

        private void UseDelegate_Load(object sender, EventArgs e)
        {
            percentRadioButton.Select();
            formatText = new FormatNumbers.FormatSingle(FormatNumbers.returnPercentage);
        }
    }
}
