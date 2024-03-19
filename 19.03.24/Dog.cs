using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._24
{
    internal class Dog
    {
        private string Name;
        private int Age;

        public void Input(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Output()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
        }
    }
}
