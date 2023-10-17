using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.RecursionQuestions
{
    public class PhoneNumberMnemonicsQuestion
    {
        public static Dictionary<char, string[]> DIGIT_LETTERS = new Dictionary<char, string[]>
        {
            { '1', new string[] { "1" } },
            { '2', new string[] { "a", "b", "c" } },
            { '3', new string[] { "d", "e", "f" } },
            { '4', new string[] { "g", "h", "i" } },
            { '5', new string[] { "j", "k", "l" } },
            { '6', new string[] { "m", "n", "o" } },
            { '7', new string[] { "p", "q", "r", "s" } },
            { '8', new string[] { "t", "u", "v" } },
            { '9', new string[] { "w", "x", "y", "z" } },
            { '0', new string[] { "0" } },
        };

        public static List<string> PhoneNumberMnemonics1(string phoneNumber)
        {
            string[] currentMnemonic = new string[phoneNumber.Length];
            Array.Fill(currentMnemonic, "0");

            List<string> mnemonicsFound = new List<string>();
            PhoneNumberMnemonics1Helper(0, phoneNumber, currentMnemonic, mnemonicsFound);
            return mnemonicsFound;
        }

        private static void PhoneNumberMnemonics1Helper(int idx, string phoneNumber, string[] currentMnemonic, List<string> mnemonicsFound)
        {
            if (idx == phoneNumber.Length)
            {
                string mnemonic = string.Join("", currentMnemonic);
                mnemonicsFound.Add(mnemonic);
            }
            else
            {
                char digit = phoneNumber[idx];
                string[] letters = DIGIT_LETTERS[digit];
                foreach (string letter in letters)
                {
                    currentMnemonic[idx] = letter;
                    PhoneNumberMnemonics1Helper(idx + 1, phoneNumber, currentMnemonic, mnemonicsFound);
                }
            }
        }
    }
}
