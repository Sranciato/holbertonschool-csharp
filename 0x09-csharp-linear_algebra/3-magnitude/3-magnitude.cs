using System;
using System.Collections.Generic;

///<summary>Vector class</summary>
class VectorMath
{
    ///<summary>get magnitude for 2d and 3d vectors</summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length == 2)
        {
            double hypotenuse = Math.Sqrt((vector[0] * vector[0]) + (vector[1] * vector[1]));
            return Math.Round(hypotenuse, 2);
        }
        else if (vector.Length == 3)
        {
            double hypotenuse = Math.Sqrt(((vector[0] * vector[0]) + (vector[1] * vector[1])) + (vector[2] * vector[2]));
            return Math.Round(hypotenuse, 2);
        }
        return -1;
    }
}