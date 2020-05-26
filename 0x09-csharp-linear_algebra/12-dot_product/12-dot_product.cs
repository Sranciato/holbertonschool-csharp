using System;
using System.Collections.Generic;

///<summary>Vector class</summary>
class VectorMath
{
    ///<summary>get magnitude for 2d and 3d vectors</summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        double dotprod = 0;

        if ((vector1.Length < 2 || vector1.Length > 3) || (vector2.Length < 2 || vector2.Length > 3))
            return -1;
        if (vector1.Length != vector2.Length)
            return -1;

        for (int i = 0; i < vector1.Length; i++)
            dotprod += vector1[i] * vector2[i];

        return dotprod;
    }
}