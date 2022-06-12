using System;

namespace Defining
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Create new object instances using the "new" operator
      Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);
      Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);

      // Call a method on the object
      Console.WriteLine(b1.getDescription());
      Console.WriteLine(b2.getDescription());
    }
  }
}