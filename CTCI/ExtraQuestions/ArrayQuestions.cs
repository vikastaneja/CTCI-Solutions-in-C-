using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraQuestions
{
    public class ArrayQuestions
    {
        /// <summary>
        /// Find if the element is present in the array.
        /// Property of array is that each neighbor element is not more than 1 difference
        /// </summary>
        /// <param name="a">Array to be searched</param>
        /// <param name="x">Element to be searched</param>
        /// <returns>Returns the index of the element</returns>
        public static int FindElement(int[] a, int x)
        {
            if (a == null || a.Length == 0)
            {
                throw new ArgumentNullException("a");
            }

            for (int i = 0; i < a.Length; )
            {
                int jump = 1;
                if (x == a[i])
                {
                    return i;
                }

                jump = Math.Abs(x - a[i]);

                i += jump;
            }

            return -1;
        }
    }
}
