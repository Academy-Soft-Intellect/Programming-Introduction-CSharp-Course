using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] matrix = new int[,]
            //{
            //    {15, 1, 14},
            //    {55, 11, 523},
            //    {554, 131, 23}
            //};

            //Console.WriteLine(matrix.GetLength(0));
            //Console.WriteLine(matrix.GetLength(1));
            //Console.WriteLine(matrix.Length);

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int k = 0; k < matrix.GetLength(1); k++)
            //    {
            //        string a = string.Format("{0} \t", matrix[i, k]);
            //        Console.Write(a);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            Console.WriteLine("Enter number of rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of cols:");
            int cols = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of matrixes:");
            int matrices = int.Parse(Console.ReadLine());

            int[,] matrix2 = new int[rows, cols];

            Random rand = new Random();
            for (int m = 0; m < matrices; m++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        //Console.WriteLine("Enter element for {0}:{1}", i, j);
                        string a = string.Format("Enter element for {0}:{1}", i, j);
                        //Console.WriteLine(a);
                        matrix2[i, j] = rand.Next(0, 101);
                    }
                }


                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        Console.Write("|" + matrix2[i, j] + "|" + "\t");
                    }
                    Console.WriteLine();
                }
            }


            //for (int a = 0; a < 3; a++)
            //{
            //    for (int b = 0; b < 3; b++)
            //    {
            //        Console.Write(matrix[a,b] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[,] matrix2 = new int[5, 2];
            //Console.WriteLine(matrix2.GetLength(0));
            //Console.WriteLine(matrix2.GetLength(1));

            //for (int i = 0; i < matrix2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix2.GetLength(1); j++)
            //    {
            //        Console.Write("Enter number for {0}:{1}:", i, j);
            //        matrix2[i, j] = int.Parse(Console.ReadLine());
            //        if (matrix2[i, j] % 2 != 0)
            //        {
            //            matrix2[i, j] *= 2;
            //        }
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //for (int a = 0; a < matrix2.GetLength(0); a++)
            //{
            //    for (int b = 0; b < matrix2.GetLength(1); b++)
            //    {
            //        Console.Write(matrix2[a, b] + "\t");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            ////foreach (var item in matrix)
            ////{
            ////    Console.WriteLine(item);
            ////}


            //Console.WriteLine(matrix[2, 1]);
            //matrix[2, 1] = 12;
            //Console.WriteLine(matrix[2, 1]);


            //Console.WriteLine();
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write("{0} ", matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}


        }
    }
}
