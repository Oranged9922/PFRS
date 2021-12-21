namespace PFRS
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonDefault = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LabelTrackSelect = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.LabelSimulationTime = new System.Windows.Forms.Label();
            this.LabelRobotSelect = new System.Windows.Forms.Label();
            this.ComboBoxRobotSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSave
            // 
            resources.ApplyResources(this.ButtonSave, "ButtonSave");
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            resources.ApplyResources(this.ButtonCancel, "ButtonCancel");
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonDefault
            // 
            resources.ApplyResources(this.ButtonDefault, "ButtonDefault");
            this.ButtonDefault.Name = "ButtonDefault";
            this.ButtonDefault.UseVisualStyleBackColor = true;
            this.ButtonDefault.Click += new System.EventHandler(this.ButtonDefault_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // LabelTrackSelect
            // 
            resources.ApplyResources(this.LabelTrackSelect, "LabelTrackSelect");
            this.LabelTrackSelect.Name = "LabelTrackSelect";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // LabelSimulationTime
            // 
            resources.ApplyResources(this.LabelSimulationTime, "LabelSimulationTime");
            this.LabelSimulationTime.Name = "LabelSimulationTime";
            // 
            // LabelRobotSelect
            // 
            resources.ApplyResources(this.LabelRobotSelect, "LabelRobotSelect");
            this.LabelRobotSelect.Name = "LabelRobotSelect";
            // 
            // ComboBoxRobotSelect
            // 
            this.ComboBoxRobotSelect.FormattingEnabled = true;
            resources.ApplyResources(this.ComboBoxRobotSelect, "ComboBoxRobotSelect");
            this.ComboBoxRobotSelect.Name = "ComboBoxRobotSelect";
            this.ComboBoxRobotSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRobotSelect_SelectedIndexChanged);
            // 
            // FormSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelRobotSelect);
            this.Controls.Add(this.ComboBoxRobotSelect);
            this.Controls.Add(this.LabelSimulationTime);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.LabelTrackSelect);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ButtonDefault);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonSave;
        private Button ButtonCancel;
        private Button ButtonDefault;
        private ComboBox comboBox1;
        private Label LabelTrackSelect;
        private NumericUpDown numericUpDown1;
        private Label LabelSimulationTime;
        private Label LabelRobotSelect;
        private ComboBox ComboBoxRobotSelect;
    }
}