using System;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            int k = 8;
            nums = new int[]{0, 0, 1, 2, 4, 2, 2, 3, 1, 4};
            int left=QuickSort(nums, 0, nums.Length - 1,k);
            for(int i=0;i<=left;i++)
            {
                Console.Write("{0}", nums[i]);
            }
            Console.WriteLine();
        }
        static public int QuickSort(int []nums,int f,int l,int k)
        {
            if (f < l)
            {
                int left = f;
                int right = l;
                int tmp = nums[f];
                while (left < right)
                {
                    while (left < right && nums[right] >= tmp)
                        right--;
                    nums[left] = nums[right];
                    while (left < right && nums[left] <= tmp)
                        left++;
                    nums[right] = nums[left];
                    nums[left] = tmp;
                }
                if(left+1-f<k)
                {
                    left=QuickSort(nums, left + 1, l, k - left - 1+f);
                    return left;
                }
                else if(left+1-f>k)
                {
                    left=QuickSort(nums, f,left-1,k);
                    return left;
                }
                else
                return left;
            }
            return f;
        }
    }
}
