using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SkrauzodoroTracker.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public TimeSpan Time { get; set; } = TimeSpan.Zero;


    
    public static void AddTask()
    {

    }

    public void OnGet()
    {

    }
}
