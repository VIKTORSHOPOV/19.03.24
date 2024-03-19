using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._03._24._2
{
    internal class Person
    {

        private string firstName;
        private string middleName;
        private string lastName;
        private int birthYear;


        public void InputData()
        {
            Console.WriteLine("Enter first name:");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter middle name:");
            middleName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter birth year:");
            birthYear = Convert.ToInt32(Console.ReadLine());
        }


        public int CalculateAge()
        {
            return DateTime.Now.Year - birthYear;
        }


        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {firstName} {middleName} {lastName}");
            Console.WriteLine($"Birth Year: {birthYear}");
        }
    }
}
