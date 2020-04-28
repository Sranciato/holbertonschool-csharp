using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        try
        {
            foreach (int item in myList)
            {
                Console.WriteLine(item);
                count += 1;
                if (count == n)
                    return count;
            }
            return count;
            
        }
        catch (System.Exception)
        {
            return count;
        }
    }
}