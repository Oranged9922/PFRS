namespace PFRS.UI
{
	using System.Windows;

	using Microsoft.Extensions.DependencyInjection;

	using PFRS.UI.DependencyInjection;

	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private ServiceProvider serviceProvider;

		public App()
		{
			ServiceCollection services = new ServiceCollection();
			serviceProvider = DependencyInjectionService.ConfigureServices(services);
		}

		private void OnStartup(object sender, StartupEventArgs e)
		{
			var mainWindow = serviceProvider.GetService<MainWindow>();
#pragma warning disable CS8602 // Dereference of a possibly null reference.
			mainWindow.Show();
#pragma warning restore CS8602 // Dereference of a possibly null reference.
		}
	}
}
