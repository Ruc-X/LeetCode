using System;
using System.Collections;
using System.Collections.Generic;
namespace CS
{
    class Program
    {
        static void CombinationSums(int[] candidates, int target, IList<int> list, IList<IList<int>> aList)
        {
            for (int i = 0; i < candidates.Length; i++)
            {
                if ((list.Count == 0 || candidates[i] >= list[list.Count - 1]))
                {
                    if (target - candidates[i] > 0)
                    {
                        list.Add(candidates[i]);
                        CombinationSums(candidates, target - candidates[i], list, aList);
                    }
                    else if (target - candidates[i] == 0)
                    {
                        list.Add(candidates[i]);
                        IList<int> list1;
                        list1 = new List<int>(list);
                        aList.Add(list1);
                        list.Remove(candidates[i]);
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (list.Count >= 1)
            {
                list.Remove(list[list.Count - 1]);
            }
        }
        static void Main(string[] args)
        {
            IList<int> list;
            IList<IList<int>> aList;
            list = new List<int>();
            aList = new List<IList<int>>();
            int[] candidates;
            candidates = new int[] { 2, 3, 5};
            int target = 8;
            Array.Sort(candidates);
            CombinationSums(candidates, target, list, aList);
            for (int i = 0; i < aList.Count; i++)
            {
                for (int j = 0; j < aList[i].Count; j++)
                {
                    Console.Write("{0} ", aList[i][j]);
                }
                Console.Write("\n");
            }
        }
    }
}
