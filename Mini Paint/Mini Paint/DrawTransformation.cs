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

        public twoPoint Dilatasi(Point p0,Point p1, int kX, int kY)
        {
            twoPoint pTrans = new twoPoint();
            pTrans.x0 = p0.X * kX;
            pTrans.y0 = p0.Y * kY;
            pTrans.x1 = p1.X * kX;
            pTrans.y1 = p1.Y * kY;
            return pTrans;
        }
        
        public twoPoint Translasi(Point p0, Point p1, int dX, int dY)
        {
            twoPoint pTrans = new twoPoint();
            pTrans.x0 = p0.X + dX;
            pTrans.y0 = p0.Y + dY;
            pTrans.x1 = p1.X + dX;
            pTrans.y1= p1.Y + dY;
            return pTrans;
        }

        public twoPoint Rotasi(Point p0, Point p1, Graphics g)
        {
            
        }

        public twoPoint Refleksi(Point p0, Point p1, Graphics g)
        {

        }
    }



}
