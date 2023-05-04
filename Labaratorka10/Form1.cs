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
using System.Drawing.Drawing2D;

namespace Laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = File.ReadAllText("result.txt");
            label1.Text = temp;
            label1.Visible = true;
            label2.Text = "Кол-во символов = " + temp.Length;
            label2.Visible = true;
            progressBar1.Value = temp.Length / 10;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle gradientRect = new Rectangle(0, 0, Width, Height);
            LinearGradientBrush gradientBrush = new LinearGradientBrush(gradientRect, Color.Blue, Color.Purple, 90);
            e.Graphics.FillRectangle(gradientBrush, gradientRect);
        }
    }
}
