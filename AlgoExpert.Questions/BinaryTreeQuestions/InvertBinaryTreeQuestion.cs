using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.BinaryTreeQuestions
{
    public class InvertBinaryTreeQuestion
    {
        public static void InvertBinaryTree1(BinaryTree tree)
        {
            if (tree == null) return;
            swapLeftAndRight(tree);
            InvertBinaryTree1(tree.left);
            InvertBinaryTree1(tree.right);
        }

        public static void InvertBinaryTree2(BinaryTree tree)
        {
            Queue<BinaryTree> queue = new Queue<BinaryTree>();
            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                BinaryTree current = queue.Dequeue();

                if (current == null) continue;

                swapLeftAndRight(current);

                if (current.left != null) 
                {
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
        }

        public static void InvertBinaryTree3(BinaryTree tree)
        {
            List<BinaryTree> queue = new List<BinaryTree>();
            queue.Add(tree);
            int index = 0;

            while (index < queue.Count)
            {
                BinaryTree current = queue[index];

                if (current == null) continue;

                swapLeftAndRight(current);

                if (current.left != null)
                {
                    queue.Add(current.left);
                }
                if (current.right != null)
                {
                    queue.Add(current.right);
                }
                index++;
            }
        }

        private static void swapLeftAndRight(BinaryTree tree)
        {
            BinaryTree temp = tree.left;
            tree.left = tree.right;
            tree.right = temp;
        }
    }
}
