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
    public partial class ImageWatermark : Form
    {
        List<string> fileNames;
        public ImageWatermark(List<string> filenames)
        {
            InitializeComponent();
            fileNames = filenames;
        }
    }
}
