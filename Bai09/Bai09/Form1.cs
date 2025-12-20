using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        string shape;
        Point startPoint;
        Point endPoint;
        bool isDrawing = false;
        
        public Form1()
        {
            InitializeComponent();
        }


        private void PaintShape(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.DeepPink, 2);
            Brush brush = new SolidBrush(Color.Pink);

            if (shape == "Circle")
            {
                g.DrawEllipse(pen, GetSquare(startPoint,endPoint));
            }
            else if (shape == "Ellipse")
            {
                g.DrawEllipse(pen, GetRectangle(startPoint, endPoint));
            }
            else if (shape == "Square")
            {
                g.DrawRectangle(pen, GetRectangle(startPoint, endPoint));
            }
            else if (shape == "Pie")
            {
                Rectangle rect = GetSquare(startPoint, endPoint);
                if (rect.Width > 0 && rect.Height > 0)
                {
                    g.DrawPie(pen, rect, 225, 90);
                }
            }
            else if (shape == "Filled Square")
            {
                g.FillRectangle(brush, GetSquare(startPoint, endPoint));
            }
            else if (shape == "Filled Circle")
            {
                g.FillEllipse(brush, GetSquare(startPoint, endPoint));
            }
            else if (shape == "Filled Ellipse")
            {
                g.FillEllipse(brush, GetRectangle(startPoint, endPoint));
            }
            else if (shape == "Filled Pie")
            {
                Rectangle rect = GetSquare(startPoint, endPoint);
                if (rect.Width > 0 && rect.Height > 0)
                {
                    g.FillPie(brush, rect, 225, 90);
                }
            }
           
        }

        private Rectangle GetRectangle(Point x, Point y)
        {
            Rectangle r = new Rectangle();
            r.X = Math.Min(x.X, y.X);
            r.Y = Math.Min(x.Y, y.Y);
            r.Width = Math.Abs(x.X - y.X);
            r.Height = Math.Abs(x.Y - y.Y);
            return r;
        }
        private Rectangle GetSquare(Point x, Point y)
        {
            Rectangle r = new Rectangle();
            r.X = Math.Min(x.X, y.X);
            r.Y = Math.Min(x.Y, y.Y);
            r.Width = Math.Max(Math.Abs(x.X - y.X), Math.Abs(x.Y - y.Y));
            r.Height = r.Width;
            return r;
        }

        private void ShapeChanged(object sender, EventArgs e)
        {
            shape = comboBoxTest.SelectedItem.ToString();
        }

        private void StartDrawing(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            isDrawing = true;
        }

        private void EndDrawing(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            isDrawing = false;
            DrawPlace.Invalidate();
        }

        private void Drawing(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                DrawPlace.Invalidate();
            }
        }
    }
}
