using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Calculator
    {
        public int add(int i , int j)
        {
            return i + j;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Calculator().add(10,11));
            Console.ReadKey();

            PersonNS.Person person = new PersonNS.Person();
            person.firstName = "A";
            person.lastName = "B";
            Console.WriteLine(person.introduce());
            Console.ReadKey();
        }

    }
}
