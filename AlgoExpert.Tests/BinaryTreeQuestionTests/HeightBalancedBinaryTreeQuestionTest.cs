using AlgoExpert.Questions.BinaryTreeQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.BinaryTreeQuestionTests
{
    public class HeightBalancedBinaryTreeQuestionTest
    {
        [Fact]
        public void TestCase1()
        {
            BinaryTree root = new BinaryTree(1);
            root = new BinaryTree(1);
            root.left = new BinaryTree(2);
            root.right = new BinaryTree(3);
            root.left.left = new BinaryTree(4);
            root.left.right = new BinaryTree(5);
            root.right.right = new BinaryTree(6);
            root.left.right.left = new BinaryTree(7);
            root.left.right.right = new BinaryTree(8);
            bool expected = true;
            var actual = HeightBalancedBinaryTreeQuestion.HeightBalancedBinaryTree(root);
            Assert.True(expected == actual);
        }
    }
}
