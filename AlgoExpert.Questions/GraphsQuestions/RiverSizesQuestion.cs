using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.GraphsQuestions
{
    public class RiverSizesQuestion
    {
        public static List<int> RiverSizes(int[,] matrix)
        {
            List<int> sizes = new List<int>();
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (visited[i, j])
                    {
                        continue;
                    }
                    TraverseNode(i, j, matrix, visited, sizes);
                }
            }

            return sizes;
        }

        private static void TraverseNode(int i, int j, int[,] matrix, bool[,] visited, List<int> sizes)
        {
            int currentSize = 0;
            Stack<int[]> nodeToExplore = new Stack<int[]>();
            nodeToExplore.Push(new int[] { i, j});

            while (nodeToExplore.Count != 0)
            {
                int[] currentNode = nodeToExplore.Pop();
                i = currentNode[0];
                j = currentNode[1];

                if (visited[i, j])
                {
                    continue;
                }
                visited[i, j] = true;

                if (matrix[i, j] == 0)
                {
                    continue;
                }

                currentSize++;
                List<int[]> unVisitedNodes = GetUnvisitedNodes(i, j, matrix, visited);
                foreach (var  node in unVisitedNodes)
                {
                    nodeToExplore.Push(node);
                }
            }

            if (currentSize > 0)
            {
                sizes.Add(currentSize);
            }

        }

        private static List<int[]> GetUnvisitedNodes(int i, int j, int[,] matrix, bool[,] visited)
        {
            List<int[]> unVisitedNodes = new List<int[]>();

            if (j > 0 && !visited[i, j - 1])
            {
                unVisitedNodes.Add(new int[] { i, j- 1 });
            }
            if (i > 0 && !visited[i - 1, j])
            {
                unVisitedNodes.Add(new int[] { i - 1, j });
            }

            if (j < matrix.GetLength(1) - 1 && !visited[i, j + 1])
            {
                unVisitedNodes.Add(new int[] { i, j + 1 });
            }

            if (i < matrix.GetLength(0) - 1 && !visited[i + 1, j])
            {
                unVisitedNodes.Add(new int[] { i + 1, j });
            }

            return unVisitedNodes;
        }
    }
}
