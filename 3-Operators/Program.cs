int x = 10, y = 5;

string fname = "Eslam", lname = "Elkholy";

// TODO: Try some Mathematics Operations +, - , / , * 

Console.WriteLine("==============");
Console.WriteLine("Some Basic Math Operations");
Console.WriteLine((x / y) * x);
Console.WriteLine(fname + lname);

Console.WriteLine("==============");
Console.WriteLine("Shorthand Operators");

x++;
y++;
Console.WriteLine(x);
Console.WriteLine(y);

// TODO: Logical Operatos && , ||

Console.WriteLine("==============");
Console.WriteLine("Logical Operators");
Console.WriteLine(x > y && y >= 15);
Console.WriteLine(x > y || y > 15);

Console.WriteLine("==============");
Console.WriteLine("NULL Coalescing Operators");
string str = null;
Console.WriteLine(str ?? "Unkown String");


Console.WriteLine("==============");
Console.WriteLine("Assign If Null");

// Instead of this
// if(str is null) {
//   str = "New String Assigned if Str is NULL";
// }

str ??= "New String Assigned if Str is NULL";
Console.WriteLine(str);
