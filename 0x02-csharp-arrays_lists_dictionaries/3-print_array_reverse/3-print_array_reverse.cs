using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }

        int size = array.Length - 1, start = 0;
        int[] reverseArray = new int[array.Length];

        for (int i = size; i >= 0; i--)
        {
            reverseArray[start] = array[i];
            start++;
        }
        Console.WriteLine("{0}", string.Join(" ", reverseArray));
    }
}