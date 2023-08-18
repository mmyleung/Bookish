using System.Linq;
using Bookish.Models.Database;

namespace Bookish.Models;

public class AuthorViewModel
{
    public List<BookViewModel> Books { get; set; }
    public string Name { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Bio { get; set; }

    public int? BirthYear { get; set; }

    public int? ID { get; set; }

    public AuthorViewModel (string name, int birthyear, List<BookViewModel> books)
    {
        Name = name;
        BirthYear = birthyear;       
        Books = books;
    }

    public AuthorViewModel (AuthorModel author)
    {
        Name = author.Name;
        BirthYear = author.BirthYear;       
        Books = author.Books.Select(b => new BookViewModel(b.ISBN, b)).ToList();
        ID = author.Id;
    }
}
