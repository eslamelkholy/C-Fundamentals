int[] nums = { 2, 4, 6, 7, 8, 9, 12, 13, 14, 15, 16 };

string str = "The Quick Brown Fox Jump Over the Lazy Dog";

foreach (var item in nums)
{
  Console.WriteLine("Num = " + item);
}

foreach (var c in str)
{
  Console.WriteLine("Char = " + c);
}


Console.WriteLine("This is While Loop");

string inputName = "";

while (inputName != "Eslam")
{
  Console.WriteLine("Say my Name ");
  inputName = Console.ReadLine() ?? "";
}


