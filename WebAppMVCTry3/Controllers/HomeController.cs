using Microsoft.AspNetCore.Mvc;
using WebAppMVCTry3.Models.Components;
using WebAppMVCTry3.Models.Sections;
using WebAppMVCTry3.Models.Views;

namespace WebAppMVCTry3.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
       
        var viewModel = new HomeIndexViewModel
        {
            Title = "Ultimate Task Managemnt Assistant",
            Showcase = new ShowcaseViewModel
            {
                Id = "showcase",
                ShowcaseImage = new() { ImageUrl = "images/taskmasterimg.svg", AltText = "Task Management Assistant" },
                Title = "Ultimate Task Managemnt Assistant",
                Text = "We offer you a new generation of task management systm. Plan, manage & track all you tasks in one flexibale tool",
                Link = new() { ControllerName  = "Download", ActionName = "Index", Text = "Get started for free" },
                BrandsText = "Largest companies use our tool to work efficentlty",
                Brands =
                [
                    new() { ImageUrl = "images/logo/logo1.svg", AltText = "Logo 1" },
                    new() { ImageUrl = "images/logo/logo2.svg", AltText = "Logo 2" },
                    new() { ImageUrl = "images/logo/logo3.svg", AltText = "Logo 3" },
                    new() { ImageUrl = "images/logo/logo4.svg", AltText = "Logo 4" },
                ]
                
                
                
            }
        };

        ViewData["Title"] = viewModel.Title;
        return View(viewModel);
    }

}
