using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day12
{
    public partial class Football : Form
    {
        int x = 100;
        public Football()
        {
            InitializeComponent();
        }

        bool ball=true;
        Brush myColor = Brushes.Blue;
        private void timOne_Tick(object sender, EventArgs e)
        {
            Graphics gfx = CreateGraphics();
            if (ball)
            {
                gfx.FillEllipse(new SolidBrush(this.BackColor), x, 200, 30, 30);
                x += 5;

                gfx.DrawLine(new Pen(this.BackColor), 75, 170, 125, 220);
                gfx.DrawLine(new Pen(Color.Blue), 75, 170, 100, 220);
                if (x == (650))
                {
                    gfx.DrawLine(new Pen(Color.Blue), Width - 75, 170, Width - 125, 220);
                    gfx.DrawLine(new Pen(Color.Blue), Width - 75, 170, Width - 100, 220);

                    ball = false;

                }
                gfx.FillEllipse(myColor, x, 200, 30, 30);
            }
            if (!ball)
            {
                gfx.FillEllipse(new SolidBrush(this.BackColor), x, 200, 30, 30);

                x -= 5;
                if (x == (640))
                {
                    gfx.DrawLine(new Pen(this.BackColor), Width - 75, 170, Width - 125, 220);
                    gfx.DrawLine(new Pen(Color.Blue), Width - 75, 170, Width - 100, 220);
                }
                
                if (x == (100))
                {
                    gfx.DrawLine(new Pen(this.BackColor), 75, 170, 100, 220);
                    gfx.DrawLine(new Pen(Color.Blue), 75, 170, 125, 220);
                    ball = true;
                }
                gfx.FillEllipse(myColor, x, 200, 30, 30);
            }
        }
            private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = new SolidBrush(Color.Red);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = new SolidBrush(Color.Blue);
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = new SolidBrush(Color.Black);
        }

        private void Football_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(myColor), 50, 50, 50, 50);
            e.Graphics.DrawLine(new Pen(myColor), 75, 100, 75, 170);
            e.Graphics.DrawLine(new Pen(myColor), 75, 110, 100, 150);
            e.Graphics.DrawLine(new Pen(myColor), 75, 110, 50, 150);
            e.Graphics.DrawLine(new Pen(myColor), 75, 170, 100, 220);
            e.Graphics.DrawLine(new Pen(myColor), 75, 170, 50, 220);
            //Second Player
            e.Graphics.DrawEllipse(new Pen(myColor), this.Width-100, 50, 50, 50);
            e.Graphics.DrawLine(new Pen(myColor), this.Width - 75, 100, this.Width - 75, 170);
            e.Graphics.DrawLine(new Pen(myColor), this.Width - 75, 110, this.Width - 100, 150);
            e.Graphics.DrawLine(new Pen(myColor), this.Width - 75, 110, this.Width - 50, 150);
            e.Graphics.DrawLine(new Pen(myColor), this.Width - 75, 170, this.Width - 100, 220);
            e.Graphics.DrawLine(new Pen(myColor), this.Width - 75, 170, this.Width - 50, 220);
            //line
            e.Graphics.DrawLine(new Pen(Color.White), 0, 300, this.Width , 300);
            e.Graphics.DrawEllipse(new Pen(Color.White), (this.Width/2)+50 - 100, 250, 100, 100);
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myColor = new SolidBrush(Color.White);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!timOne.Enabled)
            {
                btnStop.Text = "Stop";
                btnStop.BackColor = Color.DarkRed;
                timOne.Enabled = !timOne.Enabled;
            }
            else {
                btnStop.Text = "play";
                btnStop.BackColor = Color.DarkGreen;
                timOne.Enabled = !timOne.Enabled;
            }
            
        }
    }
}
