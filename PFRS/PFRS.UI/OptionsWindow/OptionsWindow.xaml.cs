
namespace PFRS.UI
{
	using System;
	using System.ComponentModel;
	using System.Windows;

	using PFRS.Api.Controllers;

	/// <summary>
	/// Interaction logic for OptionsWindow.xaml
	/// </summary>
	public partial class OptionsWindow : Window
	{
		private readonly OptionsController optionsController;

		public OptionsWindow(OptionsController optionsController)
		{
			InitializeComponent();
			this.optionsController = optionsController;
		}

		protected override void OnActivated(EventArgs e)
		{
			base.OnActivated(e);
			UpdateSettings();
		}

		private void UpdateSettings()
		{
			var a = optionsController.GetOptions();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}
	}
}
