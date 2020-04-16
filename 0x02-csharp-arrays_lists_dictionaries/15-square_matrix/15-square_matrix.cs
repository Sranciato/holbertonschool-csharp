using System;
class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] newMatrix = new int[3,3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                newMatrix[i,j] = myMatrix[i,j] * myMatrix[i,j];
            }
        }
        return newMatrix;
    }
}