using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newList1 = list1.FindAll(elem => !list2.Contains(elem));
        List<int> newList2 = list2.FindAll(elem => !list1.Contains(elem));

        newList1.AddRange(newList2);
        newList1.Sort();

        return newList1;
    }
}