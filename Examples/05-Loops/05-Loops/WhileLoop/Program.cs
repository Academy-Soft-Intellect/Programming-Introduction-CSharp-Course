using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int n = int.Parse(Console.ReadLine());

            while (counter <= n)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
            Console.WriteLine();
            counter = 1;
            while (counter <= n)
            {
                if (counter % 2 == 0)
                {
                    counter++;
                    continue;
                }
                Console.WriteLine(counter);
                counter++;
            }

        }
    }
}
