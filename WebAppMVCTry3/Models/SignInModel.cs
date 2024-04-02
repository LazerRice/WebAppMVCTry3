using System.ComponentModel.DataAnnotations;

namespace WebAppMVCTry3.Models;

public class SignInModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email", Prompt = " Enter your email address", Order = 0)]
    [Required(ErrorMessage = "Invalid email address")]
    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = " Enter your password", Order = 1)]
    [Required(ErrorMessage = "You are using invalid characters")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name ="Remember me", Order = 2)]
    public bool RememberMe { get; set; }
}
