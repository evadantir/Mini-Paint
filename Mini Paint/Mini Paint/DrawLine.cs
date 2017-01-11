using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mini_Paint
{
    class DrawLine
    {
        mathMethod mm = new mathMethod();
        public void DrawDDA(Point p0, Point p1,Pen pen,Graphics g)
        {
            pen = new Pen(Color.Brown);
            double x = p0.X;
            double y = p0.Y;
            Point startPoint = p0;
            Point endPoint = Point.Empty;

            double step = mm.getStep(p0, p1);
            double xInt = mm.getDeltaX(p0, p1) / step;
            double yInt = mm.getDeltaY(p0, p1) / step;

            while (step > 0)
            {
                //tambahkan koordinat X dan Y dengan intervalnya
                x += xInt;
                y += yInt;
                endPoint.X = (int)Math.Round(x, MidpointRounding.AwayFromZero);
                endPoint.Y = (int)Math.Round(y, MidpointRounding.AwayFromZero);

                //gambar garis
                g.DrawLine(pen, startPoint, endPoint);
                step--;
                startPoint = endPoint;
            }

        }

        public void DrawNaive(Point p0, Point p1, Pen pen, Graphics g)
        {
            //credit: Andre
            pen = new Pen(Color.DarkCyan);

            double x = p0.X;
            double y = p0.Y;
            Point startPoint = p0;
            Point endPoint = p1;

            double xInt = mm.getDeltaX(p0, p1);
            double yInt = mm.getDeltaY(p0, p1);
            double gradien = mm.getGradien(p0, p1);
            double c = mm.getC(p0, gradien);

            if (gradien == 0)//tidak ada kemiringan (tegak lurus/sejajar)
            {
                int X = Math.Min(p0.X, p1.X);
                for(int i=0;i<Math.Abs(xInt);i++)
                {
                    g.DrawLine(pen, X, p0.Y, X++, p0.Y);
                    X++;
                }
            }
            else if(xInt ==0)
            {
                int Y = Math.Min(p0.Y, p1.Y);
                for (int i = 0; i < Math.Abs(yInt); i++)
                {
                    g.DrawLine(pen, p0.X, Y, p0.X, Y++);
                    Y++;
                }
            }
            else //garis miring
            {
                if (Math.Abs(gradien) > 1)
                {
                    startPoint = p0.Y > p1.Y ? startPoint : endPoint;
                    endPoint = startPoint;
                    //rumus x = (y-c)/m
                    for (int i = 0; i < Math.Abs(yInt); i++)
                    {
                        endPoint.Y--;
                        endPoint.X = (int)Math.Round((endPoint.Y - c) / gradien, MidpointRounding.AwayFromZero);
                        g.DrawLine(pen, startPoint, endPoint);
                        startPoint = endPoint;
                    }
                }
                else
                {
                    //rumus y = mx+c
                    startPoint = p0.X >= p1.X ? startPoint : endPoint;
                    endPoint = startPoint;

                    for (int i = 0; i < Math.Abs(xInt); i++)
                    {
                        endPoint.X--;
                        endPoint.X = (int)Math.Round((gradien * endPoint.X + c), MidpointRounding.AwayFromZero);
                        g.DrawLine(pen, startPoint, endPoint);
                        startPoint = endPoint;
                    }
                }
            }

        }

        public void DrawBresenham(Point p0, Point p1, Pen pen, Graphics g)
        {
            pen = new Pen(Color.Purple);
            //tentukan dua titik untuk membuat garis
            Point startPoint = p0;
            Point endPoint = Point.Empty;

            //hitung deltaX dan deltaY
            double xInt = mm.getDeltaX(p0, p1);
            double yInt = mm.getDeltaY(p0, p1);

            //dibuat var deltaX dan deltaY absolut karena untuk operasi Bersenham
            double absxInt = Math.Abs(xInt);
            double absyInt = Math.Abs(yInt);

            double tambahX = xInt/ absxInt;
            double tambahY = yInt/ absyInt;
            
            //posisi awal Xk+1 dan Yk+1
            double Xkp1= p0.X ;
            double Ykp1= p0.Y ;

            if(absxInt > absyInt)
            {
                double pPatokan = 2 * absyInt - absxInt;
                double pK = pPatokan;
                for (int k = 1; k <= absxInt; k++)
                {
                    if (pK < 0)
                    {
                        pK = pK + 2 * absyInt;
                        Xkp1 += tambahX;
                        endPoint.X = (int)Xkp1;
                        endPoint.Y = (int)Ykp1;

                    }
                    else if (pK >= 0)
                    {
                        pK = pK + 2 * absyInt - 2 * absxInt;
                        Xkp1 += tambahX;
                        Ykp1 += tambahY;
                        endPoint.X = (int)Xkp1;
                        endPoint.Y = (int)Ykp1;
                    }
                    g.DrawLine(pen, startPoint, endPoint);
                }
            }
            else
            {
                double pPatokan = 2 * absxInt - absyInt;
                double pK = pPatokan;
                for (int k = 1; k <= absyInt; k++)
                {
                    if (pK < 0)
                    {
                        pK = pK + 2 * absxInt;
                        Ykp1 += tambahY;
                        endPoint.X = (int)Xkp1;
                        endPoint.Y = (int)Ykp1;

                    }
                    else if (pK >= 0)
                    {
                        pK = pK + 2 * absxInt - 2 * absyInt;
                        Xkp1 += tambahX;
                        Ykp1 += tambahY;
                        endPoint.X = (int)Xkp1;
                        endPoint.Y = (int)Ykp1;
                    }
                    g.DrawLine(pen, startPoint, endPoint);
                }
            }
        }
    }
}
