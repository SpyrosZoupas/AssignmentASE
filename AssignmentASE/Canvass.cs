using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentASE
{
    internal class Canvass
    {
        Graphics g;
        Pen p = new Pen(Color.Red);
        int xPos = 0;
        int yPos = 0;

        public Canvass(Graphics g)
        {
            this.g = g;
        }

        public void DrawTo(int xDest, int yDest)
        {
            g.DrawLine(p,xPos,yPos,xDest,yDest);
            xPos = xDest;
            yPos = yDest;
        }

        public void Circle(int radius)
        {
            g.DrawEllipse(p, xPos, yPos, xPos + (radius * 2), yPos + (radius * 2));
        }
    }
}
