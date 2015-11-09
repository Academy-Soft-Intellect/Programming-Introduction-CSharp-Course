using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int[] arr1 = new int[n];


            int m = 100;
            int[] arr2 = new int[m];


            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = i + 1;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = i + 1;
            }

            Console.WriteLine("Sum of first arr numbers:");
            CalculateSum(arr1);


            Console.WriteLine("Sum of second arr numbers:");
            CalculateSum(arr2);

        }

        private static void CalculateSum(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
