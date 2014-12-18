using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace ExtraQuestions
{
    public class BSTNthHighest
    {
        private static int current = 0;
        public static int GetNthHighestNumber(int n, DataStructures.BinaryTreeNode root)
        {
            if (root == null)
                throw new ArgumentNullException("root");

            if (n <= 0)
                throw new ArgumentException("n");

            BinaryTreeNode nthNode = GetNthHighestNode(root, n);
            if (nthNode != null)
            {
                return nthNode.Value;
            }

            throw new InvalidOperationException();
        }

        private static BinaryTreeNode GetNthHighestNode(BinaryTreeNode node, int n)
        {
            if (node == null)
            {
                return null;
            }

            BinaryTreeNode right = GetNthHighestNode(node.Right, n);
            if (right == null)
            {
                current++;
            }
            
                if (current == n)
                {
                    return right != null ? right : node;
                }
            

            BinaryTreeNode left = GetNthHighestNode(node.Left, n);

            return left;
        }
    }
}
