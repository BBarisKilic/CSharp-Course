using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            char character = 'A';
            bool condition = false;
            byte number1 = 255;
            short number2 = 32767;
            int number3 = 2147483647;
            long number4 = 9223372036854775807;
            double number5 = 21.4;
            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine(character);
            Console.WriteLine(condition);
            Console.ReadKey();
        }
    }
}
