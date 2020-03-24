using System;

namespace FindMinInRotatedSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            nums = new int[] {3,2,1};
            int left = 0;
            int right = nums.Length - 1;
            int mid = left + (right - left) / 2;
            if(nums[left]<=nums[right])
            {
                Console.WriteLine("{0}", nums[0]);
                return;
            }
            while (left <= right)
            {
                    if(mid==0&&nums[mid]>nums[mid+1])
                    {
                       Console.WriteLine("{0}", nums[mid + 1]);
                       break;
                    }
                    else if (nums[mid] < nums[mid - 1])
                    {
                        Console.WriteLine("{0}", nums[mid]);
                        break;
                    }
                    else if (nums[mid] < nums[0])
                    {
                        right = mid - 1;
                    }
                    else if (nums[mid] > nums[0])
                    {
                        left = mid + 1;
                    }
                    mid = left + (right - left) / 2;
            }
        }
    }
}
