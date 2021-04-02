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
    class DrawableArc : Primitive, IDrawable, IWritable
    {
        protected float start;
        protected float end;

        public DrawableArc(Color color, bool filled, Rectangle rectangle, 
                            float start, float end) : base(color, filled, rectangle)
        {
            this.start = start;
            this.end = end;
        }

        public void Draw(Graphics g)
        {
            Pen myPen = new Pen(color);
            g.DrawArc(myPen, boundingRectangle, start, end);
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{color} {filled} {boundingRectangle} {start} {end}");
        }
        
    }
}
