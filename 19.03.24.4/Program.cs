using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._24._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 1.5, 2.5, 3.5, 4.5, 5.5 };


            double sum = MathOperations.Sum(array);
            Console.WriteLine($"Sum: {sum}");


            double average = MathOperations.Average(array);
            Console.WriteLine($"Average: {average}");
        }
    }
}
