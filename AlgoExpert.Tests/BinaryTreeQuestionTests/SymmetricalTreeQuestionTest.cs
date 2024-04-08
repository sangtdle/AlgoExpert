using AlgoExpert.Questions.BinaryTreeQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.BinaryTreeQuestionTests
{
    public class SymmetricalTreeQuestionTest
    {
        [Fact]
        public void TestCase1()
        {
            BinaryTree tree = new BinaryTree(10);
            tree.left = new BinaryTree(5);
            tree.right = new BinaryTree(5);
            tree.left.left = new BinaryTree(7);
            tree.left.right = new BinaryTree(9);
            tree.right.left = new BinaryTree(9);
            tree.right.right = new BinaryTree(7);
            var expected = true;
            var actual = SymmetricalTreeQuestion.SymmetricalTree1(tree);
            Assert.True(expected == actual);
        }

        [Fact]
        public void TestCase2()
        {
            BinaryTree tree = new BinaryTree(10);
            tree.left = new BinaryTree(5);
            tree.right = new BinaryTree(5);
            tree.left.left = new BinaryTree(7);
            tree.left.right = new BinaryTree(9);
            tree.right.left = new BinaryTree(9);
            tree.right.right = new BinaryTree(7);
            var expected = true;
            var actual = SymmetricalTreeQuestion.SymmetricalTree2(tree);
            Assert.True(expected == actual);
        }
    }
}
