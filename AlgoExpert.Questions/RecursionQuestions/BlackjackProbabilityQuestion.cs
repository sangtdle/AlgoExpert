using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class BlackjackProbabilityQuestion
    {
        // O (t - s) time | O (t - s) space where t is the target and s is the starting hand
        public static double BlackjackProbability1(int target, int startingHand)
        {
            Dictionary<int, double> memo = new Dictionary<int, double>();

            return Math.Round(BlackjackProbability1Helper(startingHand, target, memo) * 1000f)/ 1000f;
        }

        private static double BlackjackProbability1Helper(int currentHand, int target, Dictionary<int, double> memo)
        {
            if (memo.ContainsKey(currentHand))
            {
                return memo[currentHand];
            }

            if (currentHand > target)
            {
                return 1;
            }
            if (currentHand >= target - 4)
            {
                return 0;
            }

            double totalProbability = 0;
            for (int drawnCard = 1; drawnCard <= 10; drawnCard++)
            {
                totalProbability += .1 * BlackjackProbability1Helper(currentHand + drawnCard, target, memo);
            }

            memo[currentHand] = totalProbability;
            return totalProbability;
        }
    }
}
