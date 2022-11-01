using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentASE
{
    public partial class MainForm : Form
    {
        readonly Bitmap OutputBitmap;
        //readonly Canvas Canvas;
        public MainForm()
        {
            InitializeComponent();
            OutputBitmap = new Bitmap   (505,377);
            //Canvas = new Canvas(Graphics.FromImage(OutputBitmap));

        }

        private void textBoxSingleLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMultiLine_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMultiLine_Click(object sender, EventArgs e)
        {

        }

        private void buttonSingleLine_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxMain_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBoxMain_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.DrawImageUnscaled(OutputBitmap, 0, 0);
        }

        private void textBoxMultiLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            Console.Write("Enter key pressed...");

            var commandTyped = textBoxMultiLine.Text.Trim().ToLower();

            var pen = new Pen(Color.Red);
            var graphics = Graphics.FromImage(OutputBitmap);
            switch (commandTyped)
            {
                case "line":
                    graphics.DrawLine(pen, 0, 0, 100, 100);
                    break;
                case "square":
                    graphics.DrawRectangle(pen, 0, 100, 100, 100);
                    break;
                case "circle":
                    graphics.DrawEllipse(pen, 0, 100, 100, 100);
                    break;
            }

            textBoxMultiLine.Clear();
            Refresh();
        }
    }
}
