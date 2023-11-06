// Ignore Spelling: atomiki

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace atomiki1
{
    public partial class ShapeDesigner : Form
    {


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
            graphics.DrawLine(pen, start, stop);
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

                }
            }
            Canvas.Refresh();

            //Changes the Mouse coordinates label
            MouseCoordsLabel.Text = e.X + ", " + e.Y + "px";

        }

        //This simply makes the text for the mouse cursor coordinates to empty string
        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            MouseCoordsLabel.Text = "";
        }


        //-----------------------Tool Selector-----------------------//
        enum DrawingTool
        {
            Line,
            Rectangle,
            Ellipse
        }

        DrawingTool curTool;
        private void LineSelectorButton_Click(object sender, EventArgs e)
        {
            curTool = DrawingTool.Line;
        }



    }
}

