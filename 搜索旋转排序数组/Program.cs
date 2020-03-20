using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            nums = new int[] { 4,5,6,7,0,1,2};
            int target = 0;
            int left = 0;
            int right = nums.Length - 1;
            int mid = left + (right + left) / 2;
            while (left <=right)
            {
                if (nums[mid] == target)
                {
                    Console.WriteLine("{0}", target);
                    return;
                }
                if (nums[mid] >= nums[left])
                {
                    if (nums[left] <= target && target <= nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (nums[right] >= target && nums[mid] <= target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                mid = left + (right - left) / 2;
            }
            return;
        }
    }
}
