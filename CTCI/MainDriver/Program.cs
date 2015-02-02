using System;
using System.Diagnostics;
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

            BstLevelOrderTraversal.Traverse(bst.Root);

            int[] a = { 4, 4, 3, 4, 5, 6, 7, 6, 5, 5, 5, 4, 3, 3, 4, 5, 6, 6 };
            Console.WriteLine("Index of 6: " + ArrayQuestions.FindElement(a, 6));
            Console.WriteLine("Index of 7: " + ArrayQuestions.FindElement(a, 7));
            Console.WriteLine("Index of 4: " + ArrayQuestions.FindElement(a, 4));
            Console.WriteLine("Index of 5: " + ArrayQuestions.FindElement(a, 5));
            Console.WriteLine("Index of 8: " + ArrayQuestions.FindElement(a, 8));

            Console.WriteLine("Maximum subarray sum: " + ArrayQuestions.LargestSumSlidingWindow(a, 4));
        }
    }
}
