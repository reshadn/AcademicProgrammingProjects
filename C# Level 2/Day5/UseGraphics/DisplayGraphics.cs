using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseGraphics
{
    public partial class DisplayGraphics : Form
    {
        Random generateRandom;

        public DisplayGraphics()
        {
            InitializeComponent();
        }

        private void DisplayGraphics_Load_1(object sender, EventArgs e)
        {
            //what is purpose of this event?
            DateTime dtmCurrent = DateTime.Now;
            generateRandom = new Random(dtmCurrent.Millisecond); //random number generator 
        }

        private void DisplayGraphics_Paint(object sender,
            System.Windows.Forms.PaintEventArgs e)
        {
            int intX = (int)this.Width / 2;
            int intY = (int)this.Height / 2;
            int intIndex;

            Graphics gr = e.Graphics;
            Pen whitePen = new Pen(Color.White, 2);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Pen blackPen = new Pen(Color.Black);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            e.Graphics.DrawString("Happy Holidays", new
            Font("Arial", 40, FontStyle.Italic),
            Brushes.Red, 70, 10);

            intY += 40;

            gr.FillEllipse(whiteBrush, intX, intY, 100, 100);

            intY -= 80;
            intX += 10;
            gr.FillEllipse(whiteBrush, intX, intY, 80, 80);
            intY -= 60;
            intX += 8;
            gr.FillEllipse(whiteBrush, intX, intY, 60, 60);

            gr.FillEllipse(blackBrush, intX + 15, intY + 18, 8, 8);
            gr.FillEllipse(blackBrush, intX + 35, intY + 18, 8, 8);
            gr.FillEllipse(blackBrush, intX + 25, intY + 30, 8, 8);
            gr.FillRectangle(blackBrush, intX + 20, intY + 45, 20, 2);

            gr.FillEllipse(blackBrush, intX + 27, intY + 75, 8, 8);
            gr.FillEllipse(blackBrush, intX + 27, intY + 95, 8, 8);
            gr.FillEllipse(blackBrush, intX + 27, intY + 115, 8, 8);

            gr.DrawLine(blackPen, intX - 10, intY, intX - 80, intY);
            gr.FillRectangle(blackBrush, intX + 10, intY - 40, 40, 40);

            intY -= 40;
            for (intIndex = 1; intIndex < 40000; intIndex++)
            {
                intX = generateRandom.Next(1, this.Width);
                intY = generateRandom.Next(1, this.Height);
                gr.DrawLine(whitePen, intX, intY, intX + 1, intY + 1);
            }
        }

    }
}
