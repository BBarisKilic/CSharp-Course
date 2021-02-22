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
            Add2(20, 30);
            var result = Add3(20, 20);
            Console.WriteLine("Add3: {0}", result);
            var result2 = Add4(20);
            Console.WriteLine("Add4: {0}", result2);
            int number1 = 20;
            int number2 = 100;
            var result3 = Add5(ref number1, number2);
            Console.WriteLine("Add5: {0}", result3);
            Console.WriteLine("number1: {0}", number1);
            int number3;
            int number4 = 50;
            var result4 = Add6(out number3, number4);
            Console.WriteLine("Add5: {0}", result4);
            Console.WriteLine("number1: {0}", number3);
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

        //parameter with default value
        static int Add4(int number1, int number2 = 40)
        {
            var result = number1 + number2;
            return result;
        }

        //method with reference parameter
        static int Add5(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //method with out parameter
        static int Add6(out int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
