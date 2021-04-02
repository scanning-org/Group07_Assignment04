using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Group07
{
    class DrawableEllipse : Primitive, IDrawable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle): base(color, filled, rectangle) {}

        public void Draw(Graphics g)
        {
            if (filled)
            {
                SolidBrush sBrush = new SolidBrush(color);
                g.FillEllipse(sBrush, boundingRectangle);
            }
            else
            {
                Pen myPen = new Pen(color);
                g.DrawEllipse(myPen, boundingRectangle);
            }
                       
        }
        
        public double Area()
        {
            return Math.PI * boundingRectangle.Height * boundingRectangle.Width;
        }
    }
}
