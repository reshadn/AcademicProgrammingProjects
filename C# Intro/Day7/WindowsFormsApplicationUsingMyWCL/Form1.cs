using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyWCL;

namespace WindowsFormsApplicationUsingMyWCL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyWCL.MyGreatClass aObject = new MyWCL.MyGreatClass();
            MessageBox.Show(aObject.AMethod().ToString());
        }
    }
}
