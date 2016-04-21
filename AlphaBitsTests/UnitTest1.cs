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
    public void isALetterTestPass()
    {
      Assert.IsTrue(testObj.isALetter('a'));
    }

    [TestMethod]
    public void isALetterTestFail()
    {
      Assert.IsFalse(testObj.isALetter('1'));
    }

    [TestMethod]
    public void listLengthTest()
    {
      Assert.AreEqual(0, testObj.listLength());
    }

    [TestMethod]
    public void inListTestPass()
    {
      testObj.addChar('a');
      Assert.IsTrue(testObj.inList('A'));
    }

  }
}
