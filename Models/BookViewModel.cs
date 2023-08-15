namespace Bookish.Models;

public class BookViewModel
{
    public int ISBN { get; set; }
    public string Title { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Blurb { get; set; }
    public string Genre {get; set; }
    public int Year { get; set; }

    public BookViewModel (int isbn, string title, string genre, int year)
    {
        ISBN = isbn;
        Title = title;
        Genre = genre;
        Year = year;
    }
}
