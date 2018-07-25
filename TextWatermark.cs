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
        void SaveImage(string iFile,string oFile)
        {

        }
    }
}
