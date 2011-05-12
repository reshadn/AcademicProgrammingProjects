using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseMyContactDLL
{
    public partial class UseMyContact : Form
    {
        public UseMyContact()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Contact.MyContact firstObject = new Contact.MyContact();
            Contact.MyContact secondObject = new Contact.MyContact("Bill Gates", "(123)456-7890", "1235");

            lblResult1.Text = firstObject.ToString();
            lblResult2.Text = secondObject.ToString();
        }
    }
}
