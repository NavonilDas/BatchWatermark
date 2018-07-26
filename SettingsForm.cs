using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchWatermark
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.iscompress)
            {
                Properties.Settings.Default.compress = (int)quality.Value;
            }
                Properties.Settings.Default.Save();
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.outputdir;
            checkBox1.Checked = Properties.Settings.Default.iscompress;
            quality.Value = Properties.Settings.Default.compress;
            if (Properties.Settings.Default.iscompress)
            {
                quality.ReadOnly = false;
            }
            else
            {
                quality.ReadOnly = true;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.iscompress = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                quality.ReadOnly = false;
            }
            else
            {
                quality.ReadOnly = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Properties.Settings.Default.outputdir = folderBrowserDialog1.SelectedPath;
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
