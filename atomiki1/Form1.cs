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

        private void stripMenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonFile_Click(object sender, EventArgs e)
        {
            FileMenuStrip.Show();
        }

        //-----------------------Color picker-----------------------//
        Color current_color;
        private void ColorPicker1_Click(object sender, EventArgs e)
        {
            if (ColorPickerDialog.ShowDialog() == DialogResult.OK)
            {
                ColorPicker1.BackColor = ColorPickerDialog.Color;
                current_color = ColorPickerDialog.Color;
            }
        }

        Color secondary_color;
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

            //And switch the current colors
            current_color = ColorPicker1.BackColor;
        }



        //-----------------------Paint-----------------------//
        Pen pen, eraser;
        Graphics graphics;
        Bitmap bitmap;
        Point start, stop;
        List<Point> points = new List<Point>();

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

        private void Canvas_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            pen = new Pen(Color.Black, 3);
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            Canvas.Image = bitmap;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                graphics.DrawLine(eraser, start, stop);
                graphics.DrawLine(pen, start, e.Location);
                stop = e.Location;
            }
        }
    }
}
