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
            this.LabelFrameNumber = new System.Windows.Forms.Label();
            this.LabelPosition = new System.Windows.Forms.Label();
            this.LabelDirection = new System.Windows.Forms.Label();
            this.LabelFN = new System.Windows.Forms.Label();
            this.LabelPos = new System.Windows.Forms.Label();
            this.LabelDir = new System.Windows.Forms.Label();
            this.PictureBoxRobot = new System.Windows.Forms.PictureBox();
            this.LabelSensrs = new System.Windows.Forms.Label();
            this.LabelSensors = new System.Windows.Forms.Label();
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
            // LabelFrameNumber
            // 
            this.LabelFrameNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelFrameNumber.AutoSize = true;
            this.LabelFrameNumber.Location = new System.Drawing.Point(518, 13);
            this.LabelFrameNumber.Name = "LabelFrameNumber";
            this.LabelFrameNumber.Size = new System.Drawing.Size(84, 15);
            this.LabelFrameNumber.TabIndex = 0;
            this.LabelFrameNumber.Text = "FrameNumber";
            // 
            // LabelPosition
            // 
            this.LabelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelPosition.AutoSize = true;
            this.LabelPosition.Location = new System.Drawing.Point(518, 28);
            this.LabelPosition.Name = "LabelPosition";
            this.LabelPosition.Size = new System.Drawing.Size(50, 15);
            this.LabelPosition.TabIndex = 5;
            this.LabelPosition.Text = "Position";
            // 
            // LabelDirection
            // 
            this.LabelDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelDirection.AutoSize = true;
            this.LabelDirection.Location = new System.Drawing.Point(518, 43);
            this.LabelDirection.Name = "LabelDirection";
            this.LabelDirection.Size = new System.Drawing.Size(55, 15);
            this.LabelDirection.TabIndex = 6;
            this.LabelDirection.Text = "Direction";
            // 
            // LabelFN
            // 
            this.LabelFN.AutoSize = true;
            this.LabelFN.Location = new System.Drawing.Point(432, 13);
            this.LabelFN.Name = "LabelFN";
            this.LabelFN.Size = new System.Drawing.Size(87, 15);
            this.LabelFN.TabIndex = 7;
            this.LabelFN.Text = "FrameNumber:";
            // 
            // LabelPos
            // 
            this.LabelPos.AutoSize = true;
            this.LabelPos.Location = new System.Drawing.Point(466, 28);
            this.LabelPos.Name = "LabelPos";
            this.LabelPos.Size = new System.Drawing.Size(53, 15);
            this.LabelPos.TabIndex = 8;
            this.LabelPos.Text = "Position:";
            // 
            // LabelDir
            // 
            this.LabelDir.AutoSize = true;
            this.LabelDir.Location = new System.Drawing.Point(461, 43);
            this.LabelDir.Name = "LabelDir";
            this.LabelDir.Size = new System.Drawing.Size(58, 15);
            this.LabelDir.TabIndex = 9;
            this.LabelDir.Text = "Direction:";
            // 
            // PictureBoxRobot
            // 
            this.PictureBoxRobot.BackColor = System.Drawing.Color.Transparent;
            this.PictureBoxRobot.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxRobot.Name = "PictureBoxRobot";
            this.PictureBoxRobot.Size = new System.Drawing.Size(103, 98);
            this.PictureBoxRobot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxRobot.TabIndex = 4;
            this.PictureBoxRobot.TabStop = false;
            // 
            // LabelSensrs
            // 
            this.LabelSensrs.AutoSize = true;
            this.LabelSensrs.Location = new System.Drawing.Point(469, 58);
            this.LabelSensrs.Name = "LabelSensrs";
            this.LabelSensrs.Size = new System.Drawing.Size(50, 15);
            this.LabelSensrs.TabIndex = 11;
            this.LabelSensrs.Text = "Sensors:";
            // 
            // LabelSensors
            // 
            this.LabelSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSensors.AutoSize = true;
            this.LabelSensors.Location = new System.Drawing.Point(518, 58);
            this.LabelSensors.Name = "LabelSensors";
            this.LabelSensors.Size = new System.Drawing.Size(47, 15);
            this.LabelSensors.TabIndex = 10;
            this.LabelSensors.Text = "Sensors";
            // 
            // SimulationResultViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 631);
            this.Controls.Add(this.LabelSensrs);
            this.Controls.Add(this.LabelSensors);
            this.Controls.Add(this.LabelDir);
            this.Controls.Add(this.LabelPos);
            this.Controls.Add(this.LabelFN);
            this.Controls.Add(this.LabelDirection);
            this.Controls.Add(this.LabelPosition);
            this.Controls.Add(this.LabelFrameNumber);
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
        private Label LabelFrameNumber;
        private Label LabelPosition;
        private Label LabelDirection;
        private Label LabelFN;
        private Label LabelPos;
        private Label LabelDir;
        private PictureBox PictureBoxRobot;
        private Label LabelSensrs;
        private Label LabelSensors;
    }
}