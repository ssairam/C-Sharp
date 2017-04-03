using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.Tests
{
    [TestClass()]
    public class SortAlgorithmsTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            //Assume no spaces
            //Sort "Sairam"
            var name = "sairam".ToCharArray();
            SortAlgorithms sa = new SortAlgorithms();
            sa.BubbleSort(name);
            Assert.AreEqual("aaimrs", new string(name));
        }


        [TestMethod()]
        public void InsertionSortTest()
        {
            //Assume no spaces
            //Sort "Sairam"
            var name = "sairam".ToCharArray();
            SortAlgorithms sa = new SortAlgorithms();
            sa.InsertionSort(name);
            Assert.AreEqual("aaimrs", new string(name));
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            var name = new int[] { 8, 2, 6, 7, 1, 3, 4, 5 };
            ISort sorter = new SortFactory();
            sorter.Sort(name, EnumFactory.SortTypes.SELECTION);
            Assert.AreEqual(1, name[0]);
            Assert.AreEqual(2, name[1]);
            Assert.AreEqual(3, name[2]);
            Assert.AreEqual(4, name[3]);
            Assert.AreEqual(5, name[4]);
            Assert.AreEqual(6, name[5]);
            Assert.AreEqual(7, name[6]);
            Assert.AreEqual(8, name[7]);
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            var name = new int[] { 8,2,6,7,1,3,4,5};
            ISort sorter = new SortFactory();
            sorter.Sort(name, EnumFactory.SortTypes.MERGE);
            Assert.AreEqual(1, name[0]);
            Assert.AreEqual(2, name[1]);
            Assert.AreEqual(3, name[2]);
            Assert.AreEqual(4, name[3]);
            Assert.AreEqual(5, name[4]);
            Assert.AreEqual(6, name[5]);
            Assert.AreEqual(7, name[6]);
            Assert.AreEqual(8, name[7]);
        }


        [TestMethod()]
        public void QuickSortTest()
        {
            var name = new int[] { 8, 2, 6, 7, 1, 3, 4, 5 };
            ISort sorter = new SortFactory();
            sorter.Sort(name, EnumFactory.SortTypes.QUICK);
            Assert.AreEqual(2, name[1]);
            Assert.AreEqual(3, name[2]);
            Assert.AreEqual(4, name[3]);
            Assert.AreEqual(5, name[4]);
            Assert.AreEqual(6, name[5]);
            Assert.AreEqual(7, name[6]);
            Assert.AreEqual(8, name[7]);
        }
    }
}