using System;
using System.Collections.Generic;

namespace FinalExam {
 public class Program {
    public static int FindTheSecondBiggest(List<int> list)
    {
      list.Sort();
      return list[list.Count - 2];
    }
    
    static void Main(string[] args)
    {
      // Create a function that takes a list of numbers and returns the second biggest element from it
      List<int> list = new List<int>() { 9, 199, 2, 15, 3, 4, 34, 5 };
    }
  }
}
