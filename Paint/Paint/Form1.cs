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
    public enum drawMode
    {
        Pencil,
        Brush,
        Line,
        Ellipse,
        Rectangle,
        FillEllipse,
        FillRectangle,
    }
    public partial class MainForm : Form
    {
        /*vị trí chuột bắt đầu*/
        private Point startPoint = new Point();
        /*vị trí chuột hiện tại*/
        private Point curPoint = new Point();
        /*size*/
        private int recSizeY = 0;
        private int recSizeX = 0;
        /*check mouse down*/
        private bool mouseDown = false;
        /*bitmap*/
        private Bitmap bm;
        /*shape đã chọn*/
        private drawMode curMode;
        /*màu line shape*/
        private Color curColor;
        /*pen*/
        private Pen mPen;
        /*line size*/
        private float curLineSize=1;
        /*solid brush*/
        private SolidBrush mSolidBrush;
        /*biến graphic*/
        Graphics msPaint;
        

        public MainForm()
        {
            InitializeComponent();
            msPaint = DrawSpace.CreateGraphics();
            bm = new Bitmap(DrawSpace.Width,DrawSpace.Height);
            msPaint = Graphics.FromImage(bm);
            /*default color*/
            curColor = Color.Black;
            /*set solid brush*/
            mSolidBrush = new SolidBrush(curColor);
            /*set pen*/
            mPen = new Pen(curColor,curLineSize);
            mPen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            /*set mode*/
            curMode = drawMode.Pencil;
            /*disable line size*/
            LineSize.Enabled = false;
            LinesSize();


        }
        //vẽ
        private void DrawSpace_Paint(object sender, PaintEventArgs e)
        {
            if (mouseDown)
            {
                int dx = curPoint.X - startPoint.X;
                int dy = curPoint.Y - startPoint.Y;
                switch (curMode)
                {
                    case drawMode.Pencil:
                        break;
                    case drawMode.Brush:
                        break;
                    case drawMode.Line:
                        e.Graphics.DrawLine(mPen,startPoint,curPoint);
                        break;
                    case drawMode.Ellipse:
                        e.Graphics.DrawEllipse(mPen,startPoint.X,startPoint.Y,dx,dy);
                        break;
                    case drawMode.Rectangle:
                        e.Graphics.DrawRectangle(mPen, startPoint.X, startPoint.Y, dx, dy);
                        break;
                    case drawMode.FillEllipse:
                        e.Graphics.FillEllipse(mSolidBrush, startPoint.X, startPoint.Y, dx, dy);
                        break;
                    case drawMode.FillRectangle:
                        e.Graphics.FillRectangle(mSolidBrush,startPoint.X,startPoint.Y,dx,dy);
                        break;
                    default:
                        MessageBox.Show("Error"); break;
                }
            }
        }

        //Thoát
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Nhấn chuột
        private void DrawSpace_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            startPoint = new Point(e.Location.X,e.Location.Y);
        }
        //Rê chuột
        private void DrawSpace_MouseMove(object sender, MouseEventArgs e)
        {
            //hiện tọa độ
            toaDoX.Text = "" + e.Location.X;
            toaDoY.Text = "" + e.Location.Y;
            //vẽ
            if (curMode == drawMode.Pencil || curMode == drawMode.Brush)
            {
                if (mouseDown == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        curPoint = e.Location;
                        msPaint.DrawLine(mPen, startPoint, curPoint);
                        startPoint = curPoint;
                        DrawSpace.BackgroundImage = (Bitmap)bm.Clone();
                    }
                }
            }
            else
            {
                if (mouseDown == true)
                {
                    curPoint = new Point(e.Location.X, e.Location.Y);
                    DrawSpace.Refresh();
                }
            }

}
        //Nhả chuột
        private void DrawSpace_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            int dx = curPoint.X - startPoint.X;
            int dy = curPoint.Y - startPoint.Y;
            switch (curMode)
            {
                case drawMode.Pencil:
                    break;
                case drawMode.Brush:
                    break;
                case drawMode.Line:
                    msPaint.DrawLine(mPen, startPoint, curPoint);
                    break;
                case drawMode.Ellipse:
                    msPaint.DrawEllipse(mPen, startPoint.X, startPoint.Y, dx, dy);
                    break;
                case drawMode.Rectangle:
                    msPaint.DrawRectangle(mPen, startPoint.X, startPoint.Y, dx, dy);
                    break;
                case drawMode.FillEllipse:
                    msPaint.FillEllipse(mSolidBrush, startPoint.X, startPoint.Y, dx, dy);
                    break;
                case drawMode.FillRectangle:
                    msPaint.FillRectangle(mSolidBrush, startPoint.X, startPoint.Y, dx, dy);
                    break;
                default:
                    MessageBox.Show("Error"); break;
            }
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
                mPen.Color = curColor;
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
            mPen.Color = curColor;
        }
        //Size đường kẻ
        
        private void LinesSize()
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
            curLineSize = int.Parse(LineSize.Text);
            mPen.Width = curLineSize;
        }
        //màu mẫu
        private void blackColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Black;
            curColor = Color.Black;
            mPen.Color = curColor;
        }

        private void whiteColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.White;
            curColor = Color.White;
            mPen.Color = curColor;
        }

        private void redColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Red;
            curColor = Color.Red;
            mPen.Color = curColor;
        }

        private void greenColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Green;
            curColor = Color.Green;
            mPen.Color = curColor;
        }

        private void blueColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Blue;
            curColor = Color.Blue;
            mPen.Color = curColor;
        }

        private void yellowColor_Click(object sender, EventArgs e)
        {
            frontColor.BackColor = Color.Yellow;
            curColor = Color.Yellow;
            mPen.Color = curColor;
        }

        private void DrawSpace_MouseLeave(object sender, EventArgs e)
        {
            toaDoX.Text = "";
            toaDoY.Text = "";
        }
        private void toolStrip1_Click(object sender, EventArgs e)
        {
           foreach(ToolStripButton item in toolStrip1.Items)
            {
                if (item == sender)
                    item.Checked = true;
                else
                    item.Checked = false;
            }
        }

        private void Brush_Click(object sender, EventArgs e)
        {
            curMode = drawMode.Brush;
            curLineSize = 1;
            LineSize.Enabled = true;
        }

        private void Pencil_Click(object sender, EventArgs e)
        {
            curMode = drawMode.Pencil;
            LineSize.Enabled = false;
        }

        private void line_Click(object sender, EventArgs e)
        {
            curMode = drawMode.Line;
            LineSize.Enabled = true;
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            curMode = drawMode.Ellipse;
            LineSize.Enabled = true;
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            curMode = drawMode.Rectangle;
            LineSize.Enabled = true;
        }
    }
}
