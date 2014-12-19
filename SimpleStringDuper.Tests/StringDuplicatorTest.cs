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

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "string not provided")]
        public void Test_Duplicate_When_String_Not_Provided()
        {
            try
            {
                string str = null;
                str.Duplicate();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "string is empty")]
        public void Test_Duplicate_When_String_Is_Empty()
        {
            try
            {
                string str = string.Empty;
                str.Duplicate();
            }
            catch (Exception)
            {
                throw;
            }
 
        }
    }
}
