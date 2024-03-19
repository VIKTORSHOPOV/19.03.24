using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Input(Console.ReadLine(), int.Parse(Console.ReadLine()));
            dog.Output();
        }
    }
}
