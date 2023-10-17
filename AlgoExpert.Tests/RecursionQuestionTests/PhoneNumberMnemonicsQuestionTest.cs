using AlgoExpert.Questions.RecursionQuestions;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Tests.RecursionQuestionTests
{
    public class PhoneNumberMnemonicsQuestionTest
    {
        [Test]
        public void TestPhoneNumberMnemonics1()
        {
            string phoneNumber = "1905";
            string[] expectedValues = new string[] {
              "1w0j",
              "1w0k",
              "1w0l",
              "1x0j",
              "1x0k",
              "1x0l",
              "1y0j",
              "1y0k",
              "1y0l",
              "1z0j",
              "1z0k",
              "1z0l"
            };
            List<string> expected = new List<string>();
            for (int i = 0; i < expectedValues.Length; i++)
            {
                expected.Add(expectedValues[i]);
            }
            var actual = PhoneNumberMnemonicsQuestion.PhoneNumberMnemonics1(phoneNumber);
            Assert.IsTrue(Enumerable.SequenceEqual(expected, actual));
        }
    }
}
