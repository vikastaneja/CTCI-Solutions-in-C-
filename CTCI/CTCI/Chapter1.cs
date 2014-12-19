using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI
{
    public class Chapter1
    {
        public bool Q1_AllUniqueWithDictionary(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("str");
            }

            if (str.Length == 0)
            { return true; }

            IDictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (dict.ContainsKey(c))
                    return false;

                dict.Add(c, 1);
            }

            return true;
        }

        public bool Q3_OneStringPermutationOfOther(string s1, string s2)
        {
            if (s1 == null && s2 == null)
                return true;

            if (s1 == null || s2 == null)
                return false;

            if (s1.Length == 0 && s2.Length == 0)
                return true;

            if (s1.Length != s2.Length)
                return false;

            // One way to solve it is to sort both strings and then compare letter by letter.
            // Another way is to use additional data structure - HashTable. Parse the first string and update the hash table with character count. 
            // Then with the second string, compare and reduce the character count. Once the character count is -ve or character not found, return false.
            // If the character set is small, we can use an array instead of hashtable. 
            // In this implementation, I am going to use hashtable assuming the solution can scale to unicode character sets.
            Dictionary<char, int> d = new Dictionary<char, int>(s1.Length);
            foreach(char c in s1)
            {
                int counter = 1;
                if (d.ContainsKey(c))
                {
                    counter = d[c];
                    d[c] = counter + 1;
                }
                else
                {
                    d[c] = counter;
                }
            }

            foreach(char c in s2)
            {
                if (!d.ContainsKey(c) || d[c] <= 0)
                {
                    return false;
                }

                d[c] -= 1;
            }

            foreach(KeyValuePair<char, int> kp in d)
            {
                if (kp.Value != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
