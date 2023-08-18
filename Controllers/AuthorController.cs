namespace Bookish;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;
using Bookish.Models.Database;
using System.Linq;

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
        List<AuthorModel> allAuthors = _authorRepo.GetAuthors();
        List<AuthorViewModel> authors =  allAuthors
            .OrderBy(author => author.Name) // Order by author name alphabetically
            .Select(author => new AuthorViewModel(author))
            .ToList();
        return View(authors);
    }
    [HttpGet("Authors/{authorId}")]
    public IActionResult Author(int authorId)
    {
        AuthorModel authorModel = _authorRepo.GetAuthorById(authorId);
        var author = new AuthorViewModel(authorModel);
        return View(author);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}