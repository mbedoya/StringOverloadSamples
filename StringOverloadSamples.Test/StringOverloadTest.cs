using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringOverloadSamples.Implementation;

namespace StringOverloadSamples.Test
{
    [TestClass]
    public class StringOverloadTest
    {
        [TestMethod]
        public void PlusPlusOperator_StringIsEmpty_EmptyResult()
        {
            MyString text = new MyString(string.Empty);
            text++;
            Assert.AreEqual(string.Empty, text.ToString());
        }

        [TestMethod]
        public void PlusPlusOperator_StringIsNull_EmptyResult()
        {
            MyString text = new MyString(null);
            text++;
            Assert.AreEqual(string.Empty, text.ToString());
        }

        [TestMethod]
        public void PlusPlusOperator_StringIsNotEmpty_StringDoubled()
        {
            MyString text = new MyString(" ");
            text++;
            Assert.AreEqual("  ", text.ToString());
        }

        [TestMethod]
        public void PlusPlusOperator_StringHasChars_StringDoubled()
        {
            MyString text = new MyString("aa");
            text++;
            Assert.AreEqual("aaaa", text.ToString());
        }
    }
}
