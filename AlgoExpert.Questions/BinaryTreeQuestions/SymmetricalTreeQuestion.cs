using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.BinaryTreeQuestions
{
    public class SymmetricalTreeQuestion
    {
        public static bool SymmetricalTree1(BinaryTree tree)
        {
            Stack<BinaryTree> leftStack = new Stack<BinaryTree>();
            Stack<BinaryTree> rightStack = new Stack<BinaryTree>();

            leftStack.Push(tree.left);
            rightStack.Push(tree.right);

            while (leftStack.Count > 0 && rightStack.Count > 0)
            {
                BinaryTree leftNode = leftStack.Pop();
                BinaryTree rightNode = rightStack.Pop();

                if (leftNode == null && rightNode == null)
                {
                    continue;
                }

                if (leftNode != null && rightNode != null && leftNode.value != rightNode.value)
                {
                    return false;
                }

                leftStack.Push(leftNode.left);
                leftStack.Push(leftNode.right);

                rightStack.Push(rightNode.right);
                rightStack.Push(rightNode.left);

            }

            return leftStack.Count == 0 && rightStack.Count == 0;
        }

        public static bool SymmetricalTree2(BinaryTree tree)
        {
            return SymmetricalTreeHelper(tree.left, tree.right);
        }

        private static bool SymmetricalTreeHelper(BinaryTree left, BinaryTree right)
        {
            if (left != null && right != null)
            {
                return left.value == right.value && SymmetricalTreeHelper(left.left, right.right) && SymmetricalTreeHelper(left.right, right.left);
            }

            return left == right;
        }
    }
}
