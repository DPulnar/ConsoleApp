using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Zad1
{
    internal class Shape(double x)
    {
        double x { get; set; }
        double y { get; set; }
        double width { get; set; }
        double height { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }

    }
}
