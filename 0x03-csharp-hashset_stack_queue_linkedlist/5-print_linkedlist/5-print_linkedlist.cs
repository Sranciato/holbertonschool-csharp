using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> llist = new LinkedList<int>();

        for (int i = 0; i < size; i++)
        {
            llist.AddLast(i);
        }
        foreach (int item in llist)
        {
            Console.WriteLine(item);
        }
        return llist;
    }
}