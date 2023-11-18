using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.ArrayQuestions
{
    public class ValidateSubsequenceQuestion
    {
        public static bool solution(string x, string y)
        {
            int idxX = 0;
            int idxY = 0;

            while (idxX < x.Length && idxY < y.Length)
            {
                if (x[idxX] == y[idxY])
                {
                    idxY++;
                }
                idxX++;
            }

            // Write your code here.
            return idxY == y.Length;
        }
    }
}
