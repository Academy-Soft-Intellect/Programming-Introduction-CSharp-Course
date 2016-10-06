using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        private static void Main(string[] args)
        {
            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 15 - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Now reverse:");
            //for (int i = 15 - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //int counter = 0;

            //for (int i = 1; i <= 4; i*=2)
            //{
            //    for (int j = 1; j <= 3; j++)
            //    {
            //        Console.WriteLine("I = {0}, J = {1}, counter = {2}", i, j, counter);
            //        //Console.WriteLine("I = " + i + ", J = " + j + ", counter = " + counter);
            //        counter++;
            //    }
            //}

            //int n = 10;

            //long factorial = 1;

            //for (int i = 1; i <= n; i++)
            //{
            //    factorial *= i;
            //}

            //Console.WriteLine("{0}! = {1}", n, factorial);

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = int.Parse(Console.ReadLine()); i > 1; i--)
            {
                if (i % m == 0 && i % n == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
