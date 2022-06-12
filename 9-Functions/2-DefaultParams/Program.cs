void prefixAppend(string str, string prefix = "Prefix")
{
  Console.WriteLine($"{prefix} {str}");
}

prefixAppend("String");


// TODO: Call Function with Parameters at any Order

prefixAppend(prefix: " Pre", str: "Str");
