using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = 30; //scale
            int xc = pictureBox1.Width / 2;   // center coordinates
            int yc = pictureBox1.Height / 2;
            int xe, ye;     // point "screen" coordinates
            double x, y;   // point "math" coordinates
            double step = 0.005;    // step
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Silver);
            G.DrawLine(myPen, 10, yc, 2 * xc - 10, yc);   // axes
            G.DrawLine(myPen, xc, 10, xc, 2 * yc - 10);
            myPen = new Pen(Color.Black);
            x = -Math.PI;
            // function graph design loop
            while (x < Math.PI)
            {
                try   // if the function does not exist at any point 
                {
                    y = 1/Math.Sin(x);   // Function formula!!!
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(myPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double m = 30; //scale
            int xc = pictureBox1.Width / 2;   // center coordinates
            int yc = pictureBox1.Height / 2;
            int xe, ye;     // point "screen" coordinates
            double x, y;   // point "math" coordinates
            double step = 0.005;    // step
            Graphics G = pictureBox1.CreateGraphics();
            G.Clear(System.Drawing.Color.White);
            Pen myPen = new Pen(Color.Silver);
            G.DrawLine(myPen, 10, yc, 2 * xc - 10, yc);   // axes
            G.DrawLine(myPen, xc, 10, xc, 2 * yc - 10);
            myPen = new Pen(Color.Black);
            x = -Math.PI;
            // function graph design loop
            while (x < Math.PI)
            {
                try   // if the function does not exist at any point 
                {
                    y = x * x; // Function formula!!!
                    xe = (int)(xc + m * x);
                    ye = (int)(yc - m * y);
                    G.DrawEllipse(myPen, xe, ye, 1, 1);
                }
                catch { }
                x += step;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);

            Pen pen = new Pen(Color.Blue, 2);

            int startX = 50;
            int startY = 50;
            int size = 300;
            int steps = 10;
            int gap = 15;

            for (int i = 0; i < steps; i++)
            {
                // 4 sides: top, right, bottom, left
                g.DrawLine(pen, startX, startY, startX + size, startY);                   // top
                g.DrawLine(pen, startX + size, startY, startX + size, startY + size);    // right
                g.DrawLine(pen, startX + size, startY + size, startX, startY + size);    // bottom
                g.DrawLine(pen, startX, startY + size, startX, startY);                  // left

                // shrink inward
                startX += gap;
                startY += gap;
                size -= 2 * gap;
            }
        }


    }
}
