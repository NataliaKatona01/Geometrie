using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triunghi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private Point Middle(Point x, Point y)
        {
            Point mid = new Point();
            mid.X = (x.X + y.X) / 2;
            mid.Y = (x.Y + y.Y) / 2;
            return mid;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics grp = Graphics.FromImage(bmp);

            grp.Clear(Color.White);

            Point[] points = new Point[3];

            points[0].X = int.Parse(textBox1.Text);
            points[0].Y = int.Parse(textBox2.Text);
            points[1].X = int.Parse(textBox3.Text);
            points[1].Y = int.Parse(textBox4.Text);
            points[2].X = int.Parse(textBox5.Text);
            points[2].Y = int.Parse(textBox6.Text);

            grp.DrawPolygon(Pens.Black, points);

            grp.DrawLine(Pens.Black, Middle(points[0], points[1]), points[2]);
            grp.DrawLine(Pens.Black, Middle(points[1], points[2]), points[0]);
            grp.DrawLine(Pens.Black, Middle(points[0], points[2]), points[1]);

            pictureBox1.Image = bmp;
        }
    }
}
