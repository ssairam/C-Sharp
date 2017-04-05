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
    public class StringAlgosTests
    {
        [TestMethod()]
        public void ReverseStringTest()
        {
            var result =  StringAlgos.ReverseString("Sairam");
            Assert.IsTrue(result.Equals("mariaS"));
        }
    }
}