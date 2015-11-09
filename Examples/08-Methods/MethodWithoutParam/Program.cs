using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodWithoutParam
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHello();
            PrintHello();
            PrintHello();
            PrintHello();

            for (int i = 0; i < 5; i++)
            {
                PrintHello();
            }
        }

        public static void PrintHello()
        {
            Console.WriteLine("Hello");
        }
    }
}
