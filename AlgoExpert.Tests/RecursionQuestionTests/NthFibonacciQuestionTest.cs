using AlgoExpert.Questions.RecursionQuestions;

namespace AlgoExpert.Tests.RecursionQuestionTests
{
    public class NthFibonacciQuestionTest
    {
        [Test]
        public void Test()
        {
            Assert.That(NthFibonacciQuestion.GetNthFib1(6), Is.EqualTo(5));
        }

        [Test]
        public void TestNthFibonacciSolution2()
        {
            Assert.That(NthFibonacciQuestion.GetNthFib2(6), Is.EqualTo(5));
        }

        [Test]
        public void TestNthFibonacciSolution3()
        {
            Assert.That(NthFibonacciQuestion.GetNthFib3(6), Is.EqualTo(5));
        }
    }
}
