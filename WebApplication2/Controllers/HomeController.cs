using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _db;

    public HomeController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var model = new HomeViewModel
        {
            Courses = _db.Courses.Include(c => c.Trainer).Take(3).ToList(),
            Trainers = _db.Trainers.Take(3).ToList(),
            Testimonials = _db.Testimonials.ToList(),
            Stats = _db.SiteStats.FirstOrDefault()
        };

        ViewBag.PageTitle = "Welcome to Mentor";

        return View(model);
    }

    public IActionResult About()
    {
        ViewBag.PageTitle = "About Us";
        return View();
    }

    public IActionResult Pricing()
    {
        ViewBag.PageTitle = "Pricing";
        ViewData["ActivePage"] = "Pricing";
        return View();
    }
}