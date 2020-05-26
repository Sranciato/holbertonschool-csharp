using System;
using System.Collections.Generic;

///<summary>Vector class</summary>
class VectorMath
{
    ///<summary>get magnitude for 2d and 3d vectors</summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length < 2 || vector.Length > 3)
            return new double[] {-1};

        for (int i = 0; i < vector.Length; i++)
            vector[i] *= scalar;

        return vector;
    }
}