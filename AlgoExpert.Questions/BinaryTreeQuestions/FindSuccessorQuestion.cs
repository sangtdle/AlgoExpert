using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.BinaryTreeQuestions
{
    public class BinaryTree1
    {
        public int value;
        public BinaryTree1 left = null;
        public BinaryTree1 right = null;
        public BinaryTree1 parent = null;

        public BinaryTree1(int value)
        {
            this.value = value;
        }
    }

    public class FindSuccessorQuestion
    {
        public static BinaryTree1 FindSuccessor1(BinaryTree1 tree, BinaryTree1 node)
        {
            List<BinaryTree1> inOrderTraversalOrder = new List<BinaryTree1>();
            getInOrderTraversalOrder(tree, inOrderTraversalOrder);

            for (int i = 0; i < inOrderTraversalOrder.Count; i++)
            {
                BinaryTree1 current = inOrderTraversalOrder[i];

                if (current != node) continue;

                if (i == inOrderTraversalOrder.Count - 1)
                {
                    return null;
                }

                return inOrderTraversalOrder[i + 1];
            }

            return null;
        }

        public static BinaryTree1 FindSuccessor2(BinaryTree1 tree, BinaryTree1 node)
        {
            if (node.right != null) return getMostLeftChild(node.right);
            return getMostRightParent(node); 
        }

        private static BinaryTree1 getMostLeftChild(BinaryTree1 node)
        {
            BinaryTree1 currentNode = node;

            while (currentNode.left != null)
            {
                currentNode = currentNode.left;
            }

            return currentNode;
        }

        private static BinaryTree1 getMostRightParent(BinaryTree1 node)
        {
            BinaryTree1 currentNode = node;

            while (currentNode.parent != null && currentNode.parent.right == currentNode)
            {
                currentNode = currentNode.parent;
            }

            return currentNode.parent;
        }

        private static void getInOrderTraversalOrder(BinaryTree1 node, List<BinaryTree1> inOrderTraversalOrder)
        {
            if (node == null) return;

            getInOrderTraversalOrder(node.left, inOrderTraversalOrder);
            inOrderTraversalOrder.Add(node);
            getInOrderTraversalOrder(node.right, inOrderTraversalOrder);
        }
    }
}
