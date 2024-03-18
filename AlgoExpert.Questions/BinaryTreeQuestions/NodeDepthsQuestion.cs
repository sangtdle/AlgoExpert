using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.BinaryTreeQuestions
{
    public class NodeDepthsQuestion
    {
        public static int NodeDepths1(BinaryTree root)
        {
            return nodeDepthsHelper(root, 0);
        }

        private static int nodeDepthsHelper(BinaryTree node, int depth)
        {
            if (node == null) return 0;
            return depth + nodeDepthsHelper(node.left, depth + 1) + nodeDepthsHelper(node.right, depth + 1);
        }

        public static int NodeDepths2(BinaryTree root)
        {
            int sumOfDepths = 0;
            Stack<Level> stack = new Stack<Level>();
            stack.Push(new Level(root, 0));

            while (stack.Count > 0)
            {
                Level top = stack.Pop();

                BinaryTree node = top.root;
                int depth = top.depth;
                if (node == null) continue;

                sumOfDepths += depth;
                stack.Push(new Level(node.left, depth + 1));
                stack.Push(new Level(node.right, depth + 1));
            }

            return sumOfDepths;
        }
    }

    public class Level
    {
        public BinaryTree root;
        public int depth;

        public Level(BinaryTree root, int depth)
        {
            this.root = root;
            this.depth = depth;
        }
    }
}
