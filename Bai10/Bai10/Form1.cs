using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics.Eventing.Reader;
namespace Bai10
{
    public partial class Form1 : Form
    {
        List<Point> arrowPoints = new List<Point>();
        Bitmap canvas;
        Graphics g;
        public Form1()
        {
            InitializeComponent();

            cboBoxDashStyle.DataSource = Enum.GetValues(typeof(DashStyle));
            cboBoxDashStyle.SelectedIndex = 0;

            for (int i = 1; i <= 15; i++)
            {
                cboBoxWidth.Items.Add(i.ToString());
            }
            cboBoxWidth.SelectedIndex = 4;

            cboBoxLine.DataSource = Enum.GetValues(typeof(LineJoin));
            cboBoxLine.SelectedIndex = 0;
            cboBoxDashCap.DataSource = Enum.GetValues(typeof(DashCap));
            cboBoxDashCap.SelectedIndex = 0;

            cboBoxEndCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboBoxStartCap.DataSource = Enum.GetValues(typeof(LineCap));
            cboBoxEndCap.SelectedIndex = 0;
            cboBoxStartCap.SelectedIndex = 0;
            canvas = new Bitmap(panelDrawing.Width, panelDrawing.Height);
            g = Graphics.FromImage(canvas);
            g.Clear(Color.White); // nền trắng

            panelDrawing.Paint += PaintAction;
        }

        private void PaintAction(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(canvas, 0, 0);
            if (arrowPoints.Count < 2) return;

            DashStyle dashStyle = (DashStyle)cboBoxDashStyle.SelectedItem;
            int Width = int.Parse(cboBoxWidth.SelectedItem.ToString());
            LineJoin lineJoin = (LineJoin)cboBoxLine.SelectedItem;
            DashCap dashCap = (DashCap)cboBoxDashCap.SelectedItem;
            LineCap startCap = (LineCap)cboBoxStartCap.SelectedItem;
            LineCap endCap = (LineCap)cboBoxEndCap.SelectedItem;

            using (Pen pen = new Pen(Color.Red, Width))
            {
                pen.DashStyle = dashStyle;
                pen.LineJoin = lineJoin;
                pen.DashCap = dashCap;
                pen.StartCap = startCap;
                pen.EndCap = endCap;

                GraphicsPath path = new GraphicsPath();
                path.AddLines(arrowPoints.ToArray());
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
        private void RePaint()
        {
            if (arrowPoints.Count < 2) return;

            DashStyle dashStyle = (DashStyle)cboBoxDashStyle.SelectedItem;
            int Width = int.Parse(cboBoxWidth.SelectedItem.ToString());
            LineJoin lineJoin = (LineJoin)cboBoxLine.SelectedItem;
            DashCap dashCap = (DashCap)cboBoxDashCap.SelectedItem;
            LineCap startCap = (LineCap)cboBoxStartCap.SelectedItem;
            LineCap endCap = (LineCap)cboBoxEndCap.SelectedItem;

            using (Pen pen = new Pen(Color.Red, Width))
            {
                pen.DashStyle = dashStyle;
                pen.LineJoin = lineJoin;
                pen.DashCap = dashCap;
                pen.StartCap = startCap;
                pen.EndCap = endCap;

                GraphicsPath path = new GraphicsPath();
                path.AddLines(arrowPoints.ToArray());
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.DrawPath(pen, path);
            }
        }
        private void MouseStartPaint(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                arrowPoints.Add(e.Location);
                panelDrawing.Invalidate();
            }
            else if (e.Button == MouseButtons.Right)
            {
                RePaint();
                arrowPoints.Clear();
            }
        }


        
    }
}




