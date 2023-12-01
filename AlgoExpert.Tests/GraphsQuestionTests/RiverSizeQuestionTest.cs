using AlgoExpert.Questions.GraphsQuestions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.GraphsQuestionTests
{
    public class RiverSizeQuestionTest
    {
        [Test]
        public void TestCase1()
        {
            int[,] input =
            {
                { 1, 0, 0, 1, 0 },
                { 1, 0, 1, 0, 0 },
                { 0, 0, 1, 0, 1},
                { 1, 0, 1, 0, 1},
                { 1, 0, 1, 1, 0 }
            };

            int[] expected = { 1, 2, 2, 2, 5 };
            List<int> output = RiverSizesQuestion.RiverSizes(input);
            output.Sort();
            Assert.IsTrue(compare(output, expected));
        }

        private bool? compare(List<int> arr1, int[] arr2)
        {
            if (arr1.Count != arr2.Length)
            {
                return false;
            }
            for (int i = 0; i < arr1.Count; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
