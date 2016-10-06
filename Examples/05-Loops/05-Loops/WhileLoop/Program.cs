using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while (counter <= 20)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("Loop ended!");
        }
    }
}
