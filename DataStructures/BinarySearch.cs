using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class BinarySearch
    {
        private Node Tree;
        public void AddToBinaryTree(int i)
        {
            if (null == Tree)
                Tree = new Node { Value = i };


        }

        public void PrintTree()
        {
            if (null == Tree)
            {
                TestTrace("Tree is empty");
                return;
            }
            //Check if Right and Left node exists.
            if (null == Tree.RightNode && null == Tree.LeftNode)
            {
                TestTrace(Tree.Value.ToString());
                return;
            }
            //Traverse Left
            if (null == Tree.LeftNode) throw new NotImplementedException("Cannot print Left Nodes at this time.");
            //Traverse Right
            if (null == Tree.RightNode) throw new NotImplementedException("Cannot print Right Nodes at this time.");
        }


        private void TestTrace(string message, params object[] args)
        {
            System.Diagnostics.Debug.WriteLine(String.Format(message, args));
            Console.Out.WriteLine(message, args);
        }

    }

    public class Node
    {
        private int value;
        private Node rightNode;
        private Node leftNode;

        public int Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }

        public Node RightNode
        {
            get
            {
                return rightNode;
            }

            set
            {
                rightNode = value;
            }
        }

        public Node LeftNode
        {
            get
            {
                return leftNode;
            }

            set
            {
                leftNode = value;
            }
        }
    }


}
