using AlgoExpert.Questions.BinaryTreeQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.BinaryTreeQuestionTests
{
    public class BinaryTreeDiameterQuestionTest
    {
        [Fact]
        public void TestCase1()
        {
            var root = new BinaryTree(1);
            root.left = new BinaryTree(3);
            root.left.left = new BinaryTree(7);
            root.left.left.left = new BinaryTree(8);
            root.left.left.left.left = new BinaryTree(9);
            root.left.right = new BinaryTree(4);
            root.left.right.right = new BinaryTree(5);
            root.left.right.right.right = new BinaryTree(6);
            root.right = new BinaryTree(2);
            var expected = 6;
            var actual = BinaryTreeDiameterQuestion.BinaryTreeDiameter(root);
            Assert.True(expected == actual);
        }
    }
}
