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
            Console.WriteLine("Enter array length;");
            int n = int.Parse(Console.ReadLine());
            int[] ourArray = new int[n];

            Console.WriteLine("Result array:");
            //for (int i = 0; i < ourArray.Length; i++)
            //{
            //    ourArray[i] = ourArray.Length - i;
            //    Console.WriteLine("{0}:{1}", i + 1, ourArray[i]);
            //}

            for (int i = ourArray.Length, j = 0; i > 0; i--, j++)
            {
                ourArray[j] = i;
                Console.WriteLine("{0}:{1}", j + 1, ourArray[j]);
            }
        }
    }
}
