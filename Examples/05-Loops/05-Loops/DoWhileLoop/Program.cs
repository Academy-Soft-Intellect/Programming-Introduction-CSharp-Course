﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        private static void Main(string[] args)
        {
            int counter = 0;

            do
            {
                Console.WriteLine("Value of the counter: " + counter);
                counter--;
            } while (counter > 0);
        }
    }
}