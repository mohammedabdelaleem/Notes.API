using Mapster;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Notes.API.Data;
using Notes.API.Implementations;
using Notes.API.Reposotories;
using System.Reflection;

namespace Notes.API;

public static class DependencyInjection
{
	public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
	{
		// Register Controllers
		services.AddControllers();

		// Register Mapster 
		var mappingConfigurations = TypeAdapterConfig.GlobalSettings;
		mappingConfigurations.Scan(Assembly.GetExecutingAssembly());
		services.AddSingleton<IMapper>(new Mapper(mappingConfigurations));


		services
			.AddSwaggerConfig()
			.AddDatabaseConfig(configuration);


		services.AddScoped<IUnitOfWork, UnitOfWork>();
		services.AddScoped<INoteRepository, NoteRepository>();


		return services;
	}

	private static IServiceCollection AddSwaggerConfig(this IServiceCollection services)
	{
		services.AddEndpointsApiExplorer();
		services.AddSwaggerGen(); // Enable Swagger UI
		return services;
	}

	private static IServiceCollection AddDatabaseConfig(this IServiceCollection services, IConfiguration configuration)
	{
		services.AddDbContext<AppDbContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("constr"));
		});

		return services;
	}
}
