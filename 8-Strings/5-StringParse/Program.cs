using System;
using System.Globalization;

string numStr1 = "1";
string numStr2 = "2.00";
string numStr3 = "3,000";
string numStr4 = "3,000.00";

// The Parse function attempts to parse a string into a number
// but it might throw an exception, so we need to catch that
int targetNum = 0;
try
{
  // TODO: Use Parse to try a simple integer
  targetNum = int.Parse(numStr1);
  Console.WriteLine(targetNum); // 1

  // TODO: Use Parse to try a floating point number
  // This only works if the decimal value is 0
  targetNum = int.Parse(numStr2, NumberStyles.Float);
  Console.WriteLine(targetNum); // 2


  // TODO: Use Parse to try a number with thousands marker

  targetNum = int.Parse(numStr3, NumberStyles.AllowThousands);
  Console.WriteLine(targetNum); // 3000


  // TODO: Use Parse to try a number with thousands marker AND decimal

  targetNum = int.Parse(numStr4, NumberStyles.AllowThousands | NumberStyles.Float);
  Console.WriteLine(targetNum); // 3000


  // TODO: This works with other types too, like bool

  Console.WriteLine($"Boolean Test {bool.Parse("True")}");


  // TODO: Or floating point numbers
  Console.WriteLine($"Boolean Test {float.Parse("1.3213"):F3}");

}
catch
{
  Console.Write("Conversion failed");
}

// TODO: The TryParse function is similar but handles the exceptions for us
bool isParseSuccess = false;

isParseSuccess = Int32.TryParse(numStr1, out targetNum);

if (isParseSuccess)
{
  Console.WriteLine($"The Parse is Success With Target = {targetNum}");
}