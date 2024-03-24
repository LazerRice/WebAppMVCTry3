using WebAppMVCTry3.Models.Sections;

namespace WebAppMVCTry3.Models.Views;

public class HomeIndexViewModel
{
    public string Title { get; set; } = "";
    public ShowcaseViewModel Showcase { get; set; } = null!;
}
