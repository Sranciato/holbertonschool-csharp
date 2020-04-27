using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> current = myLList.First;
        int i = 0;

        while (current != null)
        {
            if (index == i)
            {
                myLList.Remove(current);
                return;
            }
            current = current.Next;
            i += 1;
        }
    }
}