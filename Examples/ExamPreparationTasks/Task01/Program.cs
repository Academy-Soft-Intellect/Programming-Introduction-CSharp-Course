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
            int[] arr = new int[10];

            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("Enter the numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (max < arr[i])
                    {
                        max = arr[i];
                    }
                }
                else
                {
                    if (min > arr[i])
                    {
                        min = arr[i];
                    }
                }
            }
            Console.WriteLine("Max number is: " + max);
            Console.WriteLine("Min number is: " + min);

        }
    }
}
