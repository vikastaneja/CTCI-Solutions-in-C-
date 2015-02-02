using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraQuestions
{
    public class StringProblems
    {
        /// <summary>
        /// Regular expression match with string
        /// </summary>
        /// <param name="actual"></param>
        /// <param name="regex"></param>
        /// <returns></returns>
        public static bool MatchRegex(string actual, string regex)
        {
            if (actual == null || regex == null)
            {
                throw new ArgumentNullException("actual or regex");
            }

            int i = 0, j = 0;
            for (; i < actual.Length && j < regex.Length; )
            {
                if (regex[j] == '?')
                {
                    i++;
                    j++;
                    continue;
                }

                if (regex[j] == '*')
                {
                    if (j == regex.Length - 1)
                        return true;

                    j++;

                    while (i < actual.Length && actual[i] != regex[j])
                    {
                        i++;
                    }

                    if (i == actual.Length)
                        return false;
                }

                if (regex[j] != actual[i])
                    return false;

                i++;
                j++;
            }

            if (i != actual.Length || j != regex.Length)
                return false;

            return true;
        }
    }
}
