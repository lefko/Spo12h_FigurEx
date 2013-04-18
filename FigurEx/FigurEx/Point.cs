using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurEx
{
    class Point : IMoveable
    {
        private int x;
        private int y;

        public Point():this(10,10)
        {}

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get { return x;  }
            set
            {
                if ( value >= 0)
                    x = value;
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                if (value >= 0)
                    y = value;
            }
        }

        void IMoveable.Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public override string ToString()
        {
            return string.Format("Selected point is x: {0}, y: {1}", X, Y);
            
        }
    }
}
