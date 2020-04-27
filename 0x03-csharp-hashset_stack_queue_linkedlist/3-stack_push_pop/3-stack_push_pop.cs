using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        string topElem = "";
        bool searchInList = false;

        Console.WriteLine("Number of items: " + aStack.Count);
        if (aStack.Count < 1)
        {
            Console.WriteLine("Stack is empty");
            return aStack;
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
        }
        while (aStack.Pop() != search)
            ;
        
        Console.WriteLine("Top item: " + topElem);
        if (!searchInList)
            Console.WriteLine("Stack contains \"" + search + "\": False");
        else
            Console.WriteLine("Stack contains \"" + search + "\": True");
        
        aStack.Push(newItem);
        return aStack;
    }
}