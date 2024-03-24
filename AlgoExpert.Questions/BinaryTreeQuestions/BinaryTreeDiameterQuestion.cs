using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.BinaryTreeQuestions
{
    public class BinaryTreeDiameterQuestion
    {
        public static int BinaryTreeDiameter(BinaryTree tree)
        {
            return getTreeInfo(tree).diameter;
        }

        private static TreeInfo getTreeInfo(BinaryTree tree)
        {
            if (tree == null) return new TreeInfo(0, 0);

            TreeInfo leftTreeInfo = getTreeInfo(tree.left);
            TreeInfo rightTreeInfo = getTreeInfo(tree.right);

            int longestPathThroughRoot = leftTreeInfo.height + rightTreeInfo.height;
            int maxDiameterSoFar = Math.Max(leftTreeInfo.diameter, rightTreeInfo.diameter);

            int currentDiameter = Math.Max(longestPathThroughRoot, maxDiameterSoFar);
            int currentHeight = Math.Max(leftTreeInfo.height, rightTreeInfo.height) + 1;

            return new TreeInfo(currentDiameter, currentHeight);
        }

        class TreeInfo
        {
            public int diameter;
            public int height;

            public TreeInfo(int diameter, int height)
            {
                this.diameter = diameter;
                this.height = height;
            }
        }
    }
}
