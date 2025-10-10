using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Circle(8, "Red"));
        shapes.Add(new Square(7, "Blue"));
        shapes.Add(new Rectangle(5, 9, "Green"));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Shape: {shape.GetType().Name}, Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }

    }
}