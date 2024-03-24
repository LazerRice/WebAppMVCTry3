using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCTry3.Controllers;

public class DownloadsController : Controller
{
    public IActionResult Index()
    {
        ViewData["Title"] = "Downloads";
        return View();
    }
}
