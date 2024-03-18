using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.BinaryTreeQuestions
{
    public class BranchSumsQuestion
    {
        public static List<int> BranchSums(BinaryTree root)
        {
            // Write your code here.
            List<int> branchSums = new List<int>();
            BranchSumsHelper(root, 0, branchSums);
            return branchSums;
        }

        private static void BranchSumsHelper(BinaryTree node, int runningSum, List<int> branchSums)
        {
            if (node == null) return;

            runningSum = runningSum + node.value;

            if (node.left == null && node.right == null)
            {
                branchSums.Add(runningSum);
                return;
            }
            BranchSumsHelper(node.left, runningSum, branchSums);
            BranchSumsHelper(node.right, runningSum, branchSums);

        }
    }
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
}
