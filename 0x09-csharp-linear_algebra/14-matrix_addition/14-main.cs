using System;

namespace _6_vector_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] product =  MatrixMath.Add(new double[,] {{3, 4}, {3, 4}}, new double[,] {{3, 4}, {3, 4}});
            Console.WriteLine("|{0}|{1}|\n", product[0,0], product[0,1]);
            Console.WriteLine("|{0}|{1}|\n", product[1,0], product[1,1]);
        }
    }
}