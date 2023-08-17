namespace Bookish.Models;

public class AuthorViewModel
{
    public List<BookViewModel> Books { get; set; }
    public string Name { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Bio { get; set; }

    public int BirthYear { get; set; }

    public AuthorViewModel (string name, int birthyear, List<BookViewModel> books)
    {
        Name = name;
        BirthYear = birthyear;       
        Books = books;
    }
}
