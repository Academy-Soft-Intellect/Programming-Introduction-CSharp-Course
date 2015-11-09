using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithParam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 10;

            int c = Sum(a, b);

            Console.WriteLine(c);

            Console.WriteLine(Sum(a, b));
        }

        private static int Sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;

            return result;
        }
    }
}
