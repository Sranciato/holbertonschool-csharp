using System;

namespace _6_vector_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] product =  MatrixMath.Multiply(new double[,] {{1, 2, 3}, {4, 5, 6}}, new double[,] {{ 5, 6 }, { 7, 8 } , {9, 10}});
            Console.WriteLine("|{0}|{1}|\n", product[0,0], product[0,1]);
            Console.WriteLine("|{0}|{1}|\n", product[1,0], product[1,1]);
        }
    }
}