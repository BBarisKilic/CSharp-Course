using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add2(20,30);
            var result = Add3(20,20);
            Console.WriteLine("Add3: {0}", result);
            Console.ReadKey();
        }

        //void method
        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //void method with parameter
        static void Add2(int number1, int number2)
        {
            Console.WriteLine("Result: {0}", number1 + number2);
        }

        //int method with parameter
        static int Add3(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }
    }
}
