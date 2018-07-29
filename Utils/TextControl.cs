using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BatchWatermark.Utils
{
    class TextControl:Control
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


        public String Text
        {
            get { return text; }
            set
            {
                text = value;
                UpdateSize();
            }
        }

        private void UpdateSize()
        {
            CalcSize();
            this.Width = curW;
            this.Height = curH;
            Refresh();
        }

        public TextControl()
        {
            this.Cursor = Cursors.NoMove2D;
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            UpdateSize();
        }
        void CalcSize()
        {
            using (Graphics g = Graphics.FromImage(new Bitmap(10, 10)))
            {
                 SizeF s = g.MeasureString(this.text, this.textFont);
                curH = (int)s.Height;
                curW = (int)s.Width;
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            _mouseX = e.X;
            _mouseY = e.Y;
            _mouseDown = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _mouseDown = false;
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Location = new Point(
                    this.Location.X + (e.X - _mouseX),
                    this.Location.Y + (e.Y - _mouseY));
            }
        }
        int alpha = 100;
        int m_opacity = 100;
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(0, 0, this.Width-1, this.Height-1);

            Color frmColor = this.Parent.BackColor;
            Brush bckColor = default(Brush);

            alpha = (m_opacity * 255) / 100;

            if (_mouseDown)
            {
                Color dragBckColor = default(Color);
                if (BackColor != Color.Transparent)
                {
                    int Rb = BackColor.R * alpha / 255 + frmColor.R * (255 - alpha) / 255;
                    int Gb = BackColor.G * alpha / 255 + frmColor.G * (255 - alpha) / 255;
                    int Bb = BackColor.B * alpha / 255 + frmColor.B * (255 - alpha) / 255;
                    dragBckColor = Color.FromArgb(Rb, Gb, Bb);
                }
                else
                {
                    dragBckColor = frmColor;
                }

                alpha = 255;
                bckColor = new SolidBrush(Color.FromArgb(alpha, dragBckColor));
            }
            else
            {
                bckColor = new SolidBrush(Color.FromArgb(alpha, this.BackColor));
            }

            if (this.BackColor != Color.Transparent)
            {
                g.FillRectangle(bckColor, bounds);
            }

            g.FillRectangle(new SolidBrush(Color.FromArgb(0, 0, 0, 0)), bounds);
            g.DrawRectangle(Pens.Black, bounds);
            g.DrawString(this.text, this.textFont, new SolidBrush(this.fontColor), new PointF(1, 1));
        }
    }
}
