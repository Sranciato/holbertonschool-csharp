using System;

namespace _6_vector_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            double product =  VectorMath.DotProduct(new double[] {3, 4}, new double[] {3, 4});
            Console.WriteLine("Product is {0}", product);
        }
    }
}
