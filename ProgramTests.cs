using FinalExam;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace FinalExam.Tests {
  [TestClass()]
  public class ProgramTests {
    [TestMethod()]
    public void FindTheSecondBiggestTest()
    {
      List<int> list = new List<int>() { 4, 3, 2, 1 };
      int expected = 3;
      int actual = Program.FindTheSecondBiggest(list);
      Assert.AreEqual(expected, actual);
    }
  }
}