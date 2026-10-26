using BookClubManager.Data.Models;
using BookClubManager.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookClubManager.Controllers;

public class ClubsController : Controller
{
    private readonly IClubMethods clubMethods;

    public ClubsController(IClubMethods clubMethods)
    {
        this.clubMethods = clubMethods;
    }

    public async Task<IActionResult> Index()
    {
        var clubs = await clubMethods.GetAllAsync();

        return View(clubs);

    }

    public async Task<IActionResult> Details(int id)
    {
        var club = await clubMethods.GetByIdAsync(id);

        if (club == null)
        {
            return NotFound();
        }


        return View(club);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Club club)
    {
        if (!ModelState.IsValid)
        {
            return View(club);
        }


        await clubMethods.AddAsync(club);


        return RedirectToAction(nameof(Index));
    }
}