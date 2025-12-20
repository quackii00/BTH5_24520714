using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class MainForm : Form
    {
        Bitmap Clock;
        Bitmap MinHand;
        Timer sec;
        Timer min;
        public MainForm()
        {
            InitializeComponent();
            sec = new Timer();

            sec.Tick += sec_Tick;

        }
        private void sec_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        public void DrawSecHand(Graphics e, Point x, Point y)
        {
            Graphics g = e;
            Pen pen = new Pen(Color.White,1);
            g.DrawLine(pen, x, y);

        }
        public void DrawMinHand(Graphics g, Point center, int radius)
        {
            int minute = DateTime.Now.Minute;
            double angle = 2 * Math.PI * minute / 60 - Math.PI / 2;

            int x = center.X + (int)(radius * Math.Cos(angle));
            int y = center.Y + (int)(radius * Math.Sin(angle));
            Point D = new Point(x, y);
            Point D1 = new Point(
            center.X - (int)((D.X - center.X) / 4.0),
            center.Y - (int)((D.Y - center.Y) / 4.0)
            );

            int vx = D.X - center.X;
            int vy = D.Y - center.Y;

            int vpx = -vy;
            int vpy = vx;

            double k = 0.1;

            Point D2 = new Point(center.X + (int)(k * vpx),
                                 center.Y + (int)(k * vpy));

            Point D3 = new Point(center.X - (int)(k * vpx),
                                 center.Y - (int)(k * vpy));
            using (Pen pen = new Pen(Color.White, 1))
            {
                g.DrawPolygon(pen, new Point[] {D,D2,D1,D3 });
            }
        }
        public void DrawHourHand(Graphics g, Point center, int radius )
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

            double angle = 2 * Math.PI * (hour % 12 + minute / 60.0) / 12 - Math.PI / 2;

            int x = center.X + (int)(radius * Math.Cos(angle));
            int y = center.Y + (int)(radius * Math.Sin(angle));
            Point D = new Point(x, y);
            Point D1 = new Point(
            center.X - (int)((D.X - center.X) / 4.0),
            center.Y - (int)((D.Y - center.Y) / 4.0)
            );

            int vx = D.X - center.X;
            int vy = D.Y - center.Y;

            int vpx = -vy;
            int vpy = vx;

            double k = 0.18;

            Point D2 = new Point(center.X + (int)(k * vpx),
                                 center.Y + (int)(k * vpy));

            Point D3 = new Point(center.X - (int)(k * vpx),
                                 center.Y - (int)(k * vpy));
            using (Pen pen = new Pen(Color.White, 1))
            {
                g.DrawPolygon(pen, new Point[] { D, D2, D1, D3 });
            }
        }
        


        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = this.ClientSize.Width / 2;
            int y = this.ClientSize.Height / 2;
            int r = (x > y ? y : x) - 40;
            int sec = DateTime.Now.Second;
            double anglesec = 2 * Math.PI * sec / 60 - Math.PI / 2;
            int xx = x + (int)(r * Math.Cos(anglesec));
            int yy = y + (int)(r * Math.Sin(anglesec));
            if (Clock != null)
            {
                e.Graphics.DrawImage(Clock, 0, 0);
            }
            DrawSecHand(g, new Point(x, y), new Point(xx-5, yy-5));
            DrawMinHand(g, new Point(x, y), r);
            DrawHourHand(g, new Point(x, y), r-25);

        }

        public void DrawClock()
        {
            Clock?.Dispose();
            Clock = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            int x = (this.ClientSize.Width / 2);
            int y = (this.ClientSize.Height / 2);
            int r = (x > y ? y : x) - 20;

            using (Graphics g = Graphics.FromImage(Clock))
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Black);
                Brush brush = new SolidBrush(Color.White);
                for (int i = 1; i <= 12; i++)
                {
                    int xx = x + (int)(r * Math.Cos(2 * Math.PI * i / 12));
                    int yy = y + (int)(r * Math.Sin(2 * Math.PI * i / 12));
                    g.FillEllipse(brush, xx - 15, yy - 15, 20, 20);
                }
                for (int i = 1; i <= 60; i++)
                {
                    int xx = x + (int)(r * Math.Cos(2 * Math.PI * i / 60));
                    int yy = y + (int)(r * Math.Sin(2 * Math.PI * i / 60));
                    g.FillEllipse(brush, xx - 8, yy - 8, 6, 6);
                }

            }
        }
       

        private void RePaint(object sender, EventArgs e)
        {
            DrawClock();
            this.Invalidate();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            DrawClock();

            sec.Interval = 1000;
            sec.Start();

        }
    }
}
