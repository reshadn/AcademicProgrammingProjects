using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingDialogForms
{
    class Program
    {
        static void Main(string[] args)
        {
            InputData enterData = new InputData();
            DialogResult aResult;
            string aMessage;

            do
            {
                aResult = enterData.ShowDialog();
                if (aResult == DialogResult.OK)
                {
                    aMessage = "The name is " +
                        enterData.InputDataValue;
                    MessageBox.Show(aMessage, "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aResult = MessageBox.Show("Do Another?", "Continue?",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            } while (aResult == DialogResult.Yes);
        }
    }
}
