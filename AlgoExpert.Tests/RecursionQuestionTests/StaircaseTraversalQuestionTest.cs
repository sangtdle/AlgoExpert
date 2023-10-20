using AlgoExpert.Questions.RecursionQuestions;

namespace AlgoExpert.Tests.RecursionQuestionTests
{
    public class StaircaseTraversalQuestionTest
    {
        [Test]
        public void TestStaircaseTraversal1()
        {
            int stairs = 4;
            int maxSteps = 2;
            int expected = 5;
            int actual = StaircaseTraversalQuestion.StaircaseTraversal1(stairs, maxSteps);
            Assert.IsTrue(expected == actual);
        }

        [Test]
        public void TestStaircaseTraversal2()
        {
            int stairs = 4;
            int maxSteps = 2;
            int expected = 5;
            int actual = StaircaseTraversalQuestion.StaircaseTraversal2(stairs, maxSteps);
            Assert.IsTrue(expected == actual);
        }

        [Test]
        public void TestStaircaseTraversal3()
        {
            int stairs = 4;
            int maxSteps = 2;
            int expected = 5;
            int actual = StaircaseTraversalQuestion.StaircaseTraversal3(stairs, maxSteps);
            Assert.IsTrue(expected == actual);
        }

        [Test]
        public void TestStaircaseTraversal4()
        {
            int stairs = 4;
            int maxSteps = 2;
            int expected = 5;
            int actual = StaircaseTraversalQuestion.StaircaseTraversal4(stairs, maxSteps);
            Assert.IsTrue(expected == actual);
        }
    }
}
