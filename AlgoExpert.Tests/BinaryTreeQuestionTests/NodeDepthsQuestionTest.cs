using AlgoExpert.Questions.BinaryTreeQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.BinaryTreeQuestionTests
{
    public class NodeDepthsQuestionTest
    {
        [Fact]
        public void TestCase1()
        {
            var root = new BinaryTree(1);
            root.left = new BinaryTree(2);
            root.left.left = new BinaryTree(4);
            root.left.left.left = new BinaryTree(8);
            root.left.left.right = new BinaryTree(9);
            root.left.right = new BinaryTree(5);
            root.right = new BinaryTree(3);
            root.right.left = new BinaryTree(6);
            root.right.right = new BinaryTree(7);
            int actual = NodeDepthsQuestion.NodeDepths1(root);
            Assert.Equal(16, actual);
        }

        [Fact]
        public void TestCase2()
        {
            var root = new BinaryTree(1);
            root.left = new BinaryTree(2);
            root.left.left = new BinaryTree(4);
            root.left.left.left = new BinaryTree(8);
            root.left.left.right = new BinaryTree(9);
            root.left.right = new BinaryTree(5);
            root.right = new BinaryTree(3);
            root.right.left = new BinaryTree(6);
            root.right.right = new BinaryTree(7);
            int actual = NodeDepthsQuestion.NodeDepths2(root);
            Assert.Equal(16, actual);
        }
    }
}
