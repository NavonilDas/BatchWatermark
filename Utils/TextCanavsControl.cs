﻿using System;
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
        // Private members
        private string text = "Batch Watermark";
        private Color fontColor = Color.Violet;
        private Color backColor = Color.Transparent;
        private int rotate = 0;
        private Font textFont = new Font("Arial", 16, GraphicsUnit.Point);
        private bool _mouseDown;
        private int _mouseX, _mouseY;
        private int curW;
        private int curH;
        private bool isCenter = false;
        private Rectangle trans;
        private string file = "";
        private SolidBrush fontBrush;
        private Panel parent;
        //        private bool isBackTransparent = true;

        /// <summary>
        /// Event trrigers when the Text item gets focused
        /// </summary>
        public event EventHandler OnTextFocused;

        /// <summary>
        /// The Text on the Watermark
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
        /// The font on the Watermark
        /// </summary>
        public override Font Font
        {
            get
            {
                return textFont;
            }

            set
            {
                textFont = value;
                CalcSize();
                Refresh();
            }
        }
        /// <summary>
        /// Sets The Back color of the WaterMark
        /// </summary>
        public override Color BackColor
        {
            get
            {
                return backColor;
            }

            set
            {
                backColor = value;
                Refresh();
            }
        }
        /// <summary>
        /// Sets the Text color of the watermark
        /// </summary>
        public override Color ForeColor
        {
            get
            {
                return fontColor;
            }

            set
            {
                fontColor = value;
                fontBrush = new SolidBrush(fontColor);
                Refresh();
            }
        }
        /// <summary>
        /// Set the Watermark at the Center
        /// </summary>
        public bool Centered
        {
            get
            {
                return isCenter;
            }
            set
            {
                isCenter = value;
                setCenter();
                Refresh();
            }
        }
        /// <summary>
        /// Set The Rotation Of the Text
        /// </summary>
        public int Rotation
        {
            get {
                return rotate;
            }
            set
            {
                rotate = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public TextCanavsControl()
        {
            trans = new Rectangle(10,10, 1, 1);
            setCenter();
            fontBrush = new SolidBrush(fontColor);
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public TextCanavsControl(Panel parent)
        {
            this.parent = parent;
            this.Width = parent.Width;
            this.Height = parent.Height;
            trans = new Rectangle(10, 10, 1, 1);
            setCenter();
            fontBrush = new SolidBrush(fontColor);
            SetStyle(ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        /// <summary>
        /// Set the Watermark text at the Center
        /// </summary>
        private void setCenter()
        {
            CalcSize();
            trans.X = (this.Width - curW) / 2;
            trans.Y = (this.Height - curH) / 2;
        }
        /// <summary>
        /// Function to set the Background Image from file
        /// </summary>
        public void SetImage(string file, Panel parent)
        {
            this.file = file;
            Bitmap bmp;
            using (Image x = Image.FromFile(file))
            {
                if (parent.Width < x.Width)
                    this.Width = parent.Width;
                else
                    this.Width = x.Width;

                bmp = new Bitmap(this.Width, (this.Width * x.Height) / x.Width);
                this.Height = (this.Width * x.Height) / x.Width;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(x, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, x.Width, x.Height, GraphicsUnit.Pixel);
                }
            }
            this.Location = new Point((parent.Width - this.Width) / 2, (parent.Height - this.Height) / 2);
            this.BackgroundImage = bmp;
            Refresh();
        }
        /// <summary>
        /// Function to set the Background Image from file
        /// </summary>
        public void SetImage(string file)
        {
            this.file = file;
            Bitmap bmp;
            using (Image x = Image.FromFile(file))
            {
                if (parent.Width < x.Width)
                    this.Width = parent.Width;
                else
                    this.Width = x.Width;

                bmp = new Bitmap(this.Width, (this.Width * x.Height) / x.Width);
                this.Height = (this.Width * x.Height) / x.Width;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(x, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, x.Width, x.Height, GraphicsUnit.Pixel);
                }
            }
            this.Location = new Point((parent.Width - this.Width) / 2, (parent.Height - this.Height) / 2);
            this.BackgroundImage = bmp;
            Refresh();
        }
        public void UpdateImage(Panel parent)
        {
            Bitmap bmp;
            using (Image x = Image.FromFile(file))
            {
                if (parent.Width < x.Width)
                    this.Width = parent.Width;
                else
                    this.Width = x.Width;

                bmp = new Bitmap(this.Width, (this.Width * x.Height) / x.Width);
                this.Height = (this.Width * x.Height) / x.Width;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(x, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, x.Width, x.Height, GraphicsUnit.Pixel);
                }
            }
            this.Location = new Point((parent.Width - this.Width) / 2, (parent.Height - this.Height) / 2);
            this.BackgroundImage = bmp;
            Refresh();
        }
        public void UpdateImage()
        {
            Bitmap bmp;
            using (Image x = Image.FromFile(file))
            {
                if (parent.Width < x.Width)
                    this.Width = parent.Width;
                else
                    this.Width = x.Width;

                bmp = new Bitmap(this.Width, (this.Width * x.Height) / x.Width);
                this.Height = (this.Width * x.Height) / x.Width;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.DrawImage(x, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, x.Width, x.Height, GraphicsUnit.Pixel);
                }
            }
            this.Location = new Point((parent.Width - this.Width) / 2, (parent.Height - this.Height) / 2);
            this.BackgroundImage = bmp;
            Refresh();
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

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (!isCenter && _mouseDown)
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
            trans.Width = curW;
            trans.Height = curH;

            if (this.BackgroundImage != null)
            {
                g.DrawImage(this.BackgroundImage,trans, trans.X, trans.Y, curW, curH, GraphicsUnit.Pixel);
            }

            if (rotate > 0) {
                g.TranslateTransform(this.Width / 2, this.Height / 2);
                g.RotateTransform(rotate);
            }

            if(_mouseDown)
                g.DrawRectangle(Pens.Black, trans);

            if (backColor != Color.Transparent)
                g.FillRectangle(new SolidBrush(backColor), trans);

            g.DrawString(this.text, this.textFont, fontBrush, new Point(trans.X + 1 ,trans.Y + 1));

            if (rotate > 0)
            {
                g.RotateTransform(-rotate);
                g.TranslateTransform(-this.Width / 2, -this.Height / 2);
            }

        }
    }
}
