namespace Bookish;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Models.Database;

public class AuthorController : Controller
{
    private readonly ILogger<AuthorController> _logger;
    private readonly  IAuthorRepo _authorRepo;

    public AuthorController(IAuthorRepo authorRepo, ILogger<AuthorController> logger)
    {
        _authorRepo = authorRepo;
        _logger = logger;
    }
    [Route("Authors")]
    public IActionResult Index()
    {   
        IEnumerable<AuthorModel> allAuthors = _authorRepo.GetAuthors();
        List<AuthorViewModel> authors = new List<AuthorViewModel>();
        foreach (var author in allAuthors)
        {
            AuthorViewModel authorView = new AuthorViewModel(author);
            authors.Add(authorView);
        }
        return View(authors);
    }
    [HttpGet("Authors/{author}")]
    public IActionResult Author()
    {
        AuthorModel authorModel = new AuthorModel();
        var author = new AuthorViewModel("A. A. Milne", 1882, new List<BookViewModel>());
        author.CoverPhotoUrl = "https://cdn.britannica.com/22/66322-050-9A24E091/AA-Milne-1920.jpg";
        author.Bio = "Alan Alexander Milne was an English writer best known for his books about the teddy bear Winnie-the-Pooh, as well as for children's poetry. Milne was primarily a playwright before the huge success of Winnie-the-Pooh overshadowed all his previous work.";
        return View(author);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}