using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class BookController : Controller
{
    private readonly ILogger<BookController> _logger;

    public BookController(ILogger<BookController> logger)
    {
        _logger = logger;
    }
    [HttpGet("Books")]
    public IActionResult Index()
    {   var book1 = new BookViewModel(9781856132428, "Winnie-the-Pooh", "A. A. Milne", "Children's Literature", 1926);
        book1.CoverPhotoUrl = "https://upload.wikimedia.org/wikipedia/en/c/c5/Winnie-the-Pooh_%28book%29.png";
        book1.Blurb = "This silly old bear and his friends Piglet, Christopher Robin, Owl, Kanga, Roo and Tigger have bounced and sighed and tiddly-om-pommed their way into legend but they still find their home in the wood, where they continue to make friends with new generations of children more than a hundred years after their creation.";
        var book2 = new BookViewModel(9781787637078, "Abroad in Japan", "Chris Broad", "Travel", 2023);
        book2.CoverPhotoUrl = "https://cdn.waterstones.com/bookjackets/large/9781/7876/9781787637078.jpg";
        book2.Blurb = "When Englishman Chris Broad landed in a rural village in northern Japan he wondered if he'd made a huge mistake. With no knowledge of the language and zero teaching experience, was he about to be the most quickly fired English teacher in Japan's history?";
        List<BookViewModel> books = new List<BookViewModel>();
        books.Add(book1);
        books.Add(book2);
        return View(books);
    }
    [HttpGet("Books/book")]
    public IActionResult Book()
    {
        var book = new BookViewModel(9781856132428, "Winnie-the-Pooh", "A. A. Milne", "Children's Literature", 1926);
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
