// Ignore Spelling: atomiki

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atomiki1
{
    public partial class ShapeDesigner : Form
    {
        enum DrawingTool
        {
            Line,
            Rectangle,
            Ellipse,
            Polygon
        }

        public ShapeDesigner()
        {
            InitializeComponent();
        }

        //-----------------------Strip Menus-----------------------//
        private void stripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonFile_Click(object sender, EventArgs e)
        {
            FileMenuStrip.Show();
        }

        //-----------------------Color picker-----------------------//

        //Color picker dialog for the primary color
        private void ColorPicker1_Click(object sender, EventArgs e)
        {
            if (ColorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPicker1.BackColor = ColorPickerDialog.Color;
                pen.Color = ColorPickerDialog.Color;
            }
        }

        // Color picker dialog for the secondary color
        private void ColorPicker2_Click(object sender, EventArgs e)
        {
            if (ColorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPicker2.BackColor = ColorPickerDialog.Color;
            }
        }



        private void SwapColorsButton_Click(object sender, EventArgs e)
        {
            Color tempColor = ColorPicker1.BackColor;
            // Switch the background colors
            ColorPicker1.BackColor = ColorPicker2.BackColor;
            ColorPicker2.BackColor = tempColor;

            //And switch the pen color
            pen.Color = ColorPicker1.BackColor;
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




        private void ClearCanvas_Click(object sender, EventArgs e)
        {
            // Clear the bitmap with a white background
            graphics.Clear(Color.White);
            Canvas.Invalidate(); // Refresh the canvas
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


        //-----------------------Tool Selector-----------------------//

        DrawingTool curTool;

        private void RectangleSelectButton_Click(object sender, EventArgs e)
        {
            curTool = DrawingTool.Rectangle;
            CurrentToolLabel.Text = "Current Tool: Rectangle";
        }


        private void PolygonSelectorButton_Click(object sender, EventArgs e)
        {
            curTool = DrawingTool.Polygon;
            CurrentToolLabel.Text = "Current Tool: Polygon";
        }

        private void LineSelectorButton_Click(object sender, EventArgs e)
        {
            curTool = DrawingTool.Line;
            CurrentToolLabel.Text = "Current Tool: Line";
        }

        private void EllipseSelectButton_Click(object sender, EventArgs e)
        {
            curTool = DrawingTool.Ellipse;
            CurrentToolLabel.Text = "Current Tool: Ellipse";
        }

        private Rectangle MakeRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName);
            }
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