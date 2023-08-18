using Microsoft.EntityFrameworkCore;

namespace Bookish.Models.Database;

[PrimaryKey("Barcode")]
public class CopyModel
{
    public long Barcode { get; set; }

    public BookModel? Book { get; set; }
}