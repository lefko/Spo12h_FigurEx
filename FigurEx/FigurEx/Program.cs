using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigurEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();

            p.Move(100, 200);
            Console.WriteLine(p.ToString());
        }
    }
}
