namespace PFRS.UI
{
	using System.Windows;

	using Microsoft.Extensions.DependencyInjection;

	using PFRS.Api.Controllers;
	using PFRS.UI.DependencyInjection;

	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private readonly MapsController mapsController;
		private readonly OptionsController optionsController;
		private ServiceProvider serviceProvider;

		public App()
		{
			ServiceCollection services = new ServiceCollection();
			serviceProvider = DependencyInjectionService.ConfigureServices(services);
			this.mapsController = serviceProvider.GetService<MapsController>();
			this.optionsController = serviceProvider.GetService<OptionsController>();
		}

		private void OnStartup(object sender, StartupEventArgs e)
		{
			LoadDefaultsToRepository();

			var mainWindow = serviceProvider.GetService<MainWindow>();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
			mainWindow.Show();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
		}

		/// <summary>
		/// Perform all initialization of default entities to repository etc. here
		/// </summary>
		private void LoadDefaultsToRepository()
		{
			mapsController.AddMap(@"../../../../db/maps/map1.png");
			mapsController.AddMap(@"../../../../db/maps/map2.png");
			mapsController.AddMap(@"../../../../db/maps/map3.png");
			mapsController.AddMap(@"../../../../db/maps/map4.png");
		}
	}
}
