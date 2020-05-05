using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>operations class</summary>
    public class Str
    {
        ///<summary>returns the max integer in a list of integers</summary>
        public static int UniqueChar(string s)
        {
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != s[i - 1])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}