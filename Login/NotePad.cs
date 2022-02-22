using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class NotePad : Form
    {
        public NotePad()
        {
            InitializeComponent();
            dlgOpen.Filter = "rich text file|*.rtf|plain text|*.txt";
            this.Text = $"Welcome, {Form1.Username}";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                rtbInput.SaveFile(dlgSave.FileName);
            }
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK) 
            {
                rtbInput.LoadFile(dlgOpen.FileName);
            }
        }


        private void btnFont_Click(object sender, EventArgs e)
        {
            if (rtbInput.SelectedText.Length > 0) 
            {
                dlgFont.Font = rtbInput.SelectionFont;
            }
            if (dlgFont.ShowDialog()==DialogResult.OK)
            {
                rtbInput.SelectionFont = dlgFont.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (rtbInput.SelectedText.Length > 0)
            {
                dlgColor.Color = rtbInput.SelectionColor;
            }
            if (dlgColor.ShowDialog() == DialogResult.OK)
            {
                rtbInput.SelectionColor = dlgColor.Color;
            }
        }
    }
}
