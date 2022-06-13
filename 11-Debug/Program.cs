using System;

namespace Debug
{
  class Program
  {
    public static void Main(string[] args)
    {
      if (args.Length > 0)
      {
        Console.WriteLine($" This One Will Throw Error {args[0]}");
      }
      else
      {
        Console.WriteLine($" This One Will Not Throw Error");

      }
    }
  }
}