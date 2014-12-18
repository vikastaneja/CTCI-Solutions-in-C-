using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtraQuestions;

namespace MainDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardQuestions.Permutations.PrintPermutes("abc");

            DataStructures.BST bst = new DataStructures.BST();
            bst.Add(10);
            bst.Add(5);
            bst.Add(0);
            bst.Add(7);
            bst.Add(15);
            bst.Add(12); 
            bst.Add(20);
            int value = BSTNthHighest.GetNthHighestNumber(5, bst.Root);
        }
    }
}
