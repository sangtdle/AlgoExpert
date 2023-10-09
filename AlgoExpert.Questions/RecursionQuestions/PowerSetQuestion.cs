using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class PowerSetQuestion
    {
        public static List<List<int>> Powerset1(List<int> array)
        {
            List<List<int>> subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            foreach (int ele in array)
            {
                int length = subsets.Count;
                for (int i = 0; i < length; i++)
                {
                    List<int> currentSubset = new List<int>(subsets[i]);
                    currentSubset.Add(ele);
                    subsets.Add(currentSubset);
                }
            }

            return subsets;
        }

        public static List<List<int>> Powerset2(List<int> array)
        {
            return PowerSet2Helper(array, array.Count - 1);
        }

        private static List<List<int>> PowerSet2Helper(List<int> array, int idx)
        {
            if (idx < 0)
            {
                List<List<int>> emptyset = new List<List<int>>();
                emptyset.Add(new List<int>());
                return emptyset;
            }

            int ele = array[idx];
            List<List<int>> subsets = PowerSet2Helper(array, idx - 1);
            int length = subsets.Count;
            for (int i = 0; i < length; i++)
            {
                List<int> currentSubset = new List<int>(subsets[i]);
                currentSubset.Add(ele);
                subsets.Add(currentSubset);
            }

            return subsets;
        }
    }
}
