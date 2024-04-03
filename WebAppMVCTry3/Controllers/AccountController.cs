using Microsoft.AspNetCore.Mvc;
using WebAppMVCTry3.ViewModels;

namespace WebAppMVCTry3.Controllers;

public class AccountController : Controller
{
	[Route("/Account")]
	public IActionResult Details() 
	{
		var viewModel = new AccountDetailsViewModel();
		return View(viewModel); 
	}


	[HttpPost]

	public IActionResult BasicInfo(AccountDetailsViewModel viewModel)
	{
		return RedirectToAction(nameof(Details), viewModel);
	}

	[HttpPost]

	public IActionResult AddressInfo(AccountDetailsViewModel viewModel)
	{
		return RedirectToAction(nameof(Details), viewModel);
	}


}