namespace Bookish.Models;

public class CopyViewModel
{
    public long Barcode { get; set; }
    public BookViewModel Book { get; set; }

    public CopyViewModel (long barcode)
    {
        Barcode = barcode;
    }
}