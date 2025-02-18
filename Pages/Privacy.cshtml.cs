using Microsoft.AspNetCore.Mvc.RazorPages;

namespace azure_app_lesson.Pages;

public class PrivacyModel(ILogger<PrivacyModel> logger) : PageModel
{
	public void OnGet()
	{
		logger.LogInformation("Privacy page visited");
	}
}