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
            t.BackgroundImage  = Image.FromFile("E:\\Thecertificate.jpeg");
            t.OnTextFocused += new EventHandler(textFocused);
            t.Location = new Point(100, 100);
            canvas.Controls.Add(t);
        }

        private void textFocused(object sender, EventArgs e)
        {
            MessageBox.Show("diasjkhdj");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkSlateGray, new Point(1, 0), new Point(1,panel1.Height));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //canvas.BackgroundImage = Image.FromFile("E:\\Thecertificate.jpeg");
            //canvas.BackColor = Color.Red;
            t.Text = "hi there";
        }
    }
}
