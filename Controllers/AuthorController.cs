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
        List<AuthorModel> allAuthors = _authorRepo.GetAuthors();
        List<AuthorViewModel> authors = new List<AuthorViewModel>(allAuthors);
        var author1 = new AuthorViewModel("A. A. Milne", 1882, new List<BookViewModel>());
        author1.CoverPhotoUrl = "https://cdn.britannica.com/22/66322-050-9A24E091/AA-Milne-1920.jpg";
        author1.Bio = "Alan Alexander Milne was an English writer best known for his books about the teddy bear Winnie-the-Pooh, as well as for children's poetry. Milne was primarily a playwright before the huge success of Winnie-the-Pooh overshadowed all his previous work.";
        var author2 = new AuthorViewModel("Chris Broad", 1990, new List<BookViewModel>());
        author2.CoverPhotoUrl = "https://static.tvtropes.org/pmwiki/pub/images/chris_broad_6.jpg";
        author2.Bio = "Chris Broad is a British filmmaker and founder of the Abroad in Japan Youtube channel, one of the largest foreign Youtube channels in Japan with over 2.5 million subscribers and 400 million views. Over 10 years and 200 videos, Chris has visited all of Japan's 47 prefectures, focussing Abroad in Japan on travel, culture, food and covered contemporary issues through documentaries on the Fukushima nuclear disaster and the Tohoku earthquake and tsunami. His experiences have made him a sought after voice on life inside Japan, featured on the BBC, Tedx, NHK and the Japan Times.";
        List<AuthorViewModel> authors = new List<AuthorViewModel>();
        authors.Add(author1);
        authors.Add(author2);
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