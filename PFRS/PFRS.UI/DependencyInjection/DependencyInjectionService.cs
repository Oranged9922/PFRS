namespace PFRS.UI.DependencyInjection
{
	using Microsoft.Extensions.DependencyInjection;

	using PFRS.Api.Controllers;
	using PFRS.Application.Facades;
	using PFRS.Application.Operations.Options;

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

			// Facades
			services.AddScoped<OptionsFacade>();

			// Operations
			// Options
			services.AddScoped<GetOptionsOperation>();
			// Maps


			// Repositories
			services.AddSingleton<OptionsRepository>();

			return services.BuildServiceProvider();
		}
	}
}
