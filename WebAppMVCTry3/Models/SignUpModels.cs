using System.ComponentModel.DataAnnotations;
using WebAppMVCTry3.Helpers;

namespace WebAppMVCTry3.Models;

public class SignUpModels
{
	[Display(Name = "First name", Prompt = " Enter your first name", Order = 0)]
	[Required(ErrorMessage = "Invalid first name")]
	public string FirstName { get; set; } = null!;

	[Display(Name = "Last name", Prompt = " Enter your last name", Order = 1)]
	[Required(ErrorMessage = "Invalid last name")]
	public string LastName { get; set; } = null!;

	[DataType(DataType.EmailAddress)]
	[Display(Name = "Email", Prompt = " Enter your email address", Order = 2)]
	[RegularExpression("^[^@\\s]+@[^@\\s]+\\.[^@\\s]{2,}$", ErrorMessage = "Invalid email address")]
	public string Email { get; set; } = null!;

	[Display(Name = "Password", Prompt = " Enter your password", Order = 3)]
	[RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", ErrorMessage = "You are using invalid characters")]
	[DataType(DataType.Password)]
	public string Password { get; set; } = null!;

	[Display(Name = "Confirm password", Prompt = " Confirm your password", Order = 4)]
	
	[DataType(DataType.Password)]
	[Compare(nameof(Password), ErrorMessage = "The password dont match")]
	public string ConfirmPassword { get; set; } = null!;

	[Display(Name = "I aggree to the Terms & Conditions", Order = 5)]
	[Required(ErrorMessage = "You have to read the Terms & Conditions")]
	[CheckBoxRequird(ErrorMessage = "You must accept the terms and conditions to proceed")]
	public bool TermsAndConditions { get; set; } = false;
}


