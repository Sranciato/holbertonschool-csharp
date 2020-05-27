using System;
using System.Collections.Generic;

///<summary>Vector class</summary>
class MatrixMath
{
    ///<summary>get magnitude for 2d and 3d vectors</summary>
    public static double Determinant(double[,] matrix)
    {
        if (!((matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2) || (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)))
            return -1;

        int len = matrix.GetLength(0);
        double det = 0;

        if (len == 2)
        {
            det = matrix[0, 0] * matrix[1, 1] - (matrix[0, 1] * matrix[1, 0]);
        }
        else if (len == 3)
        {
            for(int i = 0; i < len; i++)
                det = det + (matrix[0, i] * (matrix[1, (i + 1) % len] * matrix[2, (i + 2) % len] - matrix[1, (i+2) % len] * matrix[2, (i + 1) % len]));  
        }
        

        return det;
    }
}