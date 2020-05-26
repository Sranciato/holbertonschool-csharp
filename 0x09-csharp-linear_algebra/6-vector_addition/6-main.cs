using System;

namespace _6_vector_addition
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] sum =  VectorMath.Add(new double[] {3, 9}, new double[] {1, 1});
            Console.WriteLine("Sum is ({0}, {1})", sum[0], sum[1]);
        }
    }
}
