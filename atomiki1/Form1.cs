// Ignore Spelling: atomiki

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atomiki1
{
    public partial class Shapes : Form
    {

        enum DrawingTool
        {
            Line,
            Rectangle,
            Ellipse,
            Polygon
        }
        DrawingTool curTool;

        public Shapes()
        {
            InitializeComponent();
        }

      


        //-----------------------Draw-----------------------//
        Graphics graphics;
        Bitmap bitmap;
        Point start, stop;
        List<Point> points = new List<Point>();
        Pen pen, eraser;
        bool draw;

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            start = e.Location;
            points.Add(e.Location);
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            stop = e.Location;
            switch (curTool)
            {
                case DrawingTool.Line:
                    graphics.DrawLine(pen, start, stop);
                    break;
                case DrawingTool.Rectangle:
                    graphics.DrawRectangle(pen, MakeRectangle(start, stop));
                    break;
                case DrawingTool.Polygon:
                    createPolygon(pen, start, e.Location, 6);
                    break;
                case DrawingTool.Ellipse:
                    graphics.DrawEllipse(pen, MakeRectangle(start, stop));
                    break;

            }
        }

        private void ShapeDesigner_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);

            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);

            pen = new Pen(Color.Black, 3);
            eraser = new Pen(Canvas.BackColor, 3);

            Canvas.Image = bitmap;
        }

        private void ShapeDesigner_Resize(object sender, EventArgs e)
        {
            if (bitmap != null)
            {
                Bitmap tempBitmap = new Bitmap(Canvas.Width, Canvas.Height);

                using (Graphics g = Graphics.FromImage(tempBitmap))
                {
                    g.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
                }

                bitmap.Dispose(); // Dispose the previous bitmap
                bitmap = tempBitmap;
                Canvas.Image = bitmap;
                graphics = Graphics.FromImage(bitmap);
            }
        }



        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                switch (curTool)
                {   // Preview before placement for each tool
                    case DrawingTool.Line:
                        graphics.DrawLine(eraser, start, stop);
                        graphics.DrawLine(pen, start, e.Location);
                        stop = e.Location;
                        break;
                    case DrawingTool.Rectangle:
                        graphics.DrawRectangle(eraser, MakeRectangle(start, stop));
                        graphics.DrawRectangle(pen, MakeRectangle(start, e.Location));
                        stop = e.Location; 
                        break;
                    case DrawingTool.Polygon:
                        createPolygon(eraser, start,stop, 6);
                        createPolygon(pen, start,e.Location, 6);
                        stop = e.Location;
                        break;
                    case DrawingTool.Ellipse:
                        graphics.DrawEllipse(eraser, MakeRectangle(start, stop));
                        graphics.DrawEllipse(pen, MakeRectangle(start, e.Location));
                        stop = e.Location;
                        break;
                }
            }

            Canvas.Refresh();
           //graphics.Clear(Color.Transparent); // I will use this later when i use layers to not erase everything


            //Changes the Mouse coordinates label
            MouseCoordsLabel.Text = e.X + ", " + e.Y + "px";

        }

        //This simply makes the text for the mouse cursor coordinates to empty string
        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            MouseCoordsLabel.Text = "";
        }





        

        
    }
}