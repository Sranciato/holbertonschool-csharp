using System;

namespace _6_vector_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] product =  VectorMath.Multiply(new double[] {3, 4}, 2);
            Console.WriteLine("Product is ({0}, {1})", product[0], product[1]);
        }
    }
}
