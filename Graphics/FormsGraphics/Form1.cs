using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsGraphics
{
    public partial class Form1 : Form
    {

        Pen myPen = new Pen(Color.Black);
        Graphics g = null;

        static int centerX, centerY;
        static int startX, startY;
        static int endX, endY;

        static int myAngle = 0;
        static double myLength = 0;
        static int myNumberOfLines = 0;
        static double myIncrement = 0;
        static int startAngle = 0;


        public Form1()
        {
            InitializeComponent();
            startX = Canvas.Width / 2;
            startY = Canvas.Height / 2;
            //g = this.CreateGraphics();
        }

        private void go_button_Click(object sender, EventArgs e)
        {
            myLength = int.Parse(length.Text);
            myAngle = int.Parse(angle.Text);
            myNumberOfLines = int.Parse(line_number.Text);
            myIncrement = double.Parse(increment.Text);

            startX = Canvas.Width / 2;
            startY = Canvas.Height / 2;

            Canvas.Refresh(); //Wipe it

        }

        private void DrawLine()//PaintEventArgs e)
        {
            myAngle += int.Parse(angle.Text);
            myLength += double.Parse(increment.Text);

            endX = Convert.ToInt32(startX + Math.Cos(myAngle * .017453292519) * myLength);
            endY = Convert.ToInt32(startY + Math.Sin(myAngle * .017453292519) * myLength);
            Point[] points = new Point[] {
                new Point(startX, startY),
                new Point(endX, endY)
            };
            startX = endX;
            startY = endY;
            g.DrawLines(myPen, points);

        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            //DrawLine(e);
            g = Canvas.CreateGraphics();
            for (int i = 0; i < myNumberOfLines; i++)
            {
                DrawLine();
            }
        }
    }
}
