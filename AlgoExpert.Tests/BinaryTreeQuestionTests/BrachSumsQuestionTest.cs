using AlgoExpert.Questions.BinaryTreeQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace AlgoExpert.Tests.BinaryTreeQuestionTests
{
    public class BrachSumsQuestionTest
    {
        [Fact]
        public void TestCase1()
        {
            TestBinaryTree tree = new TestBinaryTree(1).Insert(new List<int> { 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            List<int> expected = new List<int>() { 15, 16, 18, 10, 11 };
            Assert.True(BranchSumsQuestion.BranchSums(tree).SequenceEqual(expected));
        }
    }


    public class TestBinaryTree : BinaryTree
    {
        public TestBinaryTree(int value) : base(value) { }

        public TestBinaryTree Insert(List<int> values)
        {
            return Insert(values, 0);
        }

        public TestBinaryTree Insert(List<int> values, int i)
        {
            if (i >= values.Count) return null;

            List<TestBinaryTree> queue = new List<TestBinaryTree>();
            queue.Add(this);
            while (queue.Count > 0)
            {
                TestBinaryTree current = queue[0];
                queue.RemoveAt(0);
                if (current.left == null)
                {
                    current.left = new TestBinaryTree(values[i]);
                    break;
                }
                queue.Add((TestBinaryTree)current.left);
                if (current.right == null)
                {
                    current.right = new TestBinaryTree(values[i]);
                    break;
                }
                queue.Add((TestBinaryTree)current.right);
            }
            Insert(values, i + 1);
            return this;
        }
    }
}