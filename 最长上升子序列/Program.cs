using System;

namespace 最长上升子序列
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            int[] tails;
            nums=new int[] { 1, 3, 7, 2, 5, 6, 10,9,7 };
            tails = new int[nums.Length];
            int res=0;
            tails[0] = nums[0];
            for(int i=0;i<nums.Length;i++)
            {
                if (tails[res] < nums[i])
                {
                    tails[++res] = nums[i];
                }
                else
                {
                    int left = 0;
                    int right = res;
                    int mid = (left + right) / 2;
                    while (left < right)
                    {
                        if (tails[mid] < nums[i])
                        {
                            left = mid + 1;
                        }
                        else if (tails[mid] > nums[i])
                        {
                            right = mid - 1;
                        }
                        else
                        {
                            break;
                        }
                        mid = (left + right) / 2;
                    }
                    if (tails[mid] < nums[i])
                    {
                        tails[mid + 1] = nums[i];
                    }
                    else
                    {
                        tails[mid] = nums[i];
                    }
                }
            }
            for(int i=0;i<=res;i++)
            {
                Console.Write("{0}", tails[i]);
            }
            Console.WriteLine("\n{0}", res+1);
        }
    }
}
