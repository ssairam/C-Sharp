using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Tests
{
    [TestClass()]
    public class BinarySearchTests
    {
        private BinarySearch b = new BinarySearch();

        [TestMethod()]
        public void PrintTreeTest()
        {
            b.PrintTree();   
        }

        [TestMethod()]
        public void AddToBinaryTreeTest()
        {
            b.PrintTree();
            AddFirstValueToBinaryTree(4);
            PrintTreeTest();
            AddLessThanRootValues();
            PrintTreeTest();
        }

        private void AddLessThanRootValues()
        {
            throw new NotImplementedException();
        }

        private void AddFirstValueToBinaryTree(int v)
        {
            b.AddToBinaryTree(4);
        }
    }
}