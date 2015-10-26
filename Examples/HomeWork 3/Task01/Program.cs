using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(a[index]);

            if (index >= 1 && index <= 3)
            {
                Console.WriteLine(index * 5);
            }
            else if (index >= 4 && index <= 6)
            {
                Console.WriteLine(index * 10);
            }
            else if (index >= 7 && index <= 9)
            {
                Console.WriteLine(index * 50);
            }
        }
    }
}
