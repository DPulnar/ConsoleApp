using System;

namespace lab4
{
    internal class Shape(double x)
    {
        public double x { get; set; }
        public double y { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public virtual void Draw()
        {
            Console.WriteLine("Shape");
        }
    }

}
