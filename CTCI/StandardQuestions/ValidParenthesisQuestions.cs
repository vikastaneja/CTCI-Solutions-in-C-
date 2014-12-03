using System;
using D = System.Diagnostics.Debug;

namespace StandardQuestions
{
    public class ValidParenthesisQuestions
    {
        private void PrintValidCombinations(string s, int left, int right)
        {
            if (s == null)
            {
                throw new ArgumentNullException("s");
            }

            if (right == 0 && left == 0)
            {
                D.WriteLine(s);
                return;
            }

            if (right < left)
            {
                return;
            }

            if (left < 0 || right < 0)
            {
                return;
            }

            this.PrintValidCombinations(s + "(", left - 1, right);
            this.PrintValidCombinations(s + ")", left, right - 1);
        }

        public void ValidParenthesisCombinations(int times)
        {
            if (times < 0)
            {
                throw new ArgumentOutOfRangeException("times");
            }

            this.PrintValidCombinations(string.Empty, times, times);
        }
    }
}
