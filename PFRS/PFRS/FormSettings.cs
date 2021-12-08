using System;
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
        internal FormMain fMain;
        public FormSettings(FormMain m)
        {
            InitializeComponent();
            fMain = m;

            comboBox1.Text = fMain.SelectedTrack;
            comboBox1.Items.AddRange(fMain.Tracks.Keys.ToArray());

            this.SelectedTrack = comboBox1.Text;

        }

        public string SelectedTrack { get; internal set; }

        private void ButtonDefault_Click(object sender, EventArgs e)
        {
            fMain.SetDefaults();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedTrack = comboBox1.Text;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            fMain.SetAppliedSettings(this);
            this.Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
