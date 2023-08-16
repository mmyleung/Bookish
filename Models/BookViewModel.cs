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
}
