using System;

namespace Properties
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Create new object instances using the "new" operator
      Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
      Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);

      b1.Name = "Eslam";

      b1.PageCount = 10000;
      b1.Price = 10000;

      Console.WriteLine(b1.Price);
      Console.WriteLine(b1.PageCount);
    }
  }
}