using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.BinaryTreeQuestions
{
    public class MergeBinaryTreesQuestion
    {
        public static BinaryTree MergeBinaryTrees1(BinaryTree tree1, BinaryTree tree2)
        {
            if (tree1 == null) return tree2;
            if (tree2 == null) return tree1;

            tree1.value = tree1.value + tree2.value;

            tree1.left = MergeBinaryTrees1(tree1.left, tree2.left);
            tree1.right = MergeBinaryTrees1(tree1.right, tree2.right);

            return tree1;
        }

        public static BinaryTree MergeBinaryTrees2(BinaryTree tree1, BinaryTree tree2)
        {
            // Write your code here.
            if (tree1 == null) return tree2;

            Stack<BinaryTree> stack1 = new Stack<BinaryTree>();
            stack1.Push(tree1);
            Stack<BinaryTree> stack2 = new Stack<BinaryTree>();
            stack2.Push(tree2);

            while (stack1.Count != 0)
            {
                BinaryTree nodeTree1 = stack1.Pop();
                BinaryTree nodeTree2 = stack2.Pop();

                if (nodeTree2 == null) continue;

                nodeTree1.value = nodeTree1.value + nodeTree2.value;

                if (nodeTree1.left == null)
                {
                    nodeTree1.left = nodeTree2.left;
                }
                else
                {
                    stack1.Push(nodeTree1.left);
                    stack2.Push(nodeTree2.left);
                }


                if (nodeTree1.right == null)
                {
                    nodeTree1.right = nodeTree2.right;
                }
                else
                {
                    stack1.Push(nodeTree1.right);
                    stack2.Push(nodeTree2.right);
                }
            }
            return tree1;
        }
    }
}
