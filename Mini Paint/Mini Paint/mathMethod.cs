using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Mini_Paint
{
    public class mathMethod
    {

        public double getStep(Point p0,Point p1)
        {
            double dX = getDeltaX(p0,p1);
            double dY = getDeltaY(p0,p1);
            double step = Math.Abs(dX) > Math.Abs(dY) ? Math.Abs(dX) : Math.Abs(dY);

            return step;
        }

        public double getDeltaX(Point p0,Point p1)
        {
            return p1.X - p0.X;
        }

        public double getDeltaY(Point p0, Point p1)
        {
            return p1.Y - p0.Y;
        }

        public double getGradien(Point p0,Point p1)
        {
            return (p1.Y - p0.Y)/(p1.X - p1.Y);
        }

        public double getC(Point p0, double m)
        {
            return p0.Y - m * p0.X;
        }

        public int getR(Point p0,Point p1)
        {
            //r = sqrt(a^2+b^2)
            return (int)Math.Sqrt(Math.Pow(p1.X - p0.X, 2) + Math.Pow(p1.Y - p0.Y, 2));
        }
    }
}
