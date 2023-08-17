using Bookish.Models.Database;

namespace Bookish.Models;

public class BookViewModel
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public List<AuthorViewModel> Authors { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Blurb { get; set; }
    public string Genre {get; set; }
    public int Year { get; set; }

    public List<CopyViewModel> Copies { get; set; }

    public BookViewModel (string isbn, string title, List<AuthorViewModel> authors, string genre, int year)
    {
        ISBN = isbn;
        Title = title;
        Authors = authors;
        Genre = genre;
        Year = year;
        Copies = new List<CopyViewModel>();
    }

    public BookViewModel (BookModel book)
    {
        Console.WriteLine("string");
        ISBN = book.ISBN;
        Title = book.Title;
        Authors = book.Authors.Select(a => new AuthorViewModel(a.Name, a.BirthYear.Value, new List<BookViewModel>())).ToList();
        Genre = book.Genre;
        Year = book.Year.Value;
        Copies = new List<CopyViewModel>();
    }
}
