using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public bool NullNode { get; private set; }

        public static BinaryTreeNode GetNullNode()
        {
            return new BinaryTreeNode() { NullNode = true, Value = int.MinValue };
        }

        public static bool IsNullNode(BinaryTreeNode node)
        {
            return node.NullNode && node.Value == int.MinValue;
        }
    }
}
