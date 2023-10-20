using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class StaircaseTraversalQuestion
    {
        // O(k^n) time | O(n) space - where n is the height of the staircase and k is
        // the number of allowed steps
        public static int StaircaseTraversal1(int height, int maxSteps)
        {
            return NumberOfWaysToTop(height, maxSteps);
        }

        private static int NumberOfWaysToTop(int height, int maxSteps)
        {
            if (height == 1 || height == 0)
            {
                return 1;
            }

            int numberOfWays = 0;
            for (int step = 1; step <= Math.Min(height, maxSteps); step++)
            {
                numberOfWays += StaircaseTraversal1(height - step, maxSteps);
            }

            return numberOfWays;
        }

        // O(k^n*) time | O(n) space - where n is the height of the staircase and k is
        // the number of allowed steps
        public static int StaircaseTraversal2(int height, int maxSteps)
        {
            Dictionary<int, int> memoize = new Dictionary<int, int>();
            memoize.Add(0, 1);
            memoize.Add(1, 1);

            return StaircaseTraversal2Helper(height, maxSteps, memoize);
        }

        // O(k*n) time | O(n) space - where n is the height of the staircase and k is
        // the number of allowed steps
        private static int StaircaseTraversal2Helper(int height, int maxSteps, Dictionary<int, int> memoize)
        {

            if (memoize.ContainsKey(height))
            {
                return memoize[height];
            }

            int numberOfWays = 0;
            for (int step = 1; step <= Math.Min(height, maxSteps); step++)
            {
                numberOfWays += StaircaseTraversal2Helper(height - step, maxSteps, memoize);
            }

            memoize.Add(height, numberOfWays);

            return numberOfWays;
        }

        // O(n*l) time | O(n) space where n is the height of the stair case and
        // k is the number of allowed steps
        public static int StaircaseTraversal3(int height, int maxSteps)
        {
            int[] waysToTop = new int[height + 1];
            waysToTop[0] = 1;
            waysToTop[1] = 1;

            for (int currentHeight = 2; currentHeight <= height; currentHeight++)
            {
                int step = 1;
                while (step <= currentHeight && step <= maxSteps)
                {
                    waysToTop[currentHeight] += waysToTop[currentHeight - step];
                    step++;
                }
            }

            return waysToTop[height];
        }

        // O(n) time | O(n) space where n is the height of the stair case
        public static int StaircaseTraversal4(int height, int maxSteps)
        {
            int currentNumberOfWays = 0;
            List<int> waysToTop = new List<int>();
            waysToTop[0] = 1;

            for (int currentHeight = 1;  currentHeight <= height; currentHeight++)
            {
                int startOfWindow = currentHeight - maxSteps - 1;
                int endOfWindow = currentHeight - 1;

                if (startOfWindow >= 0)
                {
                    currentNumberOfWays -= waysToTop[startOfWindow];
                }

                currentNumberOfWays += waysToTop[endOfWindow];
                waysToTop.Add(currentNumberOfWays);
            }

            return waysToTop[height];
        }
    }
}
