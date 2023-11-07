using System.Drawing;
using System.Windows.Forms;
using System;

namespace atomiki1
{
    partial class Shapes
    {

        private Rectangle MakeRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }

    


        PointF[] shape;
        private void createPolygon(Pen penUsed, Point start, Point stop, int sides)
        {
            // Find the center
            var x0 = (start.X + stop.X) / 2;
            var y0 = (start.Y + stop.Y) / 2;

            shape = new PointF[sides];

            float angle = 360 / sides;

            float r = (float)Math.Sqrt(Math.Pow((start.X - stop.X), 2) + Math.Pow((start.Y - stop.Y), 2)) / 2;

            for (int a = 0; a < sides; a++)
            {
                shape[a] = new PointF(
                    x0 + r * (float)Math.Cos(a * angle * Math.PI / 180f),
                    y0 + r * (float)Math.Sin(a * angle * Math.PI / 180f));
            }
            graphics.DrawPolygon(penUsed, shape);
            pictureBox1.Refresh();
        }
    }
}