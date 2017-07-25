using System;
using System.Collections.Generic;
using System.Linq;

public class Book : IComparable<Book>
{
    public Book(string title, int year, params string[] authors)
    {
        this.Title = title;
        this.Year = year;
        this.Authors = new List<string>(authors);
    }

    public string Title { get; }
    public int Year { get; }
    public IReadOnlyList<string> Authors { get; }

    public int CompareTo(Book otherBook)
    {
        int result = this.Year.CompareTo(otherBook.Year);
        if (result == 0)
        {
            result = this.Title.CompareTo(otherBook.Title);
        }
        return result;
    }

    public override string ToString()
    {
        return $"{this.Title} - {this.Year}";
    }
}
