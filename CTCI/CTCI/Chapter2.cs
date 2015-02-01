using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace CTCI
{
    public class Chapter2
    {
        /// <summary>
        /// Find the point in the linked list where it makes a circular linked list
        /// </summary>
        /// <param name="root">Root of the linked list</param>
        /// <returns>Node or null</returns>
        public static int Question2_6_circularList(SingleLinkedListNode root)
        {
            if (root == null)
            {
                throw new ArgumentNullException("root");
            }

            SingleLinkedListNode fast = root, slow = root;
            throw new NotImplementedException();
        }
    }
}
