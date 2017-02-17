using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace FinalExam.Tests {
  [TestClass()]
  public class ProgramTests {
    [TestMethod()]
    public void FindTheSecondBiggestTest_AreEqual()
    {
      List<int> list = new List<int>() { 4, 3, 2, 1 };
      int expected = 3;
      int actual = Program.FindTheSecondBiggest(list);
      Assert.AreEqual(expected, actual, "The returned number is not the second biggest.");
    }

    [TestMethod()]
    public void FindTheSecondBiggestTest_WithWrongExcpectedNumber_AreNotEqual()
    {
      List<int> list = new List<int>() { 4, 3, 2, 1, 9 };
      int expected = 1;
      int actual = Program.FindTheSecondBiggest(list);
      Assert.AreNotEqual(expected, actual);
    }


    [TestMethod()]
    [ExpectedException(typeof(NullReferenceException))]
    public void FindTheSecondBiggestTest_CheckArgumentNullException()
    {
      List<int> list = null;
      Program.FindTheSecondBiggest(list);
    }
  }
}