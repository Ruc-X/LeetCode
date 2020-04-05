using System;

namespace LeetCodeAns
{
    class TrappingRainingWater
    {
        static void Main(string[] args)
        {
            int[] height;
            height = new int[] {2,2,2,2,2};
            int length = height.Length;
            if (length == 0)
                return;
            int max_rightheight=0, max_leftheight=0;
            int left = 1, right = length - 2;
            int sum = 0;
            for(int i=1;i<length;i++)
            {
                if(height[left-1]<height[right+1])
                {
                    max_leftheight = Math.Max(max_leftheight, height[left-1]);
                    if(max_leftheight>height[left])
                    {
                        sum += (max_leftheight - height[left]);
                    }
                    left++;
                }
                else
                {
                    max_rightheight = Math.Max(max_rightheight, height[right + 1]);
                    if(max_rightheight>height[right])
                    {
                        sum += (max_rightheight - height[right]);
                    }
                    right--;
                }
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
