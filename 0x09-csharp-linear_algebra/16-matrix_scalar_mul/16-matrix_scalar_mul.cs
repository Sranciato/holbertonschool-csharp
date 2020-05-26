using System;
using System.Collections.Generic;

///<summary>Vector class</summary>
class MatrixMath
{
    ///<summary>get magnitude for 2d and 3d vectors</summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] sum;

        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
            return new double[,] {{-1}};
        if (matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] {{-1}};

        int len = matrix.GetLength(0);
        sum = new double[len, len];

        for (int i = 0; i < len; i++)
            for (int j = 0; j < len; j++)
                sum[i,j] = matrix[i,j] * scalar;

        return sum;
    }
}