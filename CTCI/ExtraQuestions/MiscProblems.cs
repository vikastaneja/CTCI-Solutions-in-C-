using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraQuestions
{
    public class MiscProblems
    {
        public static List<Tuple<int, int>> MergeSortedPairLists(List<Tuple<int, int>> pairs)
        {
            if (pairs == null)
            {
                throw new ArgumentNullException("pairs");
            }

            if (pairs.Count <= 1)
            {
                return pairs;
            }

            Stack<Tuple<int, int>> st = new Stack<Tuple<int,int>>();

            // Assuming the list is sorted
            foreach(Tuple<int, int> pair in pairs)
            {
                if(st.Count == 0)
                {
                    st.Push(pair);
                    continue;
                }

                Tuple<int, int> top = st.Peek();
                if (top.Item2 < pair.Item1)
                {
                    st.Push(pair);
                }
                else 
                {
                    // Merge the two
                    int item1 = top.Item1 < pair.Item1 ? top.Item1 : pair.Item1;
                    int item2 = top.Item2 > pair.Item2 ? top.Item2 : pair.Item2;
                    st.Pop();
                    st.Push(new Tuple<int, int>(item1, item2));
                }
            }

            pairs.Clear();
            while (st.Count != 0)
            {
                pairs.Insert(0, st.Pop());
            }

            return pairs;
        }
    }
}
