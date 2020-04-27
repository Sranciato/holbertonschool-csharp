using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        bool searchInList = false;

        Console.WriteLine("Number of items: " + aStack.Count);
        if (aStack.Count < 1)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine("Top item: " + aStack.Peek());
        }
        foreach (string item in aStack)
        {
            if (item == search)
            {
                searchInList = true;
            }
        }
        if (!searchInList)
            Console.WriteLine("Stack contains \"" + search + "\": False");
        else
        {
            Console.WriteLine("Stack contains \"" + search + "\": True");
            while (aStack.Pop() != search)
                ;
        }
        
        aStack.Push(newItem);
        return aStack;
    }
}