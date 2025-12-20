using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net;
using System.Diagnostics;

namespace Bai11
{
    public partial class Form1 : Form
    {
        Color color;
        string Shape;
        Bitmap ee;
        Point startPoint = Point.Empty;
        Point endPoint = Point.Empty;
        int width;
        bool isDrawing = false;
        Brush brush;
        Image img;

        public Form1()
        {
            InitializeComponent();
            txtWidth.Text = "1";
            radioButtonLine.Checked = true;
            radioButtonSolidBrush.Checked = true;
            this.DoubleBuffered = true;
            color = Color.Black;
            ee = new Bitmap(panelDrawing.Width, panelDrawing.Height);
            img = Image.FromFile("textture.jpeg");

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) 
            { 
                color = dlg.Color;
            }
        }

        private void CheckWidth(object sender, EventArgs e)
        {
            if (txtWidth.Text == "")
            {
                width = 0;
                return;
            }
            if (!int.TryParse(txtWidth.Text, out int w) || w <=0)
            {
             
                MessageBox.Show("Chỉ được nhập số >0");
            }
            else
                width = int.Parse(txtWidth.Text);
        }

        private void ShapesChanged(object sender, EventArgs e)
        {
            if (radioButtonLine.Checked)
            {
                Shape = "Line";
            }
            else if (radioButtonRectangle.Checked)
            {
                Shape = "Rec";
            }
            else
            {
                Shape = "Ellipse";
            }    
        }

        private void DrawShape(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ee, new Point(0, 0));
            Graphics g = e.Graphics;
            Pen pen = new Pen(color,width);
            if (isDrawing)
            {
                if (Shape == "Line")
                {
                    g.DrawLine(pen, startPoint, endPoint);
                }
                else if (Shape =="Rec")
                {

                    g.FillRectangle(brush, GetRectangle(startPoint,endPoint));
                }
                else
                {
                    g.FillEllipse(brush,GetRectangle(startPoint,endPoint));
                }    
            }
            
        }
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }
        private void PrintShapeOnPanel()
        {
            using (Graphics g = Graphics.FromImage(ee))
            {
                Pen pen = new Pen(color, width);
                if (Shape == "Line")
                {
                    g.DrawLine(pen, startPoint, endPoint);
                }
                else if (Shape == "Rec")
                {

                    g.FillRectangle(brush, GetRectangle(startPoint, endPoint));
                }
                else
                {
                    g.FillEllipse(brush, GetRectangle(startPoint, endPoint));
                }
            }
            panelDrawing.Invalidate();
        }

        private void StartDrawing(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void Drawing(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                panelDrawing.Refresh();
            }
        }

        private void EndDrawing(object sender, MouseEventArgs e)
        {
            endPoint = e.Location;
            PrintShapeOnPanel();
            isDrawing = false;
        }

        private void BrushesChanged(object sender, EventArgs e)
        {
            if (radioButtonSolidBrush.Checked)
            {
                brush = new SolidBrush(Color.Green);
            }
            else if (radioButtonHatchBrush.Checked)
            {
                brush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
            }
            else if (radioButtonTextureBrush.Checked)
            {
                brush = new TextureBrush(img);
                
            }
            else if (radioButtonLGB.Checked)
            {
                brush = new LinearGradientBrush(
                GetRectangle(startPoint, endPoint),
                Color.Red,
                Color.Green,
                LinearGradientMode.Vertical);
            } 
               
        }

        private void ChangeSize(object sender, EventArgs e)
        {
            ee = new Bitmap(panelDrawing.Width, panelDrawing.Height);
        }
    }
    

}
