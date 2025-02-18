using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_lesson.Pages;

public class IndexModel(ILogger<IndexModel> logger, IConfiguration configuration) : PageModel
{
	public void OnGet()
	{
		ViewData["Message"] = configuration["Message"];
		logger.LogInformation("Index page visited");
	}
}