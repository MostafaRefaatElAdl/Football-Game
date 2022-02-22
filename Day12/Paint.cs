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
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }
        Graphics gfx;
        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            gfx = CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                gfx.FillEllipse(Brushes.Red, e.X - 15, e.Y - 15, 30, 30);
            }
            else if (e.Button == MouseButtons.Right)
            {
                gfx.FillEllipse(new SolidBrush(BackColor), e.X - 15, e.Y - 15, 30, 30);
            }
        }

        
    }
}
