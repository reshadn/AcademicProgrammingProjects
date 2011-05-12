using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumerationsCreditCardType
{
    public enum Day
    {
        Visa,
        MasterCard,
        Discover,
        AmEx
    }

    public partial class CreditCardType : Form
    {
        public CreditCardType()
        {
            InitializeComponent();
        }

        private void CreditCardType_Load(object sender, EventArgs e)
        {
            comboBoxCreditCard.Items.Add(Day.Visa);
            comboBoxCreditCard.Items.Add(Day.MasterCard);
            comboBoxCreditCard.Items.Add(Day.AmEx);
            comboBoxCreditCard.Items.Add(Day.Discover);

            comboBoxCreditCard.SelectedIndex = 0;
        }

        private void comboBoxCreditCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCreditCard.Text = 
                Convert.ToString(comboBoxCreditCard.SelectedItem);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
