using System;

namespace lab4
{
    internal class Rectangle(double x) : Shape(x)
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }

}
