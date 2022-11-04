using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentASE
{
    public partial class MainForm : Form
    {
        readonly Bitmap OutputBitmap;
        readonly Canvass Canvass;
        public MainForm()
        {
            InitializeComponent();
            OutputBitmap = new Bitmap(505,377);
            Canvass = new Canvass(Graphics.FromImage(OutputBitmap));

        }

        private void buttonMultiLine_Click(object sender, EventArgs e)
        {
            string commandTyped = textBoxMultiLine.Text;
            this.paint(commandTyped);
        }

        private void buttonSingleLine_Click(object sender, EventArgs e)
        {
            string commandTyped = textBoxSingleLine.Text;
            Parser.ParseAction(commandTyped);

            this.paint(commandTyped);
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
            else
            {
                Console.WriteLine("\n");              
            }

        }

        private void textBoxSingleiLine_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }
            else
            {
                string commandTyped = textBoxSingleLine.Text;
                Parser.ParseAction(commandTyped);
                
                this.paint(commandTyped);
            }
        }

        private void paint(string text)
        {
            Console.Write("Enter key pressed...");

            var commandTyped = text.Trim().ToLower();

            var pen = new Pen(Color.Red);
            var graphics = Graphics.FromImage(OutputBitmap);
            switch (commandTyped)
            {
                case "line":
                    graphics.DrawLine(pen, 0, 0, 100, 100);
                    break;
                case "square":
                    graphics.DrawRectangle(pen, 0, 0, 100, 100);
                    break;
                case "circle":
                    graphics.DrawEllipse(pen, 0, 0 , 100, 100);
                    break;
                case "line\r\ncircle":
                    graphics.DrawLine(pen, 0, 0, 100, 100);
                    graphics.DrawEllipse(pen , 0, 0, 100, 100);
                    break;
            }

            textBoxMultiLine.Clear();
            Refresh();
        }

        
    }
}
