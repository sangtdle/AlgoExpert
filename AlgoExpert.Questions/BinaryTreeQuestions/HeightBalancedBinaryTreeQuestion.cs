using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.BinaryTreeQuestions
{
    public class HeightBalancedBinaryTreeQuestion
    {
        public static bool HeightBalancedBinaryTree(BinaryTree binaryTree)
        {
            TreeInfo treeInfo = getTreeInfo(binaryTree);
            return treeInfo.isBalanced;
        }

        private static TreeInfo getTreeInfo(BinaryTree node)
        {
            if (node == null)
            {
                return new TreeInfo(true, -1);
            }

            TreeInfo leftSubTreeInfo = getTreeInfo(node.left);
            TreeInfo rightSubTreeInfo = getTreeInfo(node.right);

            bool isBalanced = leftSubTreeInfo.isBalanced && rightSubTreeInfo.isBalanced
                && Math.Abs(leftSubTreeInfo.height - rightSubTreeInfo.height) <= 1;

            int height = Math.Max(leftSubTreeInfo.height, rightSubTreeInfo.height) + 1;

            return new TreeInfo(isBalanced, height);
        }

        class TreeInfo
        {
            public bool isBalanced;
            public int height;

            public TreeInfo(bool isBalanced, int height)
            {
                this.isBalanced = isBalanced;
                this.height = height;
            }
        }
    }
}
