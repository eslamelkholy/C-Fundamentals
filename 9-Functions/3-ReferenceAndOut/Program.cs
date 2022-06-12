using System;

namespace ReferenceAndOut
{
  class Program
  {
    // TODO: Default Behaviour pass by Value So Doesn't Change Main Variable
    public static void passByValue(int num)
    {
      num += 15;
      Console.WriteLine($"passByValue num = {num}");
    }

    // TODO: Pass by Reference Example Which Change Actual Variable
    public static void passByReference(ref int num)
    {
      num += 100;
      Console.WriteLine($"passByReference Value = {num}");
    }

    // TODO: Function Out
    public static void outSumAndResult(int num1, int num2, out int sum, out int product)
    {
      sum = num1 + num2;
      product = num1 * num2;
    }

    public static void Main(string[] args)
    {
      int val1 = 10;
      int val2 = 20;

      Program.passByValue(val1);
      Console.WriteLine(val1);

      Program.passByReference(ref val2);
      Console.WriteLine(val2);

      int sum;
      int product;

      Program.outSumAndResult(val1, val2, out sum, out product);
      Console.WriteLine($"Out Result Sum = {sum} And Product = {product}");


    }
  }
}



