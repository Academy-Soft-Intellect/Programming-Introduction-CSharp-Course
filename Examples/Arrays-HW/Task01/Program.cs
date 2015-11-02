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
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int sumOfEvenNumbers = 0;
            int sumOfEvenMembers = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    sumOfEvenMembers += arr[i];
                }

                if (arr[i] % 2 == 0)
                {
                    sumOfEvenNumbers += arr[i];
                }
            }
            Console.WriteLine("Sum of even numbers: " + sumOfEvenNumbers);

            Console.WriteLine("Sum of even members: " + sumOfEvenMembers);

        }
    }
}
