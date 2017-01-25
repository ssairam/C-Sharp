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
    public class CustomLinkedListTests
    {
        [TestMethod()]
        public void AddTest()
        {
            CustomLinkedList<int> cll = new CustomLinkedList<int>();
            cll.Add(1);
            cll.Add(2);
            cll.Add(3);
            cll.PrintList();

        }
    }
}