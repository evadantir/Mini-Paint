using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mini_Paint
{
    class DrawNGon
    {
        mathMethod mm = new mathMethod();
        DrawLine dl = new DrawLine();

        public void DrawStar(Point p0, Point p1, Graphics g, int n)
        {
            Pen pen = new Pen(Color.Gold);
            double alpha = 2 * Math.PI / n;
            int r = mm.getR(p0, p1);

            Point startPoint = p0;
            Point endPoint = p1;

            for (int i = 0; i < n; i++)
            {
                startPoint.X = p0.X + (int)(r * Math.Cos(alpha * i+ Math.PI/4));
                startPoint.Y = p0.Y + (int)(r * Math.Sin(alpha * i + Math.PI / 4));

                endPoint.X = p0.X + (int)(r * Math.Cos(alpha * (i + 2) + Math.PI / 4));
                endPoint.Y = p0.Y + (int)(r * Math.Sin(alpha * (i + 2) + Math.PI / 4));
                g.DrawLine(pen,startPoint, endPoint);

            }

        }

        public void DrawPolygon(Point p0, Point p1, Graphics g, int n)
        {
            Pen pen = new Pen(Color.Green);
            double alpha = (2 * Math.PI / n);
            int r = mm.getR(p0, p1);

            Point startPoint = p0;
            Point endPoint = p1;

            for (int i = 0; i < n; i++)
            {
                startPoint.X = p0.X + (int)(r * Math.Cos(alpha * i + Math.PI / 4));
                startPoint.Y = p0.Y + (int)(r * Math.Sin(alpha * i + Math.PI / 4));

                endPoint.X = p0.X + (int)(r * Math.Cos(alpha * (i + 1) + Math.PI / 4));
                endPoint.Y = p0.Y + (int)(r * Math.Sin(alpha * (i + 1) + Math.PI / 4));

                g.DrawLine(pen, startPoint, endPoint);
            }
        }
    }
}
