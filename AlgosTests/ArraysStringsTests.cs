using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Algos.Tests
{
    [TestClass()]
    public class ArraysStringsTests
    {

        //String does not contain any duplicates, e.g.: abcd
        [TestMethod()]
        public void StringHasUniqueCharatersTest()
        {
            ArraysStrings strings = new ArraysStrings();
            Assert.IsTrue(strings.StringHasUniqueCharaters("abcd"));
        }

        //2.String contains all duplicates, e.g.: aaaa
        [TestMethod()]
        public void StringHasAllDupesTest()
        {
            //3.Null string
            //4.String with all continuous duplicates, e.g.: aaabbb}
        }

        //3.Null string
        [TestMethod()]
        public void NullStringTest()
        {
            //4.String with all continuous duplicates, e.g.: aaabbb}
        }

        //4.String with all continuous duplicates, e.g.: aaabbb}
        [TestMethod()]
        public void ContinuosDupesTest()
        {
        
        }
    }
}