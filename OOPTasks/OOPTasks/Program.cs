using System;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle input = new Circle(4.5);
            
            Console.WriteLine(input.perimeter());
            Console.WriteLine(input.area());

            Square square = new Square(5.0);
            Console.WriteLine(square.perimeter());
            Console.WriteLine(square.area());


            Triangle triangle = new Triangle(5.0, 6.0, 7.0);
            Console.WriteLine(triangle.perimeter());
            Console.WriteLine(triangle.area());
        }

    }
}






