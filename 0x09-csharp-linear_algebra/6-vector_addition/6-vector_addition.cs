
using System;
using System.Collections.Generic;

///<summary>Vector class</summary>
class VectorMath
{
    ///<summary>get magnitude for 2d and 3d vectors</summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] sum;

        if ((vector1.Length < 2 && vector1.Length > 3) || (vector1.Length < 2 && vector1.Length > 3))
            return new double[] {-1};
        if (vector1.Length != vector2.Length)
            return new double[] {-1};
        if (vector1.Length == 2)
        {
            sum = new double[] {vector1[0] + vector2[0], vector1[1] + vector2[1]};
            return sum;
        }
        else if (vector1.Length == 3)
        {
            sum = new double[] {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
            return sum;
        }
        return new double[] {-1};
    }
}