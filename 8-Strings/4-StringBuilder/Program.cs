﻿using System.Text;

int jumpCount = 10;
string[] animals = { "goats", "cats", "pigs" };

// TODO: create a StringBuilder

StringBuilder sb = new StringBuilder("Initial String.", 200);


// TODO: print some basic stats about the StringBuilder

Console.WriteLine($"Capacity {sb.Capacity} Length = {sb.Length}");

// TODO: Add some strings to the builder using Append

sb.Append("The Quick Brown Fox");
sb.Append("Jumps Over the Lazy Dogs.");

// TODO: AppendLine can append a line ending
sb.AppendLine();

// TODO: AppendFormat can be used to append formatted strings

sb.AppendFormat("He Did this {0} times.", jumpCount);
sb.AppendLine();

// AppendJoin can iterate over a set of values
sb.Append("He also jumped over ");
sb.AppendJoin(",", animals);

// Modify the content using Replace
sb.Replace("fox", "cat");

// Insert content at any index
sb.Insert(0, "This is the ");

Console.WriteLine($"Capacity: {sb.Capacity}; Length: {sb.Length}");

// Convert to a single string
Console.WriteLine(sb.ToString());