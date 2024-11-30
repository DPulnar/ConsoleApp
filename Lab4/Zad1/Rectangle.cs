using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Zad1
{
    internal class Rectangle(double x, double y) : Shape(x)
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }

}
