using System;
using System.Numerics;

namespace BigIntegerAndFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger bigInt = 1;
            int a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                bigInt *= a;
                //bigInt = bigInt * a;
                a--;
            }
            Console.WriteLine(bigInt);
        }
    }
}
