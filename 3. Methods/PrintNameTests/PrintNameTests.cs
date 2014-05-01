using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PrintNameTests
{
    [TestMethod]
    public void TestMethod1()
    {
        PrintNameMethodTest.PrintName("Ivan");
    }
    [TestMethod]
    public void TestMethod2()
    {
        PrintNameMethodTest.PrintName("Dragan");
    }
    [TestMethod]
    public void TestMethod3()
    {
        PrintNameMethodTest.PrintName("Samo Levski");
    }
    [TestMethod]
    public void TestMethod4()
    {
        PrintNameMethodTest.PrintName("Pesho64");
    }
}

