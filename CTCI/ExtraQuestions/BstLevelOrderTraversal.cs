using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures;

namespace ExtraQuestions
{
    public class BstLevelOrderTraversal
    {
        public static void Traverse(BinaryTreeNode root)
        {
            if (root == null)
            {
                throw new ArgumentNullException("root");
            }

            Queue<BinaryTreeNode> q = new Queue<BinaryTreeNode>(2);
            q.Enqueue(root);
            
            while (q.Count != 0)
            {
                q.Enqueue(BinaryTreeNode.GetNullNode());
                while(!BinaryTreeNode.IsNullNode(q.Peek()))
                {
                    BinaryTreeNode temp = q.Dequeue();
                    System.Console.Write(temp.Value + " ");
                    if (temp.Left != null)
                        q.Enqueue(temp.Left);

                    if (temp.Right != null)
                        q.Enqueue(temp.Right);
                }

                System.Console.WriteLine();
                q.Dequeue();
            }

            q.Clear();
        }
    }
}
