using AlgoExpert.Questions.GraphsQuestions;

namespace AlgoExpert.Tests.GraphsQuestionTests
{
    public class YoungestCommonAncestorQuestionTest
    {
        public Dictionary<char, AncestralTree> getNewTrees()
        {
            var trees = new Dictionary<char, AncestralTree>();
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char a in alphabet)
            {
                trees.Add(a, new AncestralTree(a));
            }

            trees['A'].AddAsAncestor(new AncestralTree[] {
              trees['B'], trees['C'], trees['D'], trees['E'], trees['F']
            });
            return trees;
        }

        [Test]
        public void TestCase1()
        {
            var trees = getNewTrees();
            trees['A'].AddAsAncestor(
              new AncestralTree[] { trees['B'], trees['C'] }
            );
            trees['B'].AddAsAncestor(
              new AncestralTree[] { trees['D'], trees['E'] }
            );
            trees['D'].AddAsAncestor(
              new AncestralTree[] { trees['H'], trees['I'] }
            );
            trees['C'].AddAsAncestor(
              new AncestralTree[] { trees['F'], trees['G'] }
            );

            AncestralTree yca = YoungestCommonAncestorQuestion.GetYoungestCommonAncestor(trees['A'], trees['E'], trees['I']);
            Assert.IsTrue(yca == trees['B']);
        }
    }
}
