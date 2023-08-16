namespace Bookish.Models;

public class CopyViewModel
{
    public string ISBN { get; set; }
    public long Barcode { get; set; }

    public CopyViewModel (string isbn, long barcode)
    {
        ISBN = isbn;
        Barcode = barcode;
    }
}