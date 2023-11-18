using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class BlackjackProbabilityQuestion
    {
        public static double BlackjackProbability1(int target, int startingHand)
        {
            Dictionary<int, double> memo = new Dictionary<int, double>();
            return Math.Round(calculateProbability1(target, startingHand, memo) * 1000f) / 1000f;
        }

        private static double calculateProbability1(int target, int startingHand, Dictionary<int, double> memo)
        {
            if (memo.ContainsKey(startingHand))
            {
                return memo[startingHand];
            }
            if (startingHand >= target - 4 && startingHand <= target)
            {
                return 0;
            }
            else if (startingHand > target)
            {
                return 1;
            }

            double totalProbability = 0;
            for (int i = 1; i <= 10; i++)
            {
                totalProbability += .1 * calculateProbability1(target, startingHand + i, memo);
            }

            memo[startingHand] = totalProbability;
            return totalProbability;
        }
    }
}
