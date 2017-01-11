using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Mini_Paint
{
    class twoPoint
    {
        private Point _p0;
        private Point _p1;
        
        public Point p0
        {
            set { _p0 = value; }
            get { return _p0; }
        }

        public Point p1
        {
            set { _p1 = value; }
            get { return _p1; }
        }

        public twoPoint()
        {

        }

        public twoPoint(Point p0, Point p1)
        {
            _p0 = p0;
            _p1 = p1;
        }
    }
}
