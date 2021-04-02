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
    class DrawableRectangle : Primitive, IDrawable, IWritable
    {

        public DrawableRectangle(Color color, bool filled, Rectangle rectangle) : base(color, filled, rectangle) { }

        public void Draw(Graphics g)
        {
            if (filled)
            {
                SolidBrush sBrush = new SolidBrush(color);
                g.FillRectangle(sBrush, boundingRectangle);
            }
            else
            {
                Pen myPen = new Pen(color);
                g.DrawRectangle(myPen, boundingRectangle);
            }
        }

        public void Write(TextWriter writer)
        {
            writer.WriteLine($"{color} {filled} {boundingRectangle}");
        }

        public double Area()
        {
            return boundingRectangle.Height * boundingRectangle.Width;
        }



    }
}
