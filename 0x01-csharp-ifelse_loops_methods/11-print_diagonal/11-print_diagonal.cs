﻿using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length < 1)
            Console.WriteLine();
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
    }
}