using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models.Database;

[PrimaryKey("ISBN")]
public class BookModel
{
    public string? ISBN { get; set; }
    public string? Title { get; set; }
    public string? CoverPhotoUrl  { get; set; }
    public string? Blurb { get; set; }
    public string? Genre {get; set; }
    public int? Year { get; set; }

    public List<CopyModel>? Copies { get; set; }
    public List<AuthorModel>? Authors { get; set; }

}
