using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.zad1
{
    internal class Square : Shape
    {
        private int a { get; set; }
        public override int CalculateArea()
        {
            return this.a * this.a;
        }
        public Square(int a)
        {
            this.a = a;
        }
    }
}
