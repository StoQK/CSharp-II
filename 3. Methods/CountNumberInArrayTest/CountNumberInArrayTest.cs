using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class CountNumberInArrayTest
    {
        static int[] array = { 1, 7, 3, 2, 7, 7, -1, 3, 3, 3, 21, 765, 21 };
        [TestMethod]
        public void TestMethod1()
        {
            int result = CountNumberInArray.NumberCount(7, array);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int result = CountNumberInArray.NumberCount(3, array);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int result = CountNumberInArray.NumberCount(-1, array);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int result = CountNumberInArray.NumberCount(700, array);
            Assert.AreEqual(0, result);
        }
    }
