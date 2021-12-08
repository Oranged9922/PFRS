namespace PFRS
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.TrackPictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonSimulationSettings = new System.Windows.Forms.Button();
            this.ButtonLoadScript = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.ButtonSaveScript = new System.Windows.Forms.Button();
            this.ListBoxScripts = new System.Windows.Forms.ListBox();
            this.ButtonRemoveScript = new System.Windows.Forms.Button();
            this.ButtonRunSingleScript = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TrackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TrackPictureBox
            // 
            resources.ApplyResources(this.TrackPictureBox, "TrackPictureBox");
            this.TrackPictureBox.Name = "TrackPictureBox";
            this.TrackPictureBox.TabStop = false;
            // 
            // ButtonSimulationSettings
            // 
            resources.ApplyResources(this.ButtonSimulationSettings, "ButtonSimulationSettings");
            this.ButtonSimulationSettings.Name = "ButtonSimulationSettings";
            this.ButtonSimulationSettings.UseVisualStyleBackColor = true;
            this.ButtonSimulationSettings.Click += new System.EventHandler(this.ButtonSimulationSettings_Click);
            // 
            // ButtonLoadScript
            // 
            resources.ApplyResources(this.ButtonLoadScript, "ButtonLoadScript");
            this.ButtonLoadScript.Name = "ButtonLoadScript";
            this.ButtonLoadScript.UseVisualStyleBackColor = true;
            this.ButtonLoadScript.Click += new System.EventHandler(this.ButtonLoadScript_Click);
            // 
            // TextBox
            // 
            resources.ApplyResources(this.TextBox, "TextBox");
            this.TextBox.Name = "TextBox";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.TextBox.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // ButtonSaveScript
            // 
            resources.ApplyResources(this.ButtonSaveScript, "ButtonSaveScript");
            this.ButtonSaveScript.Name = "ButtonSaveScript";
            this.ButtonSaveScript.UseVisualStyleBackColor = true;
            // 
            // ListBoxScripts
            // 
            this.ListBoxScripts.FormattingEnabled = true;
            resources.ApplyResources(this.ListBoxScripts, "ListBoxScripts");
            this.ListBoxScripts.Name = "ListBoxScripts";
            this.ListBoxScripts.SelectedIndexChanged += new System.EventHandler(this.ListBoxScripts_SelectedIndexChanged);
            // 
            // ButtonRemoveScript
            // 
            resources.ApplyResources(this.ButtonRemoveScript, "ButtonRemoveScript");
            this.ButtonRemoveScript.Name = "ButtonRemoveScript";
            this.ButtonRemoveScript.UseVisualStyleBackColor = true;
            this.ButtonRemoveScript.Click += new System.EventHandler(this.ButtonRemoveScript_Click);
            // 
            // ButtonRunSingleScript
            // 
            resources.ApplyResources(this.ButtonRunSingleScript, "ButtonRunSingleScript");
            this.ButtonRunSingleScript.Name = "ButtonRunSingleScript";
            this.ButtonRunSingleScript.UseVisualStyleBackColor = true;
            this.ButtonRunSingleScript.Click += new System.EventHandler(this.ButtonRunSingleScript_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ButtonRunSingleScript);
            this.Controls.Add(this.ButtonRemoveScript);
            this.Controls.Add(this.ListBoxScripts);
            this.Controls.Add(this.ButtonSaveScript);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ButtonLoadScript);
            this.Controls.Add(this.ButtonSimulationSettings);
            this.Controls.Add(this.TrackPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.TrackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox TrackPictureBox;
        private Button ButtonSimulationSettings;
        private Button ButtonLoadScript;
        private RichTextBox TextBox;
        private Button ButtonSaveScript;
        private ListBox ListBoxScripts;
        private Button ButtonRemoveScript;
        private Button ButtonRunSingleScript;
        private Button button1;
    }
}