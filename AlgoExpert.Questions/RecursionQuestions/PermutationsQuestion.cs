using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class PermutationsQuestion
    {
        // Upper bound: O(N^2*n!) time ! O(n*n!) space
        // Roughly: O(N*n!) time ! O(n*n!) space
        public static List<List<int>> GetPermutations1(List<int> array)
        {
            // Write your code here.
            List<List<int>> permutations = new List<List<int>>();
            GerPermutation1(array, new List<int>(), permutations);
            return permutations;
        }

        private static void GerPermutation1(List<int> array, List<int> currentPermutation,List<List<int>> permutations)
        {
            if (array.Count == 0 && currentPermutation.Count > 0)
            {
                permutations.Add(currentPermutation);
            } else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    List<int> newArray = new List<int>(array);
                    newArray.RemoveAt(i);
                    List<int> newPerm = new List<int>(currentPermutation);
                    newPerm.Add(array[i]);
                    GerPermutation1(newArray, newPerm, permutations);
                }
            }
        }



        // Upper bound: O(N^2*n!) time ! O(n*n!) space
        // Roughly: O(N*n!) time ! O(n*n!) space
        public static List<List<int>> GetPermutations2(List<int> array)
        {
            // Write your code here.
            List<List<int>> permutations = new List<List<int>>();
            GetPermutation2Helper(0, array, permutations);
            return permutations;
        }

        private static void GetPermutation2Helper(int i, List<int> array, List<List<int>> permutations)
        {
            if (i == array.Count - 1)
            {
                permutations.Add(new List<int>(array));
            }
            else
            {
                for (int j = i; j < array.Count; j++)
                {
                    Swap(array, i, j);
                    GetPermutation2Helper(i + 1, array, permutations);
                    Swap(array, i, j);
                }
            }
        }

        private static void Swap(List<int> array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
