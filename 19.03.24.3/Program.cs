using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._24._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            Console.WriteLine("Enter the sides of the triangle:");
            triangle.InputSides();

            double perimeter = triangle.CalculatePerimeter();
            Console.WriteLine($"Perimeter of the triangle: {perimeter}");

            double area = triangle.CalculateArea();
            Console.WriteLine($"Area of the triangle: {area}");
        }
    }
}
