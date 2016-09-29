using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 220;
            double y = 7;

            float pesho = 220;
            float gosho = 7;

            decimal decimalX = 220;
            decimal decimalY = 7;

            double a = x / y;
            float b = pesho / gosho;
            decimal c = decimalX / decimalY;

            Console.WriteLine(b);
            Console.WriteLine(a);
            Console.WriteLine(c);
        }
    }
}
