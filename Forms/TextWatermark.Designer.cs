namespace BatchWatermark
{
    partial class TextWatermark
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textClrBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.canvas = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.backClrBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.transparentLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.demoLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textClrBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backClrBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(962, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 715);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Text";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 22);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.demoLabel);
            this.groupBox3.Location = new System.Drawing.Point(8, 105);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Font";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.transparentLabel);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.backClrBox);
            this.groupBox2.Location = new System.Drawing.Point(8, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 118);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Back Color";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textClrBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(4, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 87);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Text Color";
            // 
            // textClrBox
            // 
            this.textClrBox.Location = new System.Drawing.Point(6, 31);
            this.textClrBox.Name = "textClrBox";
            this.textClrBox.Size = new System.Drawing.Size(50, 50);
            this.textClrBox.TabIndex = 5;
            this.textClrBox.TabStop = false;
            this.textClrBox.Paint += new System.Windows.Forms.PaintEventHandler(this.backClrBox_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pick Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(-1, 21);
            this.trackBar1.Maximum = 128;
            this.trackBar1.Minimum = 12;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(204, 56);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 12;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.ForestGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(0, 671);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Export";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 644);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Always Center";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 715);
            this.panel2.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(187, 715);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // canvas
            // 
            this.canvas.AutoScroll = true;
            this.canvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(187, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(775, 715);
            this.canvas.TabIndex = 2;
            this.canvas.SizeChanged += new System.EventHandler(this.canvas_SizeChanged);
            // 
            // backClrBox
            // 
            this.backClrBox.Location = new System.Drawing.Point(5, 48);
            this.backClrBox.Name = "backClrBox";
            this.backClrBox.Size = new System.Drawing.Size(50, 50);
            this.backClrBox.TabIndex = 6;
            this.backClrBox.TabStop = false;
            this.backClrBox.Paint += new System.Windows.Forms.PaintEventHandler(this.backClrBox_Paint);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(96, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 35);
            this.button3.TabIndex = 7;
            this.button3.Text = "Pick Color";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // transparentLabel
            // 
            this.transparentLabel.AutoSize = true;
            this.transparentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transparentLabel.Location = new System.Drawing.Point(92, 18);
            this.transparentLabel.Name = "transparentLabel";
            this.transparentLabel.Size = new System.Drawing.Size(99, 20);
            this.transparentLabel.TabIndex = 11;
            this.transparentLabel.Text = "Transparent";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 35);
            this.button4.TabIndex = 12;
            this.button4.Text = "Transparent";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // demoLabel
            // 
            this.demoLabel.AutoSize = true;
            this.demoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoLabel.Location = new System.Drawing.Point(13, 18);
            this.demoLabel.Name = "demoLabel";
            this.demoLabel.Size = new System.Drawing.Size(108, 25);
            this.demoLabel.TabIndex = 11;
            this.demoLabel.Text = "Demo Text";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(47, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 35);
            this.button5.TabIndex = 12;
            this.button5.Text = "Pick Font";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBar1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(8, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 79);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Font Size";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDown1);
            this.groupBox5.Location = new System.Drawing.Point(7, 527);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(201, 64);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rotate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(23, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.ForestGreen;
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(223, 39);
            this.button6.TabIndex = 13;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // TextWatermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 715);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TextWatermark";
            this.Text = "TextWatermark";
            this.Load += new System.EventHandler(this.TextWatermark_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textClrBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.backClrBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.PictureBox textClrBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox backClrBox;
        private System.Windows.Forms.Label transparentLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label demoLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button6;
    }
}