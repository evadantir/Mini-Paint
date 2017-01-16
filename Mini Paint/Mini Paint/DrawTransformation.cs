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

        public twoPoint Dilatasi(Point p0, Point p1, int kX, int kY)
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
            pTrans.y1 = p1.Y + dY;
            return pTrans;
        }

        public twoPoint Rotasi(Point p0, Point p1, double sudut)
        {
            //code by Tria Yuda P
            twoPoint pTrans = new twoPoint();
            pTrans.x0 = Convert.ToInt32((p0.X * (Math.Cos(sudut / 360 * 2 * Math.PI))) - (p0.Y * (Math.Sin(sudut / 360 * 2 * Math.PI))));
            pTrans.y0 = Convert.ToInt32((p0.X * (Math.Sin(sudut / 360 * 2 * Math.PI))) + (p0.Y * (Math.Cos(sudut / 360 * 2 * Math.PI))));
            pTrans.x1 = Convert.ToInt32((p1.X * (Math.Cos(sudut / 360 * 2 * Math.PI))) - (p1.Y * (Math.Sin(sudut / 360 * 2 * Math.PI))));
            pTrans.y1 = Convert.ToInt32((p1.X * (Math.Sin(sudut / 360 * 2 * Math.PI))) + (p1.Y * (Math.Cos(sudut / 360 * 2 * Math.PI))));
            return pTrans;
        }

        public twoPoint Refleksi(Point p0, Point p1, int sumbu,double k1, double k2)
        {
            twoPoint pTrans = new twoPoint();

            if (sumbu == 0)
            {
                pTrans.x0 = p0.X;
                pTrans.x1 = p1.X;
                pTrans.y0 = Convert.ToInt32(p0.Y + (2 * k1));
                pTrans.y1 = Convert.ToInt32(p1.Y + (2 * k2));
            }
            else
            {
                pTrans.x0 = Convert.ToInt32(p0.X + (2 * k1));
                pTrans.x1 = Convert.ToInt32(p1.X + (2 * k2));
                pTrans.y0 = p0.Y;
                pTrans.y1 = p1.Y;

            }
            return pTrans;
        }
    }



}
