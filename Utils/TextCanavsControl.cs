using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;


namespace BatchWatermark.Utils
{
    class Focused : EventArgs
    {
        public Focused()
        {
        }
    }

    class TextCanavsControl:Control
    {
        private string text = "Batch Watermark";
        private Color fontColor = Color.Black;
        private Color backColor = Color.Transparent;
        private bool isBackTransparent = true;
        private int rotate = 0;
        private Font textFont = new Font("Arial", 16, GraphicsUnit.Point);
        private bool _mouseDown;
        private int _mouseX, _mouseY;
        private int curW;
        private int curH;
        private Rectangle trans;


        /// <summary>
        /// Event trrigers when the Text item gets focused
        /// </summary>
        public event EventHandler OnTextFocused;

        /// <summary>
        /// Sets The Watermark Text
        /// </summary>
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                CalcSize();
                Refresh();
            }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public TextCanavsControl()
        {
            trans = new Rectangle(10,10, 1, 1);
            CalcSize();
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        /// <summary>
        /// This Functions Calculates The Text Size Depending on the Font
        /// </summary>
        void CalcSize()
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(10, 10)))
            {
                SizeF s = g.MeasureString(this.text, this.textFont);
                curH = (int)s.Height;
                curW = (int)s.Width;
            }
        }
        bool inRectange(int x, int y)
        {
            return (
                (x >= trans.X && x <= trans.Width + trans.X) &&
                (y >= trans.Y && y <= trans.Height + trans.Y)
                );
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            _mouseDown = false;
            if (inRectange(e.X, e.Y))
            {
                _mouseX = e.X - trans.X;
                _mouseY = e.Y - trans.Y;
                _mouseDown = true;
            }
        }
        StringBuilder tmp = new StringBuilder();

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_mouseDown)
            {
                trans.X = e.X - _mouseX;
                trans.Y = e.Y - _mouseY;
                Refresh();
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            Refresh();
            if (_mouseDown)
            {
                OnTextFocused(this, new EventArgs());
            }
            _mouseDown = false;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (this.BackgroundImage != null)
            {
                trans.Width = curW;
                trans.Height = curH;
                g.DrawImage(this.BackgroundImage,trans, trans.X, trans.Y, curW, curH, GraphicsUnit.Pixel);
            }
            if (rotate > 0) {
                g.TranslateTransform(this.Width / 2, this.Height / 2);
                g.RotateTransform(rotate);
            }
            if(_mouseDown)
            g.DrawRectangle(Pens.Black, trans);

            g.DrawString(this.text, this.textFont, Brushes.Violet, new Point(trans.X + 1 ,trans.Y + 1));

            if (rotate > 0)
            {
                g.RotateTransform(-rotate);
                g.TranslateTransform(-this.Width / 2, -this.Height / 2);
            }
        }
    }
}
