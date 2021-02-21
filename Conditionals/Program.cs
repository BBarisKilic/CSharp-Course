using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            //Note: Ctrl+K, Ctrl+D => Reformat code
            //Note: Ctrl+K, Ctrl+C => Comment
            //Note: Ctrl+K, Ctrl+U => Uncomment

            var number = 11;

            //if - else
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }

            else
            {
                Console.WriteLine("Number is not 10");
            }

            //single line if
            Console.WriteLine(number == 10 ? "Number is 10" : "Number isn't 10");

            //else if
            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");
            }
            else
            {
                Console.WriteLine("Number is neither 10 nor 20");
            }

            //switch
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is neither 10 nor 20");
                    break;
            }

            //&& and ||
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }

            Console.ReadKey();
        }
    }
}
