using Microsoft.AspNetCore.HttpLogging;

class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);
		builder.Services.AddRazorPages();
		builder.Services.AddW3CLogging(logging => {
			logging.LoggingFields = W3CLoggingFields.All;
			logging.AdditionalRequestHeaders.Add("x-forwarded-for");
		});
		var app = builder.Build();
		if (!app.Environment.IsDevelopment())
		{
			app.UseExceptionHandler("/Error");
			app.UseHsts();
		}
		app.UseHttpsRedirection();
		app.UseRouting();
		app.UseAuthorization();
		app.MapStaticAssets();
		app.UseW3CLogging();
		app.MapRazorPages()
		   .WithStaticAssets();
		app.Run();
	}
}