using System;
using System.Collections.Generic;

///<summary>Vector class</summary>
class MatrixMath
{
    ///<summary>get magnitude for 2d and 3d vectors</summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        double[,] newMatrix;
        double matrixSum;

        int row1 = matrix1.GetLength(0);
        int column1 = matrix1.GetLength(1);

        int row2 = matrix2.GetLength(0);
        int column2 = matrix2.GetLength(1);

        if (column1 != row2)
            return new double[,] {{-1}};

        newMatrix = new double[row1, column2];

        for (int i = 0; i < row1; i++)
            for (int j = 0; j < column2; j++)
            {
                matrixSum = 0;
                for (int x = 0; x < column1; x++)
                {
                    matrixSum += matrix1[i, x] * matrix2[x, j];
                }
                newMatrix[i, j] = matrixSum;
            }

        return newMatrix;
    }
}