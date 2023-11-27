using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bezier
{
    public partial class Form1 : Form
    {
       
        Graphics g; 
        Pen pen = new Pen(Color.Black , 4);  
        int click = 0;
        Point[] points = new Point[4];

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();

        }




        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            switch (click)
            {
                case 0:
                    points[0] = new Point(e.X, e.Y);                 
                    click++;
                    break;
                case 1:
                    points[1] = new Point(e.X, e.Y);
                    g.DrawLine(pen, points[0], points[1]);     
                    click++;
                    break;
                case 2:
                    points[2] = new Point(e.X, e.Y);
                    g.DrawLine(pen, points[1], points[2]);
                    click++;
                    break;
                case 3:
                    points[3] = new Point(e.X, e.Y);
                    g.DrawLine(pen, points[2], points[3]);  
                    click = 0;
                    break;
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.DrawBezier(new Pen(Color.Red, 4), points[0], points[1], points[2], points[3]);
        }
    }
}


