using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AddControl
{
    public partial class ucAddControl : UserControl
    {
        public ucAddControl()
        {
            InitializeComponent();
        }

        public int AddInfo
        {
            get
            {
                return Int32.Parse(txtData1.Text) + Int32.Parse(txtData2.Text);
            }
        }
    }
}
