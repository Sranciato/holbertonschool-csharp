using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length < 1)
            Console.WriteLine("");
        for (int i = 0; i < length; i++)
            Console.Write("_");
    }
}