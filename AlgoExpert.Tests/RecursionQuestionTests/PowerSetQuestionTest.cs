using AlgoExpert.Questions.RecursionQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.RecursionQuestionTests
{
    public class PowerSetQuestionTest
    {
        [Test]
        public void TestPowerSetQuestionTest1()
        {
            List<int> input = new List<int>() { 1, 2, 3 };
            List<List<int>> subsets = PowerSetQuestion.Powerset1(input);

            Assert.IsTrue(subsets.Count == 8);
            Assert.IsTrue(Contains(subsets, new int[] { }));
            Assert.IsTrue(Contains(subsets, new int[] { 1 }));
            Assert.IsTrue(Contains(subsets, new int[] { 2 }));
            Assert.IsTrue(Contains(subsets, new int[] { 1, 2 }));
            Assert.IsTrue(Contains(subsets, new int[] { 1, 3 }));
            Assert.IsTrue(Contains(subsets, new int[] { 1, 2, 3 }));
        }

        [Test]
        public void TestPowerSetQuestionTest2()
        {
            List<int> input = new List<int>() { 1, 2, 3 };
            List<List<int>> subsets = PowerSetQuestion.Powerset2(input);

            Assert.IsTrue(subsets.Count == 8);
            Assert.IsTrue(Contains(subsets, new int[] { }));
            Assert.IsTrue(Contains(subsets, new int[] { 1 }));
            Assert.IsTrue(Contains(subsets, new int[] { 2 }));
            Assert.IsTrue(Contains(subsets, new int[] { 1, 2 }));
            Assert.IsTrue(Contains(subsets, new int[] { 1, 3 }));
            Assert.IsTrue(Contains(subsets, new int[] { 1, 2, 3 }));
        }

        public bool Contains(List<List<int>> arr1, int[] arr2)
        {
            foreach (List<int> subArr in arr1)
            {
                subArr.Sort();
                if (compare(subArr, arr2))
                {
                    return true;
                }
            }
            return false;
        }

        public bool compare(List<int> arr1, int[] arr2)
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
