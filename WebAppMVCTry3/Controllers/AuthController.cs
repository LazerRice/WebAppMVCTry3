using Microsoft.AspNetCore.Mvc;
using WebAppMVCTry3.ViewModels;

namespace WebAppMVCTry3.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Profile";
            return View();
        }

		[Route("/signup")]
		[HttpGet]
		public IActionResult SignUp()
		{
			var viewModel = new SignUpViewModel();
			return View(viewModel);
		}

		[Route("/signup")]
		[HttpPost]
		public IActionResult SignUp(SignUpViewModel viewModel)
		{
			if(!ModelState.IsValid)
				return View(viewModel);

			return RedirectToAction("SignIn" , "Auth");
		}


		[Route("/signin")]
		public IActionResult SignIn() 
        {
			
			ViewData["Title"] = "Sign In";
            return View();
        }
	
		[Route("/signout")]
		public new IActionResult SignOut() 
        {
			
			return RedirectToAction("Index", "Home");
        }
    }
}
