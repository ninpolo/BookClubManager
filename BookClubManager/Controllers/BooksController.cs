using BookClubManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookClubManager.Controllers;

public class BooksController : Controller
{
    private readonly IBookMethods bookMethods;

    public BooksController(IBookMethods bookMethods)
    {
        this.bookMethods = bookMethods;
    }

    public async Task<IActionResult> Index()
    {
        var books = await bookMethods.GetAllAsync();

        return View(books);
    }
}