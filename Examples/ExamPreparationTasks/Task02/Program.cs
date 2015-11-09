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
            int arrLength = int.Parse(Console.ReadLine());
            int[] arr1 = new int[arrLength];
            int[] arr2 = new int[arrLength];


            for (int i = 0; i < arrLength; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrLength; i++)
            {
                for (int j = 0; j < arrLength; j++)
                {
                    if (arr1[i]==arr2[j])
                    {
                        Console.WriteLine(arr2[j]);
                    }
                }
            }
        }
    }
}
