using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitives
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            const float pi = 3.14f;

            Console.WriteLine("Number: " + number + " Pi: " + pi);

            checked
            {
                byte number2 = 255;
                number2 = (byte)( number2 + number2);
            }
        }
    }
}
