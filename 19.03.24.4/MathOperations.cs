using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._24._4
{
    internal class MathOperations
    {

        public static double Sum(double[] numbers)
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum;
        }


        public static double Average(double[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            double sum = Sum(numbers);
            return sum / numbers.Length;
        }
    }
}
