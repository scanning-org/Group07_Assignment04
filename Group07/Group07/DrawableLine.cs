using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Group07
{
    class DrawableLine : IDrawable, IWritable
    {
        protected Color color;
        protected Point lineStart;
        protected Point lineEnd;

        public DrawableLine(Color color, Point start, Point end)
        {
            this.color = color;
            lineStart = start;
            lineEnd = end;

        }

        public void Draw(Graphics g)
        {
            Pen myPen = new Pen(color);
            g.DrawLine(myPen,lineStart, lineEnd);
        }

        public void Write (TextWriter writer)
        {
           writer.WriteLine($"{ color}, {lineStart}, {lineEnd}");
        }

    }
}
