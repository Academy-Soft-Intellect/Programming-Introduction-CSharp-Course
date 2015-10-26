using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasko01
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                sum = sum + number;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
