using AlgoExpert.Questions.BinaryTreeQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.BinaryTreeQuestionTests
{
    public class MergeBinaryTreesQuestionTest
    {
        [Fact]
        public void TestCase1()
        {

            BinaryTree tree1 = new BinaryTree(1);
            tree1.left = new BinaryTree(3);
            tree1.left.left = new BinaryTree(7);
            tree1.left.right = new BinaryTree(4);
            tree1.right = new BinaryTree(2);

            BinaryTree tree2 = new BinaryTree(1);
            tree2.left = new BinaryTree(5);
            tree2.left.left = new BinaryTree(2);
            tree2.right = new BinaryTree(9);
            tree2.right.left = new BinaryTree(7);
            tree2.right.right = new BinaryTree(6);

            BinaryTree expected = new BinaryTree(2);
            expected.left = new BinaryTree(8);
            expected.left.left = new BinaryTree(9);
            expected.left.right = new BinaryTree(4);
            expected.right = new BinaryTree(11);
            expected.right.left = new BinaryTree(7);
            expected.right.right = new BinaryTree(6);

            BinaryTree actual = MergeBinaryTreesQuestion.MergeBinaryTrees1(tree1, tree2);

            Assert.True(areTreesEqual(expected, actual));
        }

        [Fact]
        public void TestCase2()
        {

            BinaryTree tree1 = new BinaryTree(1);
            tree1.left = new BinaryTree(3);
            tree1.left.left = new BinaryTree(7);
            tree1.left.right = new BinaryTree(4);
            tree1.right = new BinaryTree(2);

            BinaryTree tree2 = new BinaryTree(1);
            tree2.left = new BinaryTree(5);
            tree2.left.left = new BinaryTree(2);
            tree2.right = new BinaryTree(9);
            tree2.right.left = new BinaryTree(7);
            tree2.right.right = new BinaryTree(6);

            BinaryTree expected = new BinaryTree(2);
            expected.left = new BinaryTree(8);
            expected.left.left = new BinaryTree(9);
            expected.left.right = new BinaryTree(4);
            expected.right = new BinaryTree(11);
            expected.right.left = new BinaryTree(7);
            expected.right.right = new BinaryTree(6);

            BinaryTree actual = MergeBinaryTreesQuestion.MergeBinaryTrees2(tree1, tree2);

            Assert.True(areTreesEqual(expected, actual));
        }


        public bool areTreesEqual(
          BinaryTree tree1, BinaryTree tree2
        )
        {
            if (tree1 == null && tree2 == null) return true;

            if (tree1 == null && tree2 != null)
            {
                return false;
            }
            else if (tree1 != null && tree2 == null)
            {
                return false;
            }

            if (tree1.value != tree2.value) return false;
            return areTreesEqual(tree1.left, tree2.left) &&
                   areTreesEqual(tree1.right, tree2.right);
        }
    }
}
