using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SinglyLinkedList
    {
        public static SingleLinkedListNode Head { get; private set; }
        public static void AddToEndOfList(SingleLinkedListNode node)
        {
            if (node == null)
            {
                throw new ArgumentNullException("node");
            }

            if (Head == null)
            {
                Head = node;
                return;
            }

            SingleLinkedListNode temp = Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = node;
        }
    }
}
