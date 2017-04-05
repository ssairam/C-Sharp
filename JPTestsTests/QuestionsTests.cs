using Microsoft.VisualStudio.TestTools.UnitTesting;
using JPTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPTests.Tests
{
    [TestClass()]
    public class QuestionsTests
    {
        Questions _questions = null;

        [TestInitialize]
        public void Initialize()
        {
            _questions = new Questions();
        }

        [TestMethod()]
        public void FindGreatestSuffixTest()
        {
            Assert.AreEqual(string.Empty, _questions.FindGreatestSuffix(string.Empty, "outfield"));
            Assert.AreEqual(string.Empty, _questions.FindGreatestSuffix("cricketfield", string.Empty));
            Assert.AreEqual("tfield", _questions.FindGreatestSuffix("cricketfield", "outfield"));
            Assert.AreEqual("NULL", _questions.FindGreatestSuffix("Warren", "Buffet"));
        }

        [TestMethod()]
        public void InsertDelimitersForEvenAndOddNumbersTest()
        {
            Assert.AreEqual("12*2*456087",
                _questions.InsertDelimitersForEvenAndOddNumbers("122456087"));

            Assert.AreEqual("123-54*6067",
                _questions.InsertDelimitersForEvenAndOddNumbers("123546067"));
        }
    }
}