using System;

namespace MultipleReturnValues
{
  class Program
  {
    public static void Main(string[] args)
    {
      // TODO: Define Tuples C# Version 7.
      (int a, int b) tup1 = (5, 10);

      var tup2 = ("Hello Val1", 100);

      tup1.b = 1001;

      tup2.Item1 = "Hello Val";

      Console.WriteLine(tup1.a + tup1.b);
      Console.WriteLine(tup2);

      (int, string) result = Program.returnMultiple(7, "Seven");

      Console.WriteLine(result.Item1 + result.Item2);

    }

    // TODO: Function Returns Multiple Values WIth Tuple

    public static (int, string) returnMultiple(int a, string b)
    {
      return (a, b);
    }
  }
}