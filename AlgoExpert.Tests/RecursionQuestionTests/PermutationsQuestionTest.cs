using AlgoExpert.Questions.RecursionQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.RecursionQuestionTests
{
    public class PermutationsQuestionTest
    {
        [Test]
        public void TestGetPeurmutations1()
        {
            List<int> input = new List<int>() { 1, 2, 3 };
            List<List<int>> perms = PermutationsQuestion.GetPermutations1(input);
            Assert.IsTrue(perms.Count == 6);
            Assert.IsTrue(Contains(perms, new List<int>() { 1, 2, 3 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 1, 3, 2 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 2, 1, 3 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 2, 3, 1 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 3, 1, 2 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 3, 2, 1 }));
        }

        [Test]
        public void TestGetPeurmutations2()
        {
            List<int> input = new List<int>() { 1, 2, 3 };
            List<List<int>> perms = PermutationsQuestion.GetPermutations2(input);
            Assert.IsTrue(perms.Count == 6);
            Assert.IsTrue(Contains(perms, new List<int>() { 1, 2, 3 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 1, 3, 2 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 2, 1, 3 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 2, 3, 1 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 3, 1, 2 }));
            Assert.IsTrue(Contains(perms, new List<int>() { 3, 2, 1 }));
        }

        public bool Contains(List<List<int>> arr1, List<int> arr2)
        {
            foreach (List<int> subArray in arr1)
            {
                if (subArray.SequenceEqual(arr2))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
