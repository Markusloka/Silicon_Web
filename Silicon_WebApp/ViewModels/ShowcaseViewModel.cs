
namespace Silicon_WebApp.ViewModels;

public class ShowcaseViewModel
{
    public string? Id { get; set; }
    public ImageViewModel ShowcaseImage { get; set; } = null!;
    public string? Title { get; set; }
    public string? Text { get; set; }

    public string? LargestBrandText { get; set; }
    public LinkViewModel Link { get; set; } = new LinkViewModel();
}
