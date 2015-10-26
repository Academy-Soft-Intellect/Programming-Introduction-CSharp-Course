using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        private static void Main(string[] args)
        {
            //for (int number = 0; number < 5; number++)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.WriteLine();

            int n = 20;

            long factorial = 1;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", n, factorial);
        }
    }
}
