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
        private int _x0;
        private int _x1;
        private int _y0;
        private int _y1;

        public int x0
        {
            set { _x0 = value; }
            get { return _x0; }
        }

        public int x1
        {
            set { _x1 = value; }
            get { return _x1; }
        }
        public int y0
        {
            set { _y0 = value; }
            get { return _y0; }
        }

        public int y1
        {
            set { _y1 = value; }
            get { return _y1; }
        }

        public twoPoint()
        {

        }

        public twoPoint(int x0, int x1, int y0, int y1)
        {
            _x0 = x0;
            _x1 = x1;
            _y0 = y0;
            _y1 = y1;
        }
    }
}
