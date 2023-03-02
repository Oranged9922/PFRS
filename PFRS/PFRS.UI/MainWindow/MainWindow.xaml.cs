namespace PFRS.UI
{
	using System;
	using System.ComponentModel;
	using System.Windows;
	using System.Windows.Media.Imaging;

	using PFRS.Api.Controllers;
	using PFRS.Domain;

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly OptionsWindow optionsWindow;
		private readonly MapsController mapsController;

		private MapModel map;

		public MainWindow(
			OptionsWindow optionsWindow,
			MapsController mapsController)
		{
			this.optionsWindow = optionsWindow;
			this.mapsController = mapsController;
			InitializeComponent();

			this.optionsWindow.Closing += OptionsWindow_Closing;

			InitializeDefault();
		}

		private void InitializeDefault()
		{
			optionsWindow.SetSelectedMapId(0);
			SetMap();
		}

		private void SetMap()
		{
			mapsController.GetMapById(optionsWindow.SelectedMap).SwitchFirst(
							map => this.map = map,
							   error =>
							   MessageBox.Show($"{error.Description}\n" +
							   $"EntityType: {typeof(MapModel)}\n" +
							   $"Id: {optionsWindow.SelectedMap}",
							   caption: error.Type.ToString()));
			if (map is not null)
			{
				this.PathImageControl.Source = new BitmapImage(
					new Uri(Environment.CurrentDirectory + "../" + map.Path));
			}
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			this.optionsWindow.Close();
			base.OnClosing(e);
			Environment.Exit(0);
		}
		private void OptionsWindow_Closing(object sender, CancelEventArgs e)
		{
			SetMap();
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
