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
    class DrawableBezier : IDrawable, IWritable
    {
        protected Color color;
        protected Point curveStart;
        protected Point controlFirst;
        protected Point controlSecond;
        protected Point curveEnd;

        public DrawableBezier(Color color, Point start, Point first, Point second, Point end)
        {
            this.color = color;
            curveStart = start;
            controlFirst = first;
            controlSecond = second;
            curveEnd = end;
        }

        public void Draw(Graphics g)
        {
            Pen myPen = new Pen(color);
            g.DrawBezier(myPen, curveStart, controlFirst, controlSecond, curveEnd);
        }

        public void Write(TextWriter writer)
        {
           writer.WriteLine($"{color} {curveStart} {controlFirst} {controlSecond} {curveEnd}");
        }
    }
}
