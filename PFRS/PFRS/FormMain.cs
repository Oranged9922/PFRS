using Analyzer;
using Common.HardwareRepresentation;

using System.Diagnostics;
namespace PFRS
{
    public partial class FormMain : Form
	{
		/// <summary>
		/// Boolean representing whether settings window is open
		/// </summary>
		internal bool SettingsOpen = false;
		/// <summary>
		/// Stores images of different tracks
		/// </summary>
		internal Dictionary<string, Bitmap> Tracks;
		/// <summary>
		/// Stores Robots that are implemented
		/// </summary>
		internal Dictionary<string, IRobot> Robots;
		/// <summary>
		/// List of scripts that are loaded
		/// </summary>
		internal List<Script> scripts = new();
		/// <summary>
		/// ID of currently selected script, stored in scripts list at index of that ID
		/// </summary>
		internal int SelectedScript;
		/// <summary>
		/// name of currently selected track
		/// </summary>
		internal string SelectedTrack;
		/// <summary>
		/// Simulation time in seconds, default set to 30 seconds
		/// </summary>
		public int SimTime { get; internal set; } = 30;

        public FormMain()
		{
			InitializeComponent();
			Tracks = LoadTracks();
			SetDefaults();

		}

		/// <summary>
		/// Sets default values used in the 
		/// </summary>
		internal void SetDefaults()
		{
			TrackPictureBox.Image = Tracks["default.png"];
			SelectedTrack = "default.png";
		}

		/// <summary>
		/// Loads all tracks images from data\tracks\ folder
		/// </summary>
		/// <returns>Dictionary containing name of the track and corresponding Bitmap representation</returns>
		/// TODO : add check for same names of files (will cause exception throw)
		private Dictionary<string, Bitmap> LoadTracks()
		{
			// add default.png, this one has to be there
			Dictionary<string, Bitmap> result = new()
			{
				{ "default.png", new Bitmap("data\\tracks\\default.png") }
			};
			DirectoryInfo d = new DirectoryInfo("data\\tracks\\");

			foreach (var item in d.GetFiles())
			{
				if (item.Name != "default.png")
					try 
					{
						result[item.Name] = new Bitmap("data\\tracks\\" + item.Name);
					}
                    catch
                    {
						Debug.WriteLine($"Warning!{item.Name} could not be loaded as valid track!");
						continue;
                    }
			}
			return result;
		}
		/// <summary>
		/// Opens settings window menu
		/// </summary>
		private void ButtonSimulationSettings_Click(object sender, EventArgs e)
		{
			if (!SettingsOpen)
			{
				FormSettings fs = new(this);
				fs.Show();
			}
		}

		/// <summary>
		/// Sets applied settings from settings window when Save button is pressed
		/// </summary>
		/// <param name="f"></param>
		internal void SetAppliedSettings(FormSettings f)
        {
			SelectedTrack = f.SelectedTrack;
			TrackPictureBox.Image = Tracks[SelectedTrack];
        }

		/// <summary>
		/// Opens and loads script to memory 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void ButtonLoadScript_Click(object sender, EventArgs e)
        {
			string filePath;
			string fileContent;
			using (OpenFileDialog openFileDialog = new()) {

				openFileDialog.InitialDirectory = "data\\scripts\\";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					//Get the path of specified file
					filePath = openFileDialog.FileName;

					//Read the contents of the file into a stream
					var fileStream = openFileDialog.OpenFile();

					using (StreamReader reader = new StreamReader(fileStream))
					{
						fileContent = reader.ReadToEnd();
						fileContent = fileContent.ReplaceLineEndings("\n");
						scripts.Add(new(scripts.Count, filePath, fileContent));
						// save script to Scripts
						ListBoxScripts.BeginUpdate();
						ListBoxScripts.Items.Add(scripts[scripts.Count-1].Name);
						ListBoxScripts.EndUpdate();
					}
				}
			}
        }
		/// <summary>
		/// Changes selected script and sets it for display
		/// </summary>
        private void ListBoxScripts_SelectedIndexChanged(object sender, EventArgs e)
        {
			if (this.ListBoxScripts.SelectedIndex == -1) return;
			SelectedScript = this.ListBoxScripts.SelectedIndex;
			this.TextBox.Text = GetScript(this.ListBoxScripts.SelectedIndex).WorkingContents;
		}

		/// <summary>
		/// Returns script with the specified ID
		/// </summary>
		/// <param name="ID"></param>
		/// <returns></returns>
		private Script GetScript(int ID)
		{
			if(scripts.Count == 0) return null;
			if (ID == -1) return null;
			return scripts[ID];
		
		}


		
		private void TextBox_KeyDown(object sender, KeyEventArgs e)
		{
			// Saving edited script
			if (scripts.Count == 0) return;
			if (!scripts[SelectedScript].Saved
				 // save edited script
				 && e.Control && e.KeyCode == Keys.S)
			{
				SaveScript();
			}
		}

		private void SaveScript()
        {
			File.WriteAllTextAsync(scripts[SelectedScript].Path, scripts[SelectedScript].WorkingContents);
			MessageBox.Show("Saved");
			scripts[SelectedScript].Contents = scripts[SelectedScript].WorkingContents;


		}

		private void TextBox_Leave(object sender, EventArgs e)
        {
			if (SelectedScript == -1) return;
			GetScript(SelectedScript).WorkingContents = this.TextBox.Text;

			// Add start to ListBox when file is edited and not saved
			if (this.TextBox.Text != GetScript(SelectedScript).Contents)
            {
                if (!ListBoxScripts.Items[SelectedScript].ToString().EndsWith('*'))
                {
                    ListBoxScripts.Items[SelectedScript] = ListBoxScripts.Items[SelectedScript].ToString() + "*";

                }
            }
            else 
			{ 
                if (ListBoxScripts.Items[SelectedScript].ToString().EndsWith('*'))
                {
                    ListBoxScripts.Items[SelectedScript] = ListBoxScripts.Items[SelectedScript].ToString().Trim('*');
                }
				return;
            }
		}

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
			if (SelectedScript == 0 && scripts.Count == 0) return;
			
        }

        private void ButtonRemoveScript_Click(object sender, EventArgs e)
        {
			if (scripts.Count == 0 || scripts[SelectedScript] == null) return;
			var dialogResult = MessageBox.Show($"Are you sure you want to remove {GetScript(SelectedScript).Name}?", "Remove Script", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes)
            {
                if (!GetScript(SelectedScript).Saved)
                {
					var notSaved = MessageBox.Show("Script is not saved. Do you want to save before removing from the list?", "Remove Script", MessageBoxButtons.YesNoCancel);
					if(notSaved == DialogResult.Yes)
                    {
						SaveScript();
						RemoveScript(SelectedScript);
                    }
					else if(notSaved == DialogResult.No)
                    {
						RemoveScript(SelectedScript);
                    }
					else if(notSaved == DialogResult.Cancel)
                    {
						return;
                    }
                }
                else
                {
					RemoveScript(SelectedScript);
				}
            }
            else
            {
				return;
            }
        }

        private void RemoveScript(int selectedScript)
		{
			ListBoxScripts.Items.RemoveAt(selectedScript);
			scripts.RemoveAt(selectedScript);
			TextBox.Text = string.Empty;
			SelectedScript = 0;
        }

        private void ButtonRunSingleScript_Click(object sender, EventArgs e)
        {
            ScriptAnalyzer scriptAnalyzer = new Analyzer.ScriptAnalyzer();
			var task = scriptAnalyzer.CompileScript(GetScript(SelectedScript).Contents);

		}
    }
}