using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Alphabits;

namespace AlphaBitsTests
{
  [TestClass]
  public class UnitTest1
  {
    AlphaList testObj = new AlphaList();

    [TestMethod]
    public void addCharTestPass()
    {
      Assert.IsTrue(testObj.addChar('a'));
    }

    [TestMethod]
    public void addCharTestFail()
    {
      Assert.IsFalse(testObj.addChar('1'));
    }

    [TestMethod]
    public void listLengthTest()
    {
      Assert.AreEqual(0, testObj.listLength());
    }
  }
}
