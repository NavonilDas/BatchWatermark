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

        private void TextWatermark_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.DarkSlateGray, new Point(1, 0), new Point(1,panel1.Height));
        }
    }
}
