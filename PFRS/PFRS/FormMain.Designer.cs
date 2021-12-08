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
            // FormMain
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ButtonSimulationSettings);
            this.Controls.Add(this.TrackPictureBox);
            this.Name = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.TrackPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox TrackPictureBox;
        private Button ButtonSimulationSettings;
    }
}