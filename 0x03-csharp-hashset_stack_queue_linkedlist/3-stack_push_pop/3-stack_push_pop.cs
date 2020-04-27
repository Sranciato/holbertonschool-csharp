using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int count = 0;
        string topElem = "";
        bool searchInList = false;

        if (aStack.Count < 1)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            topElem = aStack.Peek();
        }
        foreach (string item in aStack)
        {
            if (item == search)
            {
                searchInList = true;
            }
            count += 1;
        }
        while (aStack.Pop() != search)
            ;
        
        Console.WriteLine("Number of Items: " + count);
        Console.WriteLine("Top item: " + topElem);
        if (!searchInList)
            Console.WriteLine("Stack contains \"" + search + "\": False");
        else
            Console.WriteLine("Stack contains \"" + search + "\": True");
        
        aStack.Push(newItem);
        return aStack;
    }
}