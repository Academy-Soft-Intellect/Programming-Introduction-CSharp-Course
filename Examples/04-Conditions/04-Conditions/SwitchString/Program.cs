using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchString
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            switch (a)
            {
                case "Hello":
                    Console.WriteLine(true);
                    break;

                default:
                    Console.WriteLine(false);
                    break;
            }
        }
    }
}
