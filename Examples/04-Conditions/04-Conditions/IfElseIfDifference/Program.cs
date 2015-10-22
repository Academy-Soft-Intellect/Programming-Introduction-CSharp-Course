using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseIfDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Positive");
            }
            if (a == 0)
            {
                Console.WriteLine("Zero");
            }
            if (a < 0)
            {
                Console.WriteLine("Negative");
            }

            if (a > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (a == 0)
            {
                Console.WriteLine("Zero");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
