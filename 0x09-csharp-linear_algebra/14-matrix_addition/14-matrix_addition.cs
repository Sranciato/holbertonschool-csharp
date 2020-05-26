using System;
using System.Collections.Generic;

///<summary>Vector class</summary>
class MatrixMath
{
    ///<summary>get magnitude for 2d and 3d vectors</summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] sum;

        if ((matrix1.GetLength(0) < 2 || matrix1.GetLength(0) > 3) || (matrix2.GetLength(0) < 2 || matrix2.GetLength(0) > 3))
            return new double[,] {{-1}};
        if (matrix1.GetLength(0) != matrix1.GetLength(1) || matrix2.GetLength(0) != matrix2.GetLength(1))
            return new double[,] {{-1}};

        int len = matrix1.GetLength(0);
        sum = new double[len, len];

        for (int i = 0; i < len; i++)
            for (int j = 0; j < len; j++)
                sum[i,j] = matrix1[i,j] + matrix2[i,j];

        return sum;
    }
}