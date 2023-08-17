namespace Bookish;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Microsoft.VisualBasic;
using Bookish.Models.Database;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;
    private readonly BookishDbContext _context;

    public BookController(ILogger<BookController> logger, BookishDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    [Route("Catalogue")]
    public IActionResult Index()
    {   
        var bookRepo = new BookRepo(_context);
        List<BookModel> allBooks = bookRepo.GetAllBooks();
        List<BookViewModel> books = new List<BookViewModel> ();
        foreach (var book in allBooks)
        {
            BookViewModel bookView = new BookViewModel(book);
            books.Add(bookView);
        }

        return View(books);
    }
    [HttpGet("Book")]
    public IActionResult Book()
    {
        var book = new BookViewModel("9781856132428", "Winnie-the-Pooh", "A. A. Milne", "Children's Literature", 1926);
        book.CoverPhotoUrl = "https://upload.wikimedia.org/wikipedia/en/c/c5/Winnie-the-Pooh_%28book%29.png";
        book.Blurb = "This silly old bear and his friends Piglet, Christopher Robin, Owl, Kanga, Roo and Tigger have bounced and sighed and tiddly-om-pommed their way into legend but they still find their home in the wood, where they continue to make friends with new generations of children more than a hundred years after their creation.";
        return View(book);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
