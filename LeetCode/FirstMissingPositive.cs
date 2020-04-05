using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeAns
{
    class FirstMissingPositive
    {
        static int Main()
        {
            int[] nums;
            nums = new int[] {1,2,3};
            int length = nums.Length;
            int[] appear;
            appear = new int[length];
            for(int i=0;i<length;i++)
            {
                if (nums[i]<=length&&nums[i]>=1)
                {
                    appear[nums[i] - 1] = 1;
                }
            }
            for(int i=0;i<length;i++)
            {
                if (appear[i] == 0)
                {
                    Console.WriteLine("{0}", i + 1);
                    return (i + 1);
                }
            }
            Console.WriteLine("{0}", length + 1);
            return (length + 1);
        }
    }
}
