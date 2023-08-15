namespace Bookish.Models;

public class AuthorViewModel
{
    public string Books { get; set; }
    public string Name { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Bio { get; set; }

    public Int BirthYear { get; set; }

    public AuthorViewModel (string books, string name, int birthyear)
    {
        Books = books;
        Name = name;
        BirthYear = birthyear;       
    }
}
