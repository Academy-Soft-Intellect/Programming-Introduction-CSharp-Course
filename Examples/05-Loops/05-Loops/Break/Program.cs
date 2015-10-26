using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Program
    {
        private static void Main(string[] args)
        {
            for (int i = 0; i <= 15; i++)
            {
                if (i == 11)
                {
                    break;
                }

                Console.Write("Odd number: {0}", i);
                Console.WriteLine();
            }


        }
    }
}
