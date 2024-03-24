using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCTry3.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Contact us";
        return View();
    }
}
