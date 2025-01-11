using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad1
{
    internal class Circle : Shape
    {
        private int Radius { get; set; }
        public override int CalculateArea()
        {
            return (int)(this.Radius * this.Radius * 3.14);
        }
        public Circle(int radius)
        {
            this.Radius = radius;
        }
    }
}
