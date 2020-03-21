using System;

namespace LeetCode
{
    class 在排序数组中找到查找元素的首尾
    {
        static void Main(string[] args)
        {
            int[] nums;
            nums = new int[] {2,4,7,10,13,15,15};
            int target = 15;
            int length = nums.Length;
            int f=-1, l=-1;
            int f_left=0, l_left=0;
            int l_right = length - 1, f_right=length-1;
            f = BoundaryBinartSearch(nums, target, f_left, f_right, true);
            if (f != -1)
            {
                l_left = f;
            }
            l = BoundaryBinartSearch(nums, target, l_left, l_right, false);
            Console.WriteLine("{0} {1}",f,l);
        }
        static int BoundaryBinartSearch(int[] nums, int target, int left, int right, bool IsLeft)
        {
            int mid = left + (right - left) / 2;
            while(left<=right)
            {
                if(nums[mid]==target)
                {
                    if(IsLeft)
                    {
                        if (mid == 0 || nums[mid - 1] < target)
                        {
                            return (mid);
                        }
                        else
                        {
                            right = mid - 1;
                        }
                    }
                    else
                    {
                        if (mid == nums.Length - 1 || nums[mid + 1] > target)
                        {
                            return(mid);
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
                mid = left + (right - left) / 2;
            }
            return (-1);
        }
    }
}
