using System;
using System.Collections.Generic;

namespace FinalExam {
 public class Program {
    // Create a function that takes a list of numbers and returns the second biggest element from it
    public static int FindTheSecondBiggest(List<int> list)
    {
      try
      {
        list.Sort();
      }
      catch (NullReferenceException e)
      {
        Console.WriteLine("Your argument is null.\n" + e);
        Console.ReadKey();
      }
      return list[list.Count - 2];
    }
    
    static void Main(string[] args)
    {
      List<int> filledList = new List<int>() { 9, 199, 2, 15, 3, 4, 34, 5 };
      List<int> nullList = null;
      Console.WriteLine(FindTheSecondBiggest(filledList));
      Console.WriteLine(FindTheSecondBiggest(nullList));
    }
  }
}
