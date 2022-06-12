using System;

namespace Classes
{

  public class Book
  {
    string _name;
    string _author;
    int _pageCount;

    public Book(string name, string author, int pageCount)
    {
      _name = name;
      _author = author;
      _pageCount = pageCount;
    }

    public string getDescription()
    {
      return $"The Book Name is {_name} and Author is {_author} And Pages = {_pageCount}";
    }
  }
}
