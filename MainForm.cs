using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchWatermark
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<string> fileNames;
        private void button1_Click(object sender, EventArgs e)
        {
            bool isOverFLow = false;
            DialogResult dr = openFileDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                if (openFileDialog1.FileNames.Length > 50)
                    isOverFLow = true;

                if (isOverFLow)
                    imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(openFileDialog1.FileNames[0]));

                foreach (var x in openFileDialog1.FileNames)
                {
                    if(!isOverFLow)
                        imageList1.Images.Add(new Bitmap(Image.FromFile(x)));
                    FileInfo fi = new FileInfo(x);
                    if (!isOverFLow)
                        listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                    else
                        listView1.Items.Add(fi.Name, 0);

                    fileNames.Add(x);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fileNames = new List<string>();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e){
            if (listView1.SelectedIndices.Count > 0)
                listView1.ContextMenuStrip = contextMenuStrip1;
            else
                listView1.ContextMenuStrip = null;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(int x in listView1.SelectedIndices)
            {
                listView1.Items.RemoveAt(x);
                fileNames.RemoveAt(x);
            }
        }

        private void clearALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            fileNames.Clear();
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOverFLow = false;
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (openFileDialog1.FileNames.Length > 50)
                    isOverFLow = true;

                if (isOverFLow)
                    imageList1.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(openFileDialog1.FileNames[0]));

                foreach (var x in openFileDialog1.FileNames)
                {
                    if (!isOverFLow)
                        imageList1.Images.Add(new Bitmap(Image.FromFile(x)));
                    FileInfo fi = new FileInfo(x);
                    if (!isOverFLow)
                        listView1.Items.Add(fi.Name, imageList1.Images.Count - 1);
                    else
                        listView1.Items.Add(fi.Name, 0);

                    fileNames.Add(x);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                checkBox1.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Open Image WaterMark
                About form = new About();
                this.Hide();
                form.FormClosed += new FormClosedEventHandler(mainForm_close);
                form.Show();
            }
            else
            {
                // Open Text Watermark
                About form = new About();
                this.Hide();
                form.FormClosed += new FormClosedEventHandler(mainForm_close);
                form.Show();
            }
        }

        private void mainForm_close(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
