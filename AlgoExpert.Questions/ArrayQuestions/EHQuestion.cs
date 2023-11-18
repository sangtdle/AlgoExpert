using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoExpert.Questions.ArrayQuestions
{
    public class ValidateArguments
    {
        public int Validate1(string[] args)
        {
            bool[] validatedResult = new bool[args.Length];

            foreach (string arg in args)
            {
                if (arg.Contains("help"))
                {
                    return 1;
                }
                else if (int.TryParse(arg, out int num))
                {
                    if (num >= 10 && num <100)
                    {
                        validatedResult[num] = true;
                    }
                    validatedResult[num] = false;
                }
                else
                {
                    int lengthOfString = arg.Length;
                    if (lengthOfString >=3 && lengthOfString <= 10)
                    {
                        validatedResult[num] = true;
                    }
                    validatedResult[num] = false;
                }
            }

            return (!(validatedResult.Length == 0) && validatedResult.All(r => r == true)) ? 0 : -1;
        }

        public int Validate(string[] args)
        {
            bool hasCount = false;
            bool hasName = false;
            bool hasHelp = false;
            List<int> indicesName = new List<int>();
            List<int> indicesCount = new List<int>();


            for (int idx = 0; idx < args.Length; idx++)
            {
                if (args[idx].Equals("--count", StringComparison.OrdinalIgnoreCase))
                {
                    indicesCount.Add(idx);
                    hasCount = true;
                }
                else if (args[idx].Equals("--name", StringComparison.OrdinalIgnoreCase))
                {
                    hasName = true;
                    indicesName.Add(idx);
                }
                else if (args[idx].Equals("--help", StringComparison.OrdinalIgnoreCase))
                {
                    hasHelp = true;
                }
            }

            if (!hasCount && !hasName && !hasHelp)
                return -1;

            foreach (var idx in indicesCount)
            {
                int count;
                if (int.TryParse(args[idx + 1], out count))
                {
                    if (count < 10 || count > 100)
                        return -1;
                }
            }

            foreach (var idx in indicesName)
            {
                string name = args[idx + 1];
                if (name.Length <= 3 || name.Length >= 10)
                    return -1;
            }

            return hasHelp ? 0 : 1;
        }
    }
}
