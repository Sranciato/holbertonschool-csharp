using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string maxKey = "None";
        if (myList.Count < 1)
        {
            return maxKey;
        }
        int max = -1;
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