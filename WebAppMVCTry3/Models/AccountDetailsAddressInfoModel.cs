using System.ComponentModel.DataAnnotations;

namespace WebAppMVCTry3.Models;

public class AccountDetailsAddressInfoModel
{
	
	[Display(Name = "Adress", Prompt = " Enter your Adress", Order = 0)]
	[Required(ErrorMessage = "Invalid address")]
	public string Addressline_1 { get; set; } = null!;

	[Display(Name = "Address", Prompt = " Enter your address", Order = 1)]
	[Required(ErrorMessage = "Invalid address")]
	public string? Addressline_2 { get; set; }

	[Display(Name = "Postal code", Prompt = " Enter your postalcode", Order = 2)]
	[DataType(DataType.PostalCode)]
	[Required(ErrorMessage = "Invalid postalcode")]
	public string PostalCode { get; set; } = null!;

	[Display(Name = "City", Prompt = " Enter your City name", Order = 3)]
	[Required(ErrorMessage = "City name i required")]
	public string City { get; set; } = null!;
}
