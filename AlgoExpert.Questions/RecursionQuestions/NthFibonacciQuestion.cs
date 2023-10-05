using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class NthFibonacciQuestion
    {
        public static int GetNthFib1(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;

            return GetNthFib1(n-1) + GetNthFib1(n-2);
        }

        public static int GetNthFib2(int n)
        {
            Dictionary<int, int> memoirze = new Dictionary<int, int>();
            memoirze.Add(1, 0);
            memoirze.Add(2, 1);

            return GetNthFib2Helper(n, memoirze);
        }

        private static int GetNthFib2Helper(int n, Dictionary<int, int> memoirze)
        {
            if (!memoirze.ContainsKey(n))
            {
                memoirze.Add(n, GetNthFib2Helper(n - 1, memoirze) + GetNthFib2Helper(n - 2, memoirze));
            }
            return memoirze[n];
        }

        public static int GetNthFib3(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;

            int[] nums = { 0, 1 };
            int i = 3;
            while (i <= n)
            {
                int newValue = nums[0] + nums[1];
                nums[0] = nums[1];
                nums[1] = newValue;
                i++;
            }
            return nums[1];
        }
    }
}
