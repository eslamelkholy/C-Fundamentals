using System;

namespace AccessModifiers
{

  public class Book
  {
    public string _name;
    protected string _author;
    private int _pageCount;

    public Book(string name, string author, int pageCount)
    {
      _name = name;
      _author = author;
      PageCount = pageCount;
    }

    public int PageCount { get => _pageCount; set => _pageCount = value; }

    public string getDescription()
    {
      return $"The Book Name is {_name} and Author is {_author} And Pages = {PageCount}";
    }
  }
}
