using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return "None";
        }
        int max = 0;
        string maxKey = "None";
        foreach (string item in myList.Keys)
        {
            if (myList[item] > max)
            {
                max = myList[item];
                maxKey = item;
            }
        }
        return maxKey;
    }
}