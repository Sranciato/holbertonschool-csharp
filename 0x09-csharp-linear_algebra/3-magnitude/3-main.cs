using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        double magnitude =  VectorMath.Magnitude(new double[] {3, 9});
        Console.WriteLine("Magnitude is " + magnitude);
    }
}