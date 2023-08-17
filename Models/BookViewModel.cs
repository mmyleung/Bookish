using Bookish.Models.Database;

namespace Bookish.Models;

public class BookViewModel
{
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Blurb { get; set; }
    public string Genre {get; set; }
    public int Year { get; set; }

    public List<CopyViewModel> Copies { get; set; }

    public BookViewModel (string isbn, string title, string author, string genre, int year)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
        Copies = new List<CopyViewModel>();
    }

    public BookViewModel (BookModel book)
    {
        ISBN = book.ISBN;
        Title = book.Title;
        // Author = book.Authors;
        Genre = book.Genre;
        Year = book.Year;
        // Copies = book.Copies;
    }
}
