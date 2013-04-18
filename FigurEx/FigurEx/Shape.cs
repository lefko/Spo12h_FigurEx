using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurEx
{
    abstract class Shape
    {
        private Point p1; //aggregat implementera som objekt i klassen
        
        public Shape()
        {
            p1 = new Point();
        }

        public Shape(int x, int y)
        {
            p1 = new Point(x, y);
        }

        public override string ToString()
        {
            return "p1 finns på " + p1.ToString();
        }

        public void Move(int x, int y)
        {
            p1.Move(x, y);
        }
    }
}
