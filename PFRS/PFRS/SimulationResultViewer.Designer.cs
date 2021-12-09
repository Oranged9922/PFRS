namespace PFRS
{
    partial class SimulationResultViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Slider = new System.Windows.Forms.TrackBar();
            this.LabelBegin = new System.Windows.Forms.Label();
            this.LabelEnd = new System.Windows.Forms.Label();
            this.PictureBoxTrack = new System.Windows.Forms.PictureBox();
            this.PictureBoxRobot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRobot)).BeginInit();
            this.SuspendLayout();
            // 
            // Slider
            // 
            this.Slider.Location = new System.Drawing.Point(12, 574);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(414, 45);
            this.Slider.TabIndex = 0;
            this.Slider.Scroll += new System.EventHandler(this.Slider_Scroll);
            // 
            // LabelBegin
            // 
            this.LabelBegin.AutoSize = true;
            this.LabelBegin.Location = new System.Drawing.Point(12, 604);
            this.LabelBegin.Name = "LabelBegin";
            this.LabelBegin.Size = new System.Drawing.Size(13, 15);
            this.LabelBegin.TabIndex = 1;
            this.LabelBegin.Text = "0";
            // 
            // LabelEnd
            // 
            this.LabelEnd.AutoSize = true;
            this.LabelEnd.Location = new System.Drawing.Point(413, 604);
            this.LabelEnd.Name = "LabelEnd";
            this.LabelEnd.Size = new System.Drawing.Size(13, 15);
            this.LabelEnd.TabIndex = 2;
            this.LabelEnd.Text = "1";
            // 
            // PictureBoxTrack
            // 
            this.PictureBoxTrack.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxTrack.Name = "PictureBoxTrack";
            this.PictureBoxTrack.Size = new System.Drawing.Size(414, 556);
            this.PictureBoxTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxTrack.TabIndex = 3;
            this.PictureBoxTrack.TabStop = false;
            // 
            // PictureBoxRobot
            // 
            this.PictureBoxRobot.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxRobot.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxRobot.Name = "PictureBoxRobot";
            this.PictureBoxRobot.Size = new System.Drawing.Size(414, 556);
            this.PictureBoxRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxRobot.TabIndex = 4;
            this.PictureBoxRobot.TabStop = false;
            // 
            // SimulationResultViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 631);
            this.Controls.Add(this.PictureBoxRobot);
            this.Controls.Add(this.PictureBoxTrack);
            this.Controls.Add(this.LabelEnd);
            this.Controls.Add(this.LabelBegin);
            this.Controls.Add(this.Slider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SimulationResultViewer";
            this.Text = "SimulationResultViewer";
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxRobot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar Slider;
        private Label LabelBegin;
        private Label LabelEnd;
        private PictureBox PictureBoxTrack;
        private PictureBox PictureBoxRobot;
    }
}