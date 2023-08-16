namespace Bookish;
using Bookish;
using Bookish.Models.Database;
using Microsoft.EntityFrameworkCore;

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
                .Where(b => b.ISBN == Isbn)
                .Single();
    }
}