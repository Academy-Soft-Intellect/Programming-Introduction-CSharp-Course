using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinAndMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers do you want to compare:");
            int amountOfNumbers = int.Parse(Console.ReadLine());

            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int i = 0; i < amountOfNumbers; i++)
            {
                Console.WriteLine("Please enter next number:");
                int currentNumber = int.Parse(Console.ReadLine());

                if (minValue > currentNumber)
                {
                    minValue = currentNumber;
                }

                if (maxValue < currentNumber)
                {
                    maxValue = currentNumber;
                }
            }

            Console.WriteLine("Max value is {0}", maxValue);
            Console.WriteLine("Min value is {0}", minValue);

        }
    }
}
