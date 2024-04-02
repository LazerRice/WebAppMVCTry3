using System.ComponentModel.DataAnnotations;
namespace WebAppMVCTry3.Helpers;

public class CheckBoxRequird : ValidationAttribute
{
	public override bool IsValid(object? value) => value is bool b && b;
}
