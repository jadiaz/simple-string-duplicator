using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleStringDuper;

namespace SimpleStringDuper.Tests
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void Test_Duplicate()
        {
            string str = "this is only a test.";
            string expectedString = "tthhiiss  iiss  oonnllyy  aa  tteesstt..";
            Assert.AreEqual(expectedString, str.Duplicate());
        }
    }
}
