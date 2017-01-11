using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mini_Paint
{
    class DrawTransformation
    {
        mathMethod mm = new mathMethod();

        public void Dilatasi(Point p0,Point p1, Graphics g)
        {

        }
        
        public Point Translasi(Point p0, Point p1, Graphics g, int dX, int dY)
        {
            Point pEnd = p1;
            pEnd.X = pEnd.X + dX;
            pEnd.Y = pEnd.Y + dY;
            return pEnd;
        }

        public void Rotasi(Point p0, Point p1, Graphics g)
        {

        }

        public void Refleksi(Point p0, Point p1, Graphics g)
        {

        }
    }



}
