internal class Program
{
	private static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		// Add services to the container.
		builder.Services.AddDependencies(builder.Configuration);

		var app = builder.Build();

		// Enable Swagger only in Development
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger(); // Swashbuckle.AspNetCore
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();
		app.UseCors(policy =>
		{
			policy.AllowAnyOrigin()
			.AllowAnyHeader()
			.AllowAnyMethod()
			.WithExposedHeaders("X-Pagination"); ;
		});

		app.UseAuthorization();
		app.UseAuthentication();

		app.MapControllers();

		app.Run();
	}
}