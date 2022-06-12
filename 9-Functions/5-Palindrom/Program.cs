// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, This Program Determine if String is Palindrom or Not");


bool isPalindrom(string str)
{
  str = str.ToLower();
  for (int i = 0; i < str.Length; i++)
  {
    if (Char.IsPunctuation(str[i])) continue;

    if (str[i] != str[str.Length - i - 1])
    {
      return false;
    }
  }
  return true;
}

while (true)
{
  Console.WriteLine("Please Enter The String");
  string? str = Console.ReadLine();
  if (str is null) continue;

  if (isPalindrom(str))
  {
    Console.WriteLine($"{str} Is Palindrom True and Length = {str.Length}");
  }
  else
  {
    Console.WriteLine($"{str} is Not Palindrom");
  }

}