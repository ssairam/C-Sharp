using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class BinaryTree
    {
        public enum PrintOrder { PRE, IN, POST };

        public int Height
        {
            get { return GetHeight(_head); }
        }

        private List<int> _treeValues = new List<int>();
        public List<int> TreeValues { get { return _treeValues; } }

        private Node _head = null;

        public void AddToBinaryTree(int v)
        {
            if (null == _head)
            { _head = new Node(v); return; }

            AddToBinaryTree(_head, v);
        }

        private void AddToBinaryTree(Node node, int v)
        {
            if (v <= node.Value)
            {
                if (node.Left == null)
                { node.Left = new Node(v); return; }
                AddToBinaryTree(node.Left, v);
            }
            else
            {
                if (node.Righ == null)
                {
                    node.Righ = new Node(v); return;
                }
                AddToBinaryTree(node.Righ, v);
            }
        }

        public int GetLeftHeight()
        {
            return GetHeight(_head.Left);
        }

        private int GetHeight(Node node)
        {
            if (node == null) return 0;

            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Righ));
        }

        public int GetRightHeight()
        {
            return GetHeight(_head.Righ);
        }

        public void TraverseTree(PrintOrder order)
        {
            switch (order)
            {
                case PrintOrder.PRE:
                    //Travel Head, LeftNode and then Right Node
                    PreTraversal(_head);
                    break;
                case PrintOrder.IN:
                    InTraversal(_head);
                    break;
                case PrintOrder.POST:
                    PostTraversal(_head);
                    break;
                default:
                    break;
            }
        }

        private void PreTraversal(Node node)
        {

            if (null == node) return;
            //Travel Root
            _treeValues.Add(node.Value);
            //Travel Left
            PreTraversal(node.Left);
            //Travel Right  
            PreTraversal(node.Righ);
        }

        private void InTraversal(Node node)
        {
            if (null == node) return;
            //Travel Left
            InTraversal(node.Left);
            //Travel Root
            _treeValues.Add(node.Value);
            //Travel Right  
            InTraversal(node.Righ);
        }

        private void PostTraversal(Node node)
        {
            if (null == node) return;
            //Travel Left
            PostTraversal(node.Left);
            //Travel Right  
            PostTraversal(node.Righ);
            //Travel Root
            _treeValues.Add(node.Value);
        }

        public void RemoveNode(int v)
        {
            throw new NotImplementedException();
        }
    }

    public class Node
    {
        private int value;
        private Node left;
        private Node righ;

        public Node(int v)
        {
            this.value = v;
        }

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

        public Node Left
        {
            get
            {
                return left;
            }

            set
            {
                left = value;
            }
        }

        public Node Righ
        {
            get
            {
                return righ;
            }

            set
            {
                righ = value;
            }
        }
    }

}
