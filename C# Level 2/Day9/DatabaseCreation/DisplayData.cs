using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseCreation
{
    public partial class DisplayData : Form
    {
        public DisplayData()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zooDataSet3.ZooPatron' table. You can move, or remove it, as needed.
            this.zooPatronTableAdapter.Fill(this.zooDataSet3.ZooPatron);
            // TODO: This line of code loads data into the 'zooDataSet2.AnimalType' table. You can move, or remove it, as needed.
            this.animalTypeTableAdapter.Fill(this.zooDataSet2.AnimalType);
            // TODO: This line of code loads data into the 'zooDataSet11.Animal' table. You can move, or remove it, as needed.
            this.animalTableAdapter.Fill(this.zooDataSet11.Animal);

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertAnimalType insertForm = new InsertAnimalType();
            insertForm.Show();
        }
    }
}
