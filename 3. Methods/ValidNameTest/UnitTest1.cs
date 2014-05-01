using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ValidNameTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PrintNameMethodTest.PrintName("Ivan");
        }
        [TestMethod]
        public void TestMethod2()
        {
            PrintNameMethodTest.PrintName("Ivan64");
        }
        [TestMethod]
        public void TestMethod3()
        {
            PrintNameMethodTest.PrintName("Samo Levski");
        }
        [TestMethod]
        public void TestMethod4()
        {
            PrintNameMethodTest.PrintName("Dragan Georgiev");
        }

    }
}
