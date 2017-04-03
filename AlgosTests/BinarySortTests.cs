using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosTests
{
    [TestClass()]
    public class BinarySortTests
    {

        private BinaryTree _bt = null;

        [TestInitialize]
        public void Initialize()
        {
            _bt = new BinaryTree();
        }

        [TestMethod()]
        public void TestAddToBinaryTree()
        {
            /* 
                                            4
                                         /      \
                                        /         \
                                    2               6
                                 /     \           /\
                                /       \         /  \
                                1       3       5       7

                        */

            //int[] numbers = { 4, 2, 1, 3, 6, 5, 7 };
            AddToBinaryTreee();
            //PrintPreOrder();
            //PrintInOrder();
            PrintPostOrder();
        }

        private void PrintPreOrder()
        {
            _bt.TraverseTree(BinaryTree.PrintOrder.PRE);
            var preOrderList = _bt.TreeValues;
            Assert.AreEqual(4, preOrderList[0]);
            Assert.AreEqual(2, preOrderList[1]);
            Assert.AreEqual(1, preOrderList[2]);
            Assert.AreEqual(3, preOrderList[3]);
            Assert.AreEqual(6, preOrderList[4]);
            Assert.AreEqual(5, preOrderList[5]);
            Assert.AreEqual(7, preOrderList[6]);
        }
        private void PrintInOrder()
        {
            _bt.TraverseTree(BinaryTree.PrintOrder.IN);
            var preOrderList = _bt.TreeValues;
            Assert.AreEqual(1, preOrderList[0]);
            Assert.AreEqual(2, preOrderList[1]);
            Assert.AreEqual(3, preOrderList[2]);
            Assert.AreEqual(4, preOrderList[3]);
            Assert.AreEqual(5, preOrderList[4]);
            Assert.AreEqual(6, preOrderList[5]);
            Assert.AreEqual(7, preOrderList[6]);
        }

        private void PrintPostOrder()
        {
            _bt.TraverseTree(BinaryTree.PrintOrder.POST);
            var preOrderList = _bt.TreeValues;
            Assert.AreEqual(1, preOrderList[0]);
            Assert.AreEqual(3, preOrderList[1]);
            Assert.AreEqual(2, preOrderList[2]);
            Assert.AreEqual(5, preOrderList[3]);
            Assert.AreEqual(7, preOrderList[4]);
            Assert.AreEqual(6, preOrderList[5]);
            Assert.AreEqual(4, preOrderList[6]);
        }
        [TestMethod()]
        public void AddToBinaryTreeTest()
        {
            /* 
                                4
                             /      \
                            /         \
                        2               6
                     /     \           /\
                    /       \         /  \
                    1       3       5       7

            */

            //int[] numbers = { 4, 2, 1, 3, 6, 5, 7 };
            AddToBinaryTreee();
            PrintVariousOrders();

            _bt.RemoveNode(2);
            _bt.TraverseTree(BinaryTree.PrintOrder.PRE);
            var preOrderList = _bt.TreeValues;
            Assert.AreEqual(4, preOrderList[0]);
            Assert.AreEqual(1, preOrderList[1]);
            Assert.AreEqual(3, preOrderList[2]);
            Assert.AreEqual(6, preOrderList[3]);
            Assert.AreEqual(5, preOrderList[4]);
            Assert.AreEqual(7, preOrderList[5]);


            _bt = new BinaryTree();
            AddToBinaryTreee();
            _bt.TraverseTree(BinaryTree.PrintOrder.PRE);
            preOrderList = _bt.TreeValues;
            _bt.RemoveNode(6);
            _bt.TraverseTree(BinaryTree.PrintOrder.PRE);
            preOrderList = _bt.TreeValues;
            Assert.AreEqual(4, preOrderList[0]);
            Assert.AreEqual(2, preOrderList[1]);
            Assert.AreEqual(1, preOrderList[2]);
            Assert.AreEqual(3, preOrderList[3]);
            Assert.AreEqual(5, preOrderList[4]);
            Assert.AreEqual(7, preOrderList[5]);


            _bt = new BinaryTree();
            AddToBinaryTreee();
            PrintVariousOrders();

        }
        private void PrintVariousOrders()
        {
            PrintPreOrder();
            PrintInOrder();
            PrintPostOrder();
        }
        private void AddToBinaryTreee()
        {
            _bt.AddToBinaryTree(4);
            Assert.AreEqual(1, _bt.Height);

            _bt.AddToBinaryTree(2);
            Assert.AreEqual(2, _bt.Height);

            Assert.AreEqual(1, _bt.GetLeftHeight());
            Assert.AreEqual(0, _bt.GetRightHeight());

            _bt.AddToBinaryTree(1);
            Assert.AreEqual(3, _bt.Height);
            Assert.AreEqual(2, _bt.GetLeftHeight());
            Assert.AreEqual(0, _bt.GetRightHeight());

            _bt.AddToBinaryTree(3);
            Assert.AreEqual(3, _bt.Height);
            Assert.AreEqual(2, _bt.GetLeftHeight());
            Assert.AreEqual(0, _bt.GetRightHeight());

            _bt.AddToBinaryTree(6);
            Assert.AreEqual(3, _bt.Height);
            Assert.AreEqual(2, _bt.GetLeftHeight());
            Assert.AreEqual(1, _bt.GetRightHeight());

            _bt.AddToBinaryTree(5);
            Assert.AreEqual(3, _bt.Height);
            Assert.AreEqual(2, _bt.GetLeftHeight());
            Assert.AreEqual(2, _bt.GetRightHeight());

            _bt.AddToBinaryTree(7);
            Assert.AreEqual(3, _bt.Height);
            Assert.AreEqual(2, _bt.GetLeftHeight());
            Assert.AreEqual(2, _bt.GetRightHeight());
        }
    }
}
