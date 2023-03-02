
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

		public OptionsWindow(OptionsController optionsController)
		{
			InitializeComponent();
			OptionsModel opts = null;
			optionsController.GetOptions().SwitchFirst(
				options => opts = options,
		error => MessageBox.Show(error.Description));
			this.options = opts;

			this.MapOptionsComboBox.ItemsSource = options.MapOptions.Select(x => x.Name);
			this.MapOptionsComboBox.SelectedIndex = 0;

		}

		protected override void OnActivated(EventArgs e)
		{
			this.MapOptionsComboBox.SelectedIndex = options.SelectedMapOption;
			base.OnActivated(e);
		}

		public void SetSelectedMapId(int id)
		{
			this.options.SelectedMapOption = id;
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
			this.Close();
		}
	}
}
