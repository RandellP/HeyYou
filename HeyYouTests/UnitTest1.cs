using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HeyYou;

namespace HeyYouTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            HeyYou.MessageText mt = new HeyYou.MessageText();
            Assert.AreEqual("Hey", mt.getNextWord());
        }
    }
}
