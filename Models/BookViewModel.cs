namespace Bookish.Models;

public class BookViewModel
{
    public long ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Blurb { get; set; }
    public string Genre {get; set; }
    public int Year { get; set; }

    public BookViewModel (long isbn, string title, string author, string genre, int year)
    {
        ISBN = isbn;
        Title = title;
        Author = author;
        Genre = genre;
        Year = year;
    }
}
