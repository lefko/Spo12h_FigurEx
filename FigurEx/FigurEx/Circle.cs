using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurEx
{
    class Circle : Shape
    {
        private double radie;

        public Circle()
        {
            Radie = 5;
        }

        public Circle(double r)
        {
            Radie = r;
        }

        public double Radie
        {
            get { return radie; }
            set
            {
                if (value > 0)
                    radie = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Cirkeln har radie: {0} är på punkt: ", Radie + base.ToString());
        }
    }
}
