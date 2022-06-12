string outstr;
string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = { "one", "two", "three", "four" };

// TODO: Length of a string 

Console.WriteLine(str1.Length);

// TODO: Access individual characters

Console.WriteLine(str1[0]);

// TODO: iterate over a string like any other sequence of values

foreach (char c in str3)
{
  if (c == 'a') Console.WriteLine(c);
}


// TODO: String Concatenation     

outstr = String.Concat(strs);
Console.WriteLine(outstr);

// TODO: Joining strings together with Join

outstr = String.Join(", ", strs);
Console.WriteLine(outstr);

// TODO: String Comparison
// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
int result = String.Compare(str2, "This is a String");

// TODO: Equals just returns a regular Boolean

bool isEqual = str2.Equals(str3);
Console.WriteLine(isEqual);

// TODO: String Searching

Console.WriteLine(str1.IndexOf('e'));
Console.WriteLine(str1.IndexOf("fox"));

Console.WriteLine(str1.LastIndexOf('e'));
Console.WriteLine(str1.LastIndexOf("fox"));

outstr = str1.Replace("fox", "Cat");
Console.WriteLine(outstr);