namespace Bookish.Models;

public class AuthorViewModel
{
    public string Books { get; set; }
    public string Name { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Bio { get; set; }

    public int BirthYear { get; set; }

    public AuthorViewModel (string name, int birthyear, string books)
    {
        Name = name;
        BirthYear = birthyear;       
        Books = books;
    }
}
