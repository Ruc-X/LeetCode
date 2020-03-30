using System;

namespace JumpGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 3, 1, 1, 4 };
            int length = nums.Length;
            int end=0,times=0;
            int maxpos = 0;
            for(int i=0;i<length-1;i++)
            {
                maxpos = Math.Max(maxpos, nums[i] + i);
                if(i==end)
                {
                    end = maxpos;
                    times++;
                }
            }
            Console.WriteLine("{0}", times);
        }
    }
}
