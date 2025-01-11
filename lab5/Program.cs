using lab5.zad1;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(10);
            int radius = circle.CalculateArea();
            Console.WriteLine(radius);
            Square square = new Square(10);
            int a = square.CalculateArea();
            Console.WriteLine(a);
        }
    }
}
