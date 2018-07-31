using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BatchWatermark.Utils;

namespace BatchWatermark
{
    public partial class TextWatermark : Form
    {
        List<string> fileNames;
        public TextWatermark(List<string> filenames)
        {
            InitializeComponent();
            fileNames = filenames;
        }
        public TextWatermark()
        {
            InitializeComponent();
        }
        void SaveImage(string iFile,string oFile)
        {

        }
        TextCanavsControl t;
        private void TextWatermark_Load(object sender, EventArgs e)
        {
             t = new TextCanavsControl();
            t.Width = 300;
            t.Height = 300;
            t.SetImage("E:\\Thecertificate.jpeg",canvas);
            t.OnTextFocused += new EventHandler(textFocused);
            f = t.Font;
            textClrBox.BackColor = t.ForeColor;
            if (t.BackColor == Color.Transparent)
                transparentLabel.Text = "Transparent";
            else
            {
                backClrBox.BackColor = t.BackColor;
                transparentLabel.Text = "";
            }
            demoLabel.Font = t.Font;
            canvas.Controls.Add(t);
        }
        Font f;
        private void textFocused(object sender, EventArgs e)
        {
            //MessageBox.Show("diasjkhdj");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkSlateGray, new Point(1, 0), new Point(1,panel1.Height));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                t.ForeColor = colorDialog1.Color;
                textClrBox.BackColor = colorDialog1.Color;
            }
        }

        private void canvas_SizeChanged(object sender, EventArgs e)
        {
            if(t != null)
                t.UpdateImage(canvas);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            t.Centered = checkBox1.Checked;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            f = new Font(f.FontFamily,trackBar1.Value,f.Style);
            t.Font = f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            t.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                t.BackColor = colorDialog1.Color;
                backClrBox.BackColor = colorDialog1.Color;
                transparentLabel.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            t.BackColor = Color.Transparent;
            transparentLabel.Text = "Transparent";
            backClrBox.BackColor = Color.Transparent;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = fontDialog1.ShowDialog();
            if(dr == DialogResult.OK)
            {
                demoLabel.Font = fontDialog1.Font;
                t.Font = fontDialog1.Font;
            }
        }
    }
}
