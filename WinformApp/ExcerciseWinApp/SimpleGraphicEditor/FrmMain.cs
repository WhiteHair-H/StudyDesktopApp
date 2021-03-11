using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGraphicEditor
{
    enum DrawMode
    {
        LiNE,
        RECTANGLE,
        CIRCLE,
        CURVED_LINE
    }

    public partial class FrmMain : Form
    {
        // 멤버변수들
        private DrawMode mode;
        private Graphics g;
        private Pen pen;
        private Pen eraser;
        private Point startP, endP, currP, prevP; 
        //


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            StsCurrent.Text = "";

            g = CreateGraphics();
            this.pen = new Pen(Color.Black, 2);
            StsCurrent.Text = "Line Mode";
            this.mode = DrawMode.LiNE;
            this.BackColor = Color.White;
            this.eraser = new Pen(Color.White, 2);

        }

        private void TlmLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.LiNE;
            StsCurrent.Text = "Line Mode";

        }

        private void TlmRectangle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.RECTANGLE;
            StsCurrent.Text = "RECTANGLE Mode";
        }

        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.startP = new Point(e.X,e.Y);
            this.currP =  this.prevP = this.startP;
        }


        // 마우스 옮길때 마다 발생

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            this.prevP = this.currP;
            this.currP = new Point(e.X, e.Y);

            switch (this.mode)
            {
                case DrawMode.LiNE:
                    g.DrawLine(this.eraser, this.startP, this.prevP);
                    g.DrawLine(this.pen, this.startP, this.currP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(this.eraser, 
                        new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawRectangle(this.pen,
                        new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(this.eraser,
                        new Rectangle(startP, new Size(prevP.X - startP.X, prevP.Y - startP.Y)));
                    g.DrawEllipse(this.pen,
                        new Rectangle(startP, new Size(currP.X - startP.X, currP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }

        }

        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.endP = new Point(e.X, e.Y);
            switch (this.mode)
            {
                case DrawMode.LiNE:
                    g.DrawLine(this.pen, this.startP, this.endP);
                    break;
                case DrawMode.RECTANGLE:
                    g.DrawRectangle(this.pen,
                        new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CIRCLE:
                    g.DrawEllipse(this.pen,
                        new Rectangle(startP, new Size(endP.X - startP.X, endP.Y - startP.Y)));
                    break;
                case DrawMode.CURVED_LINE:
                    break;
                default:
                    break;
            }
        }

        private void TmlCircle_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CIRCLE;
            StsCurrent.Text = "CIRCLE Mode";
        }

        private void TlmCurvedLine_Click(object sender, EventArgs e)
        {
            this.mode = DrawMode.CURVED_LINE;
            StsCurrent.Text = "CURVED_LINE Mode";
        }

        private void TlmColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.pen.Color = colorDialog.Color;
            }
        }
    }
}
