using System;
using System.Collections.Generic;

namespace MyMath
{
    ///<summary>operations class</summary>
    public class Operations
    {
        ///<summary>returns the max integer in a list of integers</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
                return 0;
            int max = nums[0];
            foreach (int number in nums)
            {
                if (number > max)
                    max = number;
            }
            return max;
        }
    }
}
