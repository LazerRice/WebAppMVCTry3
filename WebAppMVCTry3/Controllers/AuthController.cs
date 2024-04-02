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
		[HttpGet]
		public IActionResult SignIn() 
        {

			var ViewData = new SignInViewModel();
            return View();
        }

		[Route("/signin")]
		[HttpPost]
		public IActionResult Signin(SignInViewModel viewModel)
		{
			if (!ModelState.IsValid)
			{
				viewModel.ErrorMessage = "Incorrect email or password";
				return View(viewModel);

			}
			

			return RedirectToAction("Account", "Index");
		}

		[Route("/signout")]
		public new IActionResult SignOut() 
        {
			
			return RedirectToAction("Index", "Home");
        }
    }
}
