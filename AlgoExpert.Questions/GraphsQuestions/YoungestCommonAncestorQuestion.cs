using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.GraphsQuestions
{
    public class YoungestCommonAncestorQuestion
    {
        public static AncestralTree GetYoungestCommonAncestor(AncestralTree topAncestor, AncestralTree descendantOne, AncestralTree descendantTwo)
        {
            int descendantOneDepth = GetDescendantDepth(topAncestor, descendantOne);
            int descendantTwoDepth = GetDescendantDepth(topAncestor, descendantTwo);
            if (descendantOneDepth < descendantTwoDepth)
            {
                return backtrackAncestor(descendantTwo, descendantOne, descendantTwoDepth - descendantOneDepth);
            }
            else
            {
                return backtrackAncestor(descendantOne, descendantTwo, descendantOneDepth - descendantTwoDepth);
            }

        }

        private static AncestralTree backtrackAncestor(AncestralTree lowerDescendant, AncestralTree higherDescendant, int diff)
        {
            while (diff > 0)
            {
                lowerDescendant = lowerDescendant.ancestor;
                diff--;
            }

            while (lowerDescendant != higherDescendant)
            {
                lowerDescendant = lowerDescendant.ancestor;
                higherDescendant = higherDescendant.ancestor;
            }

            return lowerDescendant;
        }

        private static int GetDescendantDepth(AncestralTree topAncestor, AncestralTree descendant)
        {
            int depth = 0;
            while (descendant != topAncestor)
            {
                descendant = descendant.ancestor;
                depth++;
            }
            return depth;
        }
    }

    public class AncestralTree
    {
        public char name;
        public AncestralTree ancestor;

        public AncestralTree(char name)
        {
            this.name = name;
            this.ancestor = null;
        }

        public void AddAsAncestor(AncestralTree[] descendants)
        {
            foreach(var descendant in descendants)
            {
                descendant.ancestor = this;
            }
        }
    }
}
