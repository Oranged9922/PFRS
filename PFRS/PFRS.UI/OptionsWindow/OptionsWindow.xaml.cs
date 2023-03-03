
namespace PFRS.UI
{
	using System;
	using System.ComponentModel;
	using System.Linq;
	using System.Windows;

	using PFRS.Api.Controllers;
	using PFRS.Domain;

	/// <summary>
	/// Interaction logic for OptionsWindow.xaml
	/// </summary>
	public partial class OptionsWindow : Window
	{
		private readonly OptionsModel options;

		public int SelectedMap { get => options.SelectedMapOption; }
		public int SelectedRobot { get => options.SelectedRobotOption; }

		public OptionsWindow(OptionsController optionsController)
		{
			InitializeComponent();
			OptionsModel opts = null;
			optionsController.GetOptions().SwitchFirst(
				options => opts = options,
		error => MessageBox.Show(error.Description));
			this.options = opts ?? throw new Exception();

			this.MapOptionsComboBox.ItemsSource = options.MapOptions.Select(x => x.Name);
			this.MapOptionsComboBox.SelectedIndex = 0;
			this.RobotOptionsComboBox.ItemsSource = options.RobotOptions.Select(x => x.Name);
			this.RobotOptionsComboBox.SelectedIndex = 0;

		}

		protected override void OnActivated(EventArgs e)
		{
			this.MapOptionsComboBox.SelectedIndex = options.SelectedMapOption;
			this.RobotOptionsComboBox.SelectedIndex = options.SelectedRobotOption;
			base.OnActivated(e);
		}

		public void SetSelectedMapId(int id)
		{
			this.options.SelectedMapOption = id;
		}

		public void SetSelectedRobotId(int id)
		{
			this.options.SelectedRobotOption = id;
		}
		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
			base.OnClosing(e);
		}

		private void SaveOptions_ButtonClick(object sender, RoutedEventArgs e)
		{
			this.options.SelectedMapOption = this.MapOptionsComboBox.SelectedIndex;
			this.options.SelectedRobotOption = this.RobotOptionsComboBox.SelectedIndex;
			this.Close();
		}

	}
}
