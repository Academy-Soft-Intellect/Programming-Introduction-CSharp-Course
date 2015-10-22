using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice: int, double, string");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "int":
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(++number);
                    break;

                case "double":
                    double floatingPointNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine(++floatingPointNumber);
                    break;

                case "string":
                    string stringChoice = Console.ReadLine();
                    Console.WriteLine(stringChoice+"*");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }
}
