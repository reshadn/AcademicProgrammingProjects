using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingDialogForms
{
    public partial class InputData : Form
    {
        public string InputDataValue
        {
            get { return inputTextBox.Text; }
            set { inputTextBox.Text = value; }
        }

        public InputData()
        {
            InitializeComponent();
        }
    }
}
