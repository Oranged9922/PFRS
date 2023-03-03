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
		private readonly RobotsController robotsController;

		private MapModel map;
		private RobotModel robot;
		public MainWindow(
			OptionsWindow optionsWindow,
			MapsController mapsController,
			RobotsController robotsController)
		{
			this.optionsWindow = optionsWindow;
			this.mapsController = mapsController;
			this.robotsController = robotsController;

			InitializeComponent();

			this.optionsWindow.Closing += OptionsWindow_Closing;

			InitializeDefault();
		}

		private void InitializeDefault()
		{
			optionsWindow.SetSelectedMapId(0);
			optionsWindow.SetSelectedRobotId(0);
			SetMap();
			SetRobot();
		}

		private void SetRobot()
		{
			robotsController.GetRobotById(optionsWindow.SelectedRobot).SwitchFirst(
				robot => this.robot = robot,
				error =>
				MessageBox.Show($"{error.Description}\n" +
							   $"EntityType: {typeof(RobotModel)}\n" +
							   $"Id: {optionsWindow.SelectedRobot}",
							   caption: error.Type.ToString()));
			if (robot is not null)
			{
				this.RobotImageControl.Source = new BitmapImage(
					new Uri(robot.ImagePath));
				this.RobotImageControl.Height = robot.Height;
				this.RobotImageControl.Width = robot.Width;

			}
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
					new Uri(map.Path));
				this.PathImageControl.Height = map.Height;
				this.PathImageControl.Width = map.Width;
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
