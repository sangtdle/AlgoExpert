using AlgoExpert.Questions.BinaryTreeQuestions;

namespace AlgoExpert.Tests.BinaryTreeQuestionTests
{
    public class FindSuccessorQuestionTest
    {
        [Fact]
        public void TestCase1()
        {
            BinaryTree1 root = new BinaryTree1(1);
            root.left = new BinaryTree1(2);
            root.left.parent = root;
            root.right = new BinaryTree1(3);
            root.right.parent = root;
            root.left.left = new BinaryTree1(4);
            root.left.left.parent = root.left;
            root.left.right = new BinaryTree1(5);
            root.left.right.parent = root.left;
            root.left.left.left = new BinaryTree1(6);
            root.left.left.left.parent = root.left.left;
            BinaryTree1 node = root.left.right;
            BinaryTree1 expected = root;
            BinaryTree1 actual = FindSuccessorQuestion.FindSuccessor1(root, node);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestCase2()
        {
            BinaryTree1 root = new BinaryTree1(1);
            root.left = new BinaryTree1(2);
            root.left.parent = root;
            root.right = new BinaryTree1(3);
            root.right.parent = root;
            root.left.left = new BinaryTree1(4);
            root.left.left.parent = root.left;
            root.left.right = new BinaryTree1(5);
            root.left.right.parent = root.left;
            root.left.left.left = new BinaryTree1(6);
            root.left.left.left.parent = root.left.left;
            BinaryTree1 node = root.left.right;
            BinaryTree1 expected = root;
            BinaryTree1 actual = FindSuccessorQuestion.FindSuccessor2(root, node);
            Assert.Equal(expected, actual);
        }
    }
}
