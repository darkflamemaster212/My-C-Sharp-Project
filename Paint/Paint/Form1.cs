using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    
    public partial class MainForm : Form
    {
        private Point p1;
        private Point p2;
        private bool isDown;
        private Bitmap bm;
        private Graphics gp;
        private Color curColor;
        private Pen pen;
        private int curPenSize;

        public MainForm()
        {
            InitializeComponent();
            DrawSpace.MouseMove += DrawSpace_MouseMove;
            DrawSpace.MouseUp += DrawSpace_MouseUp;
            DrawSpace.Paint += DrawSpace_Paint;
            bm = new Bitmap(DrawSpace.Width, DrawSpace.Height);
            gp = Graphics.FromImage(bm);
            curColor = new Color();
            curColor = Color.Black;
            curPenSize = 11;
            pen = new Pen(curColor,(float)curPenSize);
            LetterSize();
        }
        //Vẽ
        private void DrawSpace_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, p1, p2);
        }
        //Thoát
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Nhấn chuột
        private void DrawSpace_MouseDown(object sender, MouseEventArgs e)
        {
            p1 = new Point(e.Location.X,e.Location.Y);
            isDown = true;
        }
        //Rê chuột
        private void DrawSpace_MouseMove(object sender, MouseEventArgs e)
        {
            toaDoX.Text = "" + e.Location.X;
            toaDoY.Text = "" + e.Location.Y;
            if (isDown)
            {
                p2 = new Point(e.Location.X,e.Location.Y);
                DrawSpace.Refresh();
            }
        }
        //Nhả chuột
        private void DrawSpace_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
            gp.DrawLine(pen, p1, p2);
            DrawSpace.BackgroundImage = (Bitmap)bm.Clone();
        }
        //Chỉnh màu ô trc
        private void frontColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                frontColor.BackColor = cld.Color;
                curColor = cld.Color;
                pen.Color = curColor;
            }
        }
        //chỉnh màu ô sau
        private void behindColor_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
            {
                behindColor.BackColor = cld.Color;
            }
        }
        //switch
        private void switchColor_Click(object sender, EventArgs e)
        {
            Color temp = frontColor.BackColor;
            frontColor.BackColor = behindColor.BackColor;
            behindColor.BackColor = temp;
            curColor = frontColor.BackColor;
            pen.Color = curColor;
        }
        //Size đường kẻ
        
        private void LetterSize()
        {
            for(int i = 1; i <=20; i++)
            {
                LineSize.Items.Add(i);
            }
            LineSize.SelectedIndex = 0;
        }
        // Thay đổi Line Size
        private void LineSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            curPenSize = int.Parse(LineSize.Text);
            pen.Width = curPenSize;
        }
        //màu mẫu
        private void blackColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Black;
            curColor = Color.Black;
            pen.Color = curColor;
        }

        private void whiteColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.White;
            curColor = Color.White;
            pen.Color = curColor;
        }

        private void redColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Red;
            curColor = Color.Red;
            pen.Color = curColor;
        }

        private void greenColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Green;
            curColor = Color.Green;
            pen.Color = curColor;
        }

        private void blueColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Blue;
            curColor = Color.Blue;
            pen.Color = curColor;
        }

        private void yellowColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Yellow;
            curColor = Color.Yellow;
            pen.Color = curColor;
        }

        private void DrawSpace_MouseLeave(object sender, EventArgs e)
        {
            toaDoX.Text = "";
            toaDoY.Text = "";
        }
    }
}
