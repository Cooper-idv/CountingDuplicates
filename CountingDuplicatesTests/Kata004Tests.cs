using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountingDuplicates;
using System;
using System.Collections.Generic;
using System.Text;

namespace CountingDuplicates.Tests
{
    [TestClass()]
    public class Kata004Tests
    {
        [TestMethod()]
        public void DuplicateCountTest()
        {
            Assert.AreEqual(0, Kata004.DuplicateCount(""));
            Assert.AreEqual(0, Kata004.DuplicateCount("abcde"));
            Assert.AreEqual(2, Kata004.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, Kata004.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, Kata004.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, Kata004.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }
    }
}