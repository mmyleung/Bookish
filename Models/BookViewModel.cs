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
    public int? Year { get; set; }

    public int Copies { get; set; }

    public BookViewModel (string isbn, string title, List<AuthorViewModel> authors, string genre, int year)
    {
        ISBN = isbn;
        Title = title;
        Authors = authors;
        Genre = genre;
        Year = year;
    }

    public BookViewModel (string? iSBN, BookModel book)
    {
        ISBN = book.ISBN;
        Title = book.Title;
        Authors = book.Authors.Select(a => new AuthorViewModel(a.Name, a.BirthYear.Value, new List<BookViewModel>())).ToList();
        Genre = book.Genre;
        Year = book.Year.Value;
        Copies = book.Copies.Count();
        CoverPhotoUrl = book.CoverPhotoUrl;
    }
}
