using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardQuestions
{
    public class Permutations
    {
        public static void PrintPermutes(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException("str");
            }

            Permute(string.Empty, str, 0, str.Length);
        }

        private static void Permute(string extraString, string actual, int currentLocation, int n)
        {
            if (extraString.Length == n)
            {
                System.Console.WriteLine(extraString);
                return;
            }

            for (int i = 0; i < actual.Length; i++)
            {
                Permute(extraString + actual[i].ToString(), actual.Substring(0, i) + actual.Substring(i + 1), i, n);
            }
        }
    }
}
