using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCTry3.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            
            ViewData["Title"] = "Profile";
            return View();
        }

        public IActionResult SignIn() 
        {
			[Route("/signin")]
			ViewData["Title"] = "Sign In";
            return View();
        }

        public IActionResult SignUp()
        {
			[Route("/signup")]
			ViewData["Title"] = "Sign Up";
            return View();
        }

        public new IActionResult SignOut() 
        {
			[Route("/signout")]
			return RedirectToAction("Index", "Home");
        }
    }
}
