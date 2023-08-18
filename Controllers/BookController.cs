namespace Bookish;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Microsoft.VisualBasic;
using Bookish.Models.Database;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;
    private readonly  IBookRepo _bookRepo;

    public BookController(IBookRepo bookRepo, ILogger<BookController> logger)
    {
        _bookRepo = bookRepo;
        _logger = logger;
    }

    [Route("Catalogue")]
    public IActionResult Index()
    {   
       
        List<BookModel> allBooks = _bookRepo.GetAllBooks();
        List<BookViewModel> books = new List<BookViewModel> ();
        foreach (var book in allBooks)
        {
            BookViewModel bookView = new BookViewModel(book.ISBN, book);
            books.Add(bookView);
        }

        return View(books);
    }

    [HttpGet("Catalogue/{isbn}")]

    public IActionResult Book(string isbn)
    {
        BookModel bookModel = _bookRepo.GetBookByIsbn(isbn);
        BookViewModel book = new BookViewModel(bookModel.ISBN, bookModel);
        return View(book);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
