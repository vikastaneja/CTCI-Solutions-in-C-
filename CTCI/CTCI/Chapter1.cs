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
    }
}
