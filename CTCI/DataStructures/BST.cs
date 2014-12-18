using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BST
    {
        public BinaryTreeNode Root { get; private set; }
        public void Add(BinaryTreeNode node)
        {
            if (node == null)
                return;

            if (Root == null)
            {
                Root = node;
                return;
            }

            BinaryTreeNode temp = Root;
            while (temp != null)
            {
                if (node.Value < temp.Value)
                {
                    if (temp.Left == null)
                    {
                        temp.Left = node;
                        return;
                    }
                    else
                    {
                        temp = temp.Left;
                    }
                }
                else
                {
                    if (temp.Right == null)
                    {
                        temp.Right = node;
                        return;
                    }
                    else
                    {
                        temp = temp.Right;
                    }
                }
            }
        }

        public void Add(int value)
        {
            BinaryTreeNode node = new BinaryTreeNode() { Value = value };
            Add(node);
        }
    }
}
