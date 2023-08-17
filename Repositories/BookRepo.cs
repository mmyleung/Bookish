namespace Bookish;
using Bookish;
using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

public interface IBookRepo
{
    List<BookModel> GetAllBooks();
    BookModel GetBookByIsbn(string Isbn);
}
public class BookRepo : IBookRepo
{
    private readonly BookishDbContext _context;

    public BookRepo(BookishDbContext context)
    {
        _context = context;
    }

    public List<BookModel> GetAllBooks()
    {
        return _context.Books
        .Include(b => b.Authors)
        .Include(b => b.Copies)
        .ToList();
    }

    public BookModel GetBookByIsbn(string Isbn)
    {
        return _context.Books
            .Include(b => b.Authors)
            .Include(b => b.Copies)
            .Where(b => b.ISBN == Isbn)
            .Single();
    }
}