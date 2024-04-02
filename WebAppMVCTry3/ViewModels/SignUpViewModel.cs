using WebAppMVCTry3.Models;

namespace WebAppMVCTry3.ViewModels;

public class SignUpViewModel
{
	public string Title { get; set; } = "Sign Up";
	public SignUpModels Form { get; set; } = new SignUpModels();

}
