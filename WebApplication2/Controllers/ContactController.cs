using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers;

public class ContactController : Controller
{
    private readonly AppDbContext _db;

    public ContactController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        if (TempData["Sent"] != null)
        {
            ViewBag.SuccessMessage = TempData["Sent"];
        }
        return View();
    }

    [HttpPost]
    public IActionResult Send(ContactViewModel vm)
    {
        if (!ModelState.IsValid)
            return View("Index", vm);

        var message = new ContactMessage
        {
            Name = vm.Name,
            Email = vm.Email,
            Subject = vm.Subject,
            Message = vm.Message,
            SentAt = DateTime.Now
        };

        _db.ContactMessages.Add(message);
        _db.SaveChanges();

        TempData["Sent"] = "Your message has been sent. Thank you!";
        return RedirectToAction("Index");
    }
}