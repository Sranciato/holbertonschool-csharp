using System;
using System.Collections.Generic;

namespace Text
{
    ///<summary>operations class</summary>
    public class Str
    {
        ///<summary>returns the max integer in a list of integers</summary>
        public static bool IsPalindrome(string s)
        {
            s = s.ToLower();
            int end = s.Length - 1;

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (Char.IsLetter(s[i]) == false)
                    continue;
                if (Char.IsLetter(s[end]) == false)
                {
                    end -= 1;
                    i -= 1;
                    continue;
                }
                if (s[i] != s[end])
                    return false;
                end -= 1;
            }
            return true;
        }
    }
}