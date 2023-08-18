namespace Bookish.Models.Database;


public class AuthorModel
{
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Bio { get; set; }
    public int? BirthYear { get; set; }

    public List<BookModel>? Books { get; set; }

    public List<CopyModel>? Copies { get; set; }

}
