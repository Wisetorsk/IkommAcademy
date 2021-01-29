using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibbonacci
{
    public partial class Form1 : Form
    {
        static int centerX, centerY, startY, startX, endY, endX;
        static int numberOfFib = 5;
        Pen myPen = new Pen(Color.Black);
        Graphics g = null;

        private void button1_Click(object sender, EventArgs e)
        {
            startX = 0;
            startY = panel1.Height / 2;
            numberOfFib = int.Parse(fibLengthInput.Text);
            panel1.Refresh();
        }

        public Form1()
        {
            InitializeComponent();
            startX = 0;
            startY = panel1.Height / 2;
        }

        public int Fib(int first = 1, int second = 1)
        {
            int output = first + second;
            return output;
        }

        public int[] Sequence(int length)
        {
            int[] output = new int[length];
            output[0] = 1;
            output[1] = 1;
            for (int i = 2; i < length; i++)
            {
                output[i] = Fib(output[i - 2], output[i - 1]);
            }
            return output;
        }

        public void DrawArc(int fibb, int dir)
        {
            g.DrawArc(myPen, startX, startY-fibb/2, fibb, fibb, 0, dir*180);
            startX += fibb;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var seq = Sequence(numberOfFib);
            g = panel1.CreateGraphics();
            for (int i = 0; i < numberOfFib; i++)
            {
                DrawArc(seq[i], i%2==0?1:-1);
            }
        }
    }
}
