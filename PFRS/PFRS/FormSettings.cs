﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFRS
{
    public partial class FormSettings : Form
    {

        public string SelectedTrack { get; internal set; }
        public int SimTime { get; internal set; }
        public string SelectedRobot { get; private set; }

        internal FormMain fMain;
        public FormSettings(FormMain m)
        {
            InitializeComponent();
            fMain = m;

            comboBox1.Text = fMain.SelectedTrack;
            comboBox1.Items.AddRange(fMain.Tracks.Keys.ToArray());

            ComboBoxRobotSelect.Text = fMain.SelectedRobot;
            ComboBoxRobotSelect.Items.AddRange(fMain.Robots.Keys.ToArray().Select(x => x.Split('.').Last()).ToArray());
            this.SimTime = fMain.SimTime;
            this.numericUpDown1.Maximum = 9999;
            this.numericUpDown1.Value = this.SimTime;
            this.SelectedTrack = comboBox1.Text;
            this.SelectedRobot = ComboBoxRobotSelect.Text;

        }

        private void ButtonDefault_Click(object sender, EventArgs e)
        {
            fMain.SetDefaults();
            fMain.SettingsOpen = false;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedTrack = comboBox1.Text;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            fMain.SetAppliedSettings(this);

            fMain.SettingsOpen = false;
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {

            fMain.SettingsOpen = false;
            this.Close();
        }

        private void ComboBoxRobotSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedRobot = ComboBoxRobotSelect.Text;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.SimTime = (int)numericUpDown1.Value;
        }
    }
}
