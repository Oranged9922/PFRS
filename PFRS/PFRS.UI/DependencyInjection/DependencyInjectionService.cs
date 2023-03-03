namespace PFRS.UI.DependencyInjection
{
	using Microsoft.Extensions.DependencyInjection;

	using PFRS.Api.Controllers;
	using PFRS.Application.Facades;
	using PFRS.Application.Interfaces;
	using PFRS.Application.Operations.Maps;
	using PFRS.Application.Operations.Options;
	using PFRS.Application.Operations.Robots;
	using PFRS.Infrastructure;

	public static class DependencyInjectionService
	{
		public static ServiceProvider ConfigureServices(this ServiceCollection services)
		{

			// Windows
			services.AddSingleton<MainWindow>();
			services.AddSingleton<OptionsWindow>();

			// Controllers
			services.AddScoped<OptionsController>();
			services.AddScoped<MapsController>();
			services.AddScoped<RobotsController>();

			// Facades
			services.AddScoped<OptionsFacade>();
			services.AddScoped<MapsFacade>();
			services.AddScoped<RobotsFacade>();

			// Repositories
			services.AddSingleton<IMapsRepository, MapsRepository>();
			services.AddSingleton<IRobotsRepository, RobotsRepository>();
			// Operations
			// Options
			services.AddScoped<GetOptionsOperation>();

			// Maps
			services.AddScoped<GetMapByIdOperation>();
			services.AddScoped<AddMapOperation>();

			// Robots
			services.AddScoped<GetRobotByIdOperation>();
			services.AddScoped<AddRobotOperation>();

			return services.BuildServiceProvider();
		}
	}
}
