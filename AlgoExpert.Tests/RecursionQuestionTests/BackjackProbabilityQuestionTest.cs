using AlgoExpert.Questions.RecursionQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.RecursionQuestionTests
{
    public class BackjackProbabilityQuestionTest
    {
        [Test]
        public void TestBackjackProbability1()
        {
            int target = 21;
            int startingHand = 15;
            double expected = 0.45;
            double actual = BlackjackProbabilityQuestion.BlackjackProbability1(target, startingHand);
            Assert.IsTrue(expected == actual);
        }
    }
}
