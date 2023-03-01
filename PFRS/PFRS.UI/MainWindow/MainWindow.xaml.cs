namespace PFRS.UI
{
	using System.Windows;

	using PFRS.Api.Controllers;

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly OptionsWindow optionsWindow;
		private readonly MapsController mapsController;

		public MainWindow(
			OptionsWindow optionsWindow,
			MapsController mapsController)
		{
			this.optionsWindow = optionsWindow;
			this.mapsController = mapsController;
			InitializeComponent();
		}

		private void OptionsButton_Click(object sender, RoutedEventArgs e)
		{
			if (!this.optionsWindow.IsVisible)
			{
				this.optionsWindow.Show();
			}
		}
	}
}
