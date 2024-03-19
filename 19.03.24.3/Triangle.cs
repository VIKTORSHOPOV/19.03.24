using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._24._3
{
    internal class Triangle
    {

        private double side1;
        private double side2;
        private double side3;


        public bool IsTriangle(double a, double b, double c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }


        public void InputSides()
        {
            Console.WriteLine("Enter the length of side 1:");
            side1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of side 2:");
            side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of side 3:");
            side3 = Convert.ToDouble(Console.ReadLine());


            if (!IsTriangle(side1, side2, side3))
            {
                Console.WriteLine("Invalid triangle!");
                InputSides();
            }
        }


        public double CalculatePerimeter()
        {
            return side1 + side2 + side3;
        }


        public double CalculateArea()
        {
            double s = CalculatePerimeter() / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }
    }
}
