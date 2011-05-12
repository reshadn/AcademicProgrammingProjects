using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Homework1
{
    public partial class ContactInfo : Form
    {
        public ContactInfo()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            labelResult.Text = " Name: " + textBoxName.Text + "  Organization: " 
                + textBoxOrg.Text + "  Phone: " + textBoxPhone.Text;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
