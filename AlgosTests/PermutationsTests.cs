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
    public class PermutationsTests
    {
        Permutations _p = null;

        [TestInitialize()]
        public void Initialize()
        {
            _p = new Permutations();    
        }

        [TestMethod()]
        public void RunTestNullOrEmptyOrOne()
        {
            var result = _p.Run(string.Empty);
            Assert.IsTrue(string.IsNullOrEmpty(result[0]));

            result = _p.Run("s");
            Assert.IsTrue("s".Equals(result[0]));
        }

        /// <summary>
        /// should give me sa as for sa as parameter. no dupes.
        /// </summary>
        [TestMethod()]
        public void RunTestTwoCharacters()
        {
            var result = _p.Run("sa");
            Assert.IsTrue(result.Count==2);
        }

        [TestMethod()]
        public void RunTestCheckForDupes()
        {
            Assert.Fail();
        }

    }
}