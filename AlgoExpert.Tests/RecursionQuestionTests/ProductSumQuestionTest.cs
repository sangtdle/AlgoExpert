using AlgoExpert.Questions.RecursionQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.RecursionQuestionTests
{
    public class ProductSumQuestionTest
    {
        [Test]
        public void TestProductSum1()
        {
            List<object> test = new List<object>() {
              5,
              2,
              new List<object>() { 7, -1 },
              3,
              new List<object>() {
                6,
                new List<object>() { -13, 8 },
                4,
              },
            };
            var actualResult = ProductSumQuestion.ProductSum1(test);

            Assert.IsTrue(actualResult == 12);
        }
    }
}
