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
        public Form1()
        {
            InitializeComponent();

        }



        private void PaintShape(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.DeepPink, 2);
            Brush brush = new SolidBrush(Color.Pink);
            int x = panelDrawing.ClientSize.Width / 2;
            int y = panelDrawing.ClientSize.Height / 2;
            int size = 100;
            if (shape == "Circle")
            {
                g.DrawEllipse(pen, x - size, y - size, size * 2, size * 2);
            }
            else if (shape == "Ellipse")
            {
                g.DrawEllipse(pen, x - (int)Math.Round(size * 1.5), y - size, size * 3, size * 2);
            }
            else if (shape == "Square")
            {
                g.DrawRectangle(pen, x - size, y - size, size * 2, size * 2);
            }
            else if (shape == "Pie")
            {
                g.DrawPie(pen, x - (int)Math.Round(size * 1.5), (int)Math.Round(y * 1.2) - size, size * 3, size * 3, 225, 90);
            }
            else if (shape == "Filled Square")
            {
                g.FillRectangle(brush, x - size, y - size, size * 2, size * 2);
            }
            else if (shape == "Filled Circle")
            {
                g.FillEllipse(brush, x - size, y - size, size * 2, size * 2);
            }
            else if (shape == "Filled Ellipse")
            {
                g.FillEllipse(brush, x - (int)Math.Round(size * 1.5), y - size, size * 3, size * 2);
            }
            else if (shape == "Filled Pie")
            {
                g.FillPie(brush, x - (int)Math.Round(size * 1.5), (int)Math.Round(y * 1.2) - size, size * 3, size * 3, 225, 90);
            }
           
               

        }

        private void ShapeChanged(object sender, EventArgs e)
        {
            shape = comboBoxTest.SelectedItem.ToString();
            panelDrawing.Invalidate();
        }
    }
}
