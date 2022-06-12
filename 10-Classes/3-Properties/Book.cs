using System;

namespace Properties
{

  public class Book
  {
    private string _name;
    private string _author;
    private int _pageCount;

    public Book(
      string name,
      string author,
      int pageCount
    )
    {
      _name = name;
      _author = author;
      _pageCount = pageCount;
      ISBN = "";
    }

    public int PageCount { get => _pageCount; set => _pageCount = value; }
    public string Name { get => _name; set => _name = value; }
    public string Author { get => _author; set => _author = value; }

    public string getDescription()
    {
      return $"The Book Name is {Name} and Author is {Author} And Pages = {PageCount}";
    }

    // TODO: Properties can be Auto Generates
    public string ISBN
    {
      get;
      set;
    }

    public decimal Price
    {
      get;
      set;
    }
  }
}
