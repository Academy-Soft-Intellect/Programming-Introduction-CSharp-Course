using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];


            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int numberToSearch = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                if (arr[i] == numberToSearch)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("Nqma go");
            }
            //Console.WriteLine(Array.IndexOf(arr, 4));
        }
    }
}
