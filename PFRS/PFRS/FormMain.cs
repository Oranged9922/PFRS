using PFRS.Simulator;
using PFRS.Simulator.SceneRepresentation;
using System.Diagnostics;
namespace PFRS
{
	public partial class FormMain : Form
	{
		internal SceneSettings _sceneSettings;
		internal Dictionary<string, Bitmap> Tracks;
		internal string SelectedTrack;
#pragma warning disable CS8618 // _sceneSettings not initialized in function, but is intialized in SetDefaults
		public FormMain()
#pragma warning restore CS8618
		{
			InitializeComponent();
			Tracks = LoadTracks();
			SetDefaults();
		}

		internal void SetDefaults()
		{
			TrackPictureBox.Image = Tracks["default.png"];
			SelectedTrack = "default.png";
		}

		private Dictionary<string, Bitmap> LoadTracks()
		{

			Dictionary<string, Bitmap> result = new()
			{
				{ "default.png", new Bitmap("..\\..\\..\\..\\data\\tracks\\default.png") }
			};
			DirectoryInfo d = new DirectoryInfo("..\\..\\..\\..\\data\\tracks\\");

			foreach (var item in d.GetFiles())
			{
				if (item.Name != "default.png")
					try 
					{
						result[item.Name] = new Bitmap("..\\..\\..\\..\\data\\tracks\\" + item.Name);
					}
                    catch
                    {
						Debug.WriteLine($"Warning!{item.Name} could not be loaded as valid track!");
						continue;
                    }
			}
			return result;
		}

		private void ButtonSimulationSettings_Click(object sender, EventArgs e)
		{
			FormSettings fs = new(this);
			fs.Show();
		}

		internal void SetAppliedSettings(FormSettings f)
        {
			SelectedTrack = f.SelectedTrack;
			TrackPictureBox.Image = Tracks[SelectedTrack];
        }
	}
}