using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class ProductSumQuestion
    {
        // O(n) time || O(d) space - where n is the total number of elements in array,
        // including sub-elements, and d is the greatest depth of "speical" array in array
        public static int ProductSum1(List<object> array)
        {
            return ProductSum1Helper(array, 1);
        }

        private static int ProductSum1Helper(List<object> array, int multiplier)
        {
            int sum = 0;
            foreach (object el in array)
            {
                if (el is IList<object>)
                {
                    sum += ProductSum1Helper((List<object>)el, multiplier + 1);
                }
                else
                {
                    sum += (int)el;
                }
            }


            return sum * multiplier;
        }
    }
}
