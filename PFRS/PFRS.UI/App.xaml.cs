namespace PFRS.UI
{
	using System;
	using System.IO;
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
		private readonly RobotsController robotsController;
		private ServiceProvider serviceProvider;

		public App()
		{
			ServiceCollection services = new ServiceCollection();
			serviceProvider = DependencyInjectionService.ConfigureServices(services);
			this.mapsController = serviceProvider.GetService<MapsController>() ?? throw new Exception("Couldn't get MapsController.");
			this.optionsController = serviceProvider.GetService<OptionsController>() ?? throw new Exception("Couldn't get OptionsController.");
			this.robotsController = serviceProvider.GetService<RobotsController>() ?? throw new Exception("Couldn't get RobotsController.");
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
			DirectoryInfo mapsDirectoryInfo = new(@"../../../../db/maps");
			foreach (var item in mapsDirectoryInfo.EnumerateFiles())
			{
				mapsController.AddMap(item.FullName);
			}

			DirectoryInfo robotsDirectoryInfo = new(@"../../../../db/robots");
			foreach (var item in robotsDirectoryInfo.EnumerateDirectories())
			{
				robotsController.AddRobot(item.FullName);
			}
		}
	}
}
