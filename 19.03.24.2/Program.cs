using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._24._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.InputData();
            int age = person.CalculateAge();
            Console.WriteLine($"Age: {age}");
            person.DisplayInfo();
        }
    }
}
