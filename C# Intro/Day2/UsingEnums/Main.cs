using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UsingEnums
{
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dayComboBox.Items.Add(Day.Monday);
            dayComboBox.Items.Add(Day.Tuesday); 
            dayComboBox.Items.Add(Day.Wednesday);
            dayComboBox.Items.Add(Day.Thursday);
            dayComboBox.Items.Add(Day.Friday);
            dayComboBox.Items.Add(Day.Saturday);
            dayComboBox.Items.Add(Day.Sunday);

            dayComboBox.SelectedIndex = 0;
        }

        private void dayComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultLabel.Text =
                Convert.ToString(dayComboBox.SelectedItem);
        }


    }
}
