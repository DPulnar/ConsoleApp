using Lab4.Zad1;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Rectangle(10, 20));
            shapes.Add(new Circle(15, 25));
            shapes.Add(new Triangle(20, 30));
            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
