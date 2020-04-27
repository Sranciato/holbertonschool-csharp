using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> searchNode = myLList.First;

        while (searchNode != null)
        {
            if (n < searchNode.Value)
            {
                myLList.AddBefore(searchNode, n);
                return searchNode;
            }
            searchNode = searchNode.Next;
        }
        myLList.AddLast(n);
        return myLList.Last;
    }
}