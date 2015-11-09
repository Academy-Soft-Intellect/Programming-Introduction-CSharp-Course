using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, n];

            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }

            int max = int.MinValue;
            int min = int.MaxValue;
            int minCol = 0;
            int minRow = 0;
            int maxCol = 0;
            int maxRow = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (max < arr[i, j])
                    {
                        max = arr[i, j];
                        maxCol = j;
                        maxRow = i;
                    }
                    if (min > arr[i, j])
                    {
                        min = arr[i, j];
                        minCol = j;
                        minRow = i;
                    }
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Max element is {0} and is on [{1},{2}]", max, maxRow, maxCol);
            Console.WriteLine("Min element is {0} and is on [{1},{2}]", min, minRow, minCol);


        }
    }
}
