using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = "Ivaylo";
            string str = "Hello ";
            string result = str + name;
            Console.WriteLine(result);

            Console.WriteLine(result[1]);
        }
    }
}
