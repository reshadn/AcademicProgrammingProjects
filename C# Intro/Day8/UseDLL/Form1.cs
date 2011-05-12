using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MyLib;

namespace UseDLL
{
    public partial class useDll : Form
    {
        public useDll()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MyLib.Util myUtility = new MyLib.Util();  //instance
            //MessageBox.Show(myUtility.Method2());

            Util aVarName = new Util();             // instance with using MyLib
            MessageBox.Show(aVarName.Method2());

            //string returnData = MyLib.Util.Method1();   //static
            //MessageBox.Show(returnData);

            MessageBox.Show(Util.Method1());        // static with using MyLib

            
        }
    }
}
