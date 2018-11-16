using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremitivesCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            Console.WriteLine(number);

            float price = 2.2f;
            Console.WriteLine(price);

            string s = "Test";

            bool isWorking = false;


            Console.WriteLine(isWorking);
            Console.WriteLine(s);
            Console.WriteLine(price);

            Console.WriteLine("Max: {0} Min: {1}", int.MaxValue, int.MinValue);
            Console.WriteLine("Max: {0} Min: {1}", byte.MaxValue, byte.MinValue);


            try
            {
                var numberS = "1234";
                byte b = Convert.ToByte(numberS);
                Console.WriteLine(b);
            } catch (Exception)
            {
                Console.WriteLine("The number could not convert to byte");
            }

            int aa = 3;
            int bb = 5;
            Console.WriteLine(aa/bb);
            Console.WriteLine((float)aa / (float) bb);

            Console.ReadKey();
        }
    }
}
