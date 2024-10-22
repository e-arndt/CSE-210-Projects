// Added a fourth shape, Triangle, for fun

using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square s1 = new Square("Yellow", 7);
        shapes.Add(s1);

        
        Rectangle r1 = new Rectangle("Purple", 6, 10);
        shapes.Add(r1);
        

        Circle c1 = new Circle("Red", 7);
        shapes.Add(c1);


        Triangle t1 = new Triangle("Green", 17, 21);
        shapes.Add(t1);
        
        Console.Clear();

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}\n");
        }
        
        Console.WriteLine();
    }
}