using System;

namespace _6_vector_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            double product =  MatrixMath.Determinant(new double[,] {{1, 2}, {4, 5}});
            Console.WriteLine(product);
        }
    }
}