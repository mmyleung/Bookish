namespace Bookish;
using Bookish;
using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

class BookRepo
{
    private readonly BookishDbContext _context;

    public BookRepo(BookishDbContext context)
    {
        _context = context;
    }

    public List<BookModel> GetAllBooks()
    {
        return _context.Books.ToList();
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