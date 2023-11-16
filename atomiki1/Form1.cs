﻿// Ignore Spelling: atomiki

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace atomiki1
{
    public partial class Shapes : Form
    {

        enum DrawingTool
        {
            None,
            Eraser,
            Line,
            Rectangle,
            Ellipse,
            Polygon,
            Circle,
            Square,
            Diamond,
            Cross,
            Triangle,
            Star,
            Heart,
            Cube
        }
        DrawingTool curTool = DrawingTool.None;

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
        Brush brush = new SolidBrush(Color.Black);
        int brushThickness;
        bool draw;
        bool fill = false;
        int polygonSides = 5;
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
                case DrawingTool.None:
                    break;

                case DrawingTool.Line:
                    graphics.DrawLine(pen, start, stop);
                    break;

                case DrawingTool.Rectangle:
                    graphics.DrawRectangle(pen, MakeRectangle(start, stop));
                    if (fill)
                        graphics.FillRectangle(brush, MakeRectangle(start, stop));
                    break;

                case DrawingTool.Polygon:
                    graphics.DrawPolygon(pen, createPolygon(start, stop));
                    if (fill)
                        graphics.FillPolygon(brush, createPolygon(start, stop));
                    break;

                case DrawingTool.Ellipse:
                    graphics.DrawEllipse(pen, MakeRectangle(start, stop));
                    if (fill)
                        graphics.FillEllipse(brush, MakeRectangle(start, stop));
                    break;

                case DrawingTool.Circle:
                    graphics.DrawEllipse(pen, makeSquare(start, stop));
                    if (fill)
                        graphics.FillEllipse(brush, makeSquare(start, stop));
                    break;
                case DrawingTool.Square:
                    graphics.DrawRectangle(pen, makeSquare(start, stop));
                    if (fill)
                        graphics.FillRectangle(brush, makeSquare(start, stop));
                    break;

                case DrawingTool.Diamond:
                    createDiamond(pen, start, e.Location, false);
                    if (fill)
                        createDiamond(pen, start, e.Location, true);
                    break;

                case DrawingTool.Cross:
                    createCross(pen, start, e.Location, false);
                    if (fill)
                        createCross(pen, start, e.Location, true);
                    break;
                case DrawingTool.Triangle:
                    createTriangle(pen, start, stop, false);
                    if (fill)
                        createTriangle(pen, start, stop, true);
                    break;
                case DrawingTool.Star:
                    createStar(pen, start, e.Location, false);
                    if (fill)
                        createStar(pen, start, e.Location, true);
                    break;
                case DrawingTool.Heart:
                    createHeart(pen, start, e.Location, false);
                    if (fill)
                        createHeart(pen, start, e.Location, true);
                    break;
                case DrawingTool.Cube:
                    createCube(pen, start, e.Location);
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



        Point lastPoint;
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (draw)
            {
                switch (curTool)
                {   // Preview before placement for each tool
                    case DrawingTool.None:
                        break;
                    case DrawingTool.Eraser:
                        graphics.DrawLine(eraser, lastPoint, e.Location);
                        lastPoint = e.Location;
                        break;
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
                        graphics.DrawPolygon(eraser, createPolygon(start, stop));
                        graphics.DrawPolygon(pen, createPolygon(start, e.Location));
                        stop = e.Location;
                        break;
                    case DrawingTool.Ellipse:
                        graphics.DrawEllipse(eraser, MakeRectangle(start, stop));
                        graphics.DrawEllipse(pen, MakeRectangle(start, e.Location));
                        stop = e.Location;
                        break;
                    case DrawingTool.Circle:
                        graphics.DrawEllipse(eraser, makeSquare(start, stop));
                        graphics.DrawEllipse(pen, makeSquare(start, e.Location));
                        stop = e.Location;
                        break;
                    case DrawingTool.Square:
                        graphics.DrawRectangle(eraser, makeSquare(start, stop));
                        graphics.DrawRectangle(pen, makeSquare(start, e.Location));
                        stop = e.Location;
                        break;
                    case DrawingTool.Diamond:
                        createDiamond(eraser, start, stop, false);
                        createDiamond(pen, start, e.Location, false);
                        stop = e.Location;
                        break;
                    case DrawingTool.Cross:
                        createCross(eraser, start, stop, false);
                        createCross(pen, start, e.Location, false);
                        stop = e.Location;
                        break;
                    case DrawingTool.Triangle:
                        createTriangle(eraser, start, stop, false);
                        createTriangle(pen, start, e.Location, false);
                        stop = e.Location;
                        break;
                    case DrawingTool.Star:
                        createStar(eraser, start, stop, false);
                        createStar(pen, start, e.Location, false);
                        stop = e.Location;
                        break;
                    case DrawingTool.Heart:
                        createHeart(eraser, start, stop, false);
                        createHeart(pen, start, e.Location, false);
                        stop = e.Location;
                        break;
                    case DrawingTool.Cube:
                        createCube(eraser, start, stop);
                        createCube(pen, start, e.Location);
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



        private Rectangle MakeRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);
            return new Rectangle(x, y, width, height);
        }

        private Rectangle makeSquare(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.X - p2.X);

            return new Rectangle(x, y, width, height);
        }


        PointF[] shape;
        private PointF[] createPolygon(Point start, Point stop)
        {
            // Find the center
            var x0 = (start.X + stop.X) / 2;
            var y0 = (start.Y + stop.Y) / 2;

            shape = new PointF[polygonSides];

            float angle = 360 / polygonSides;

            float r = (float)Math.Sqrt(Math.Pow((start.X - stop.X), 2) + Math.Pow((start.Y - stop.Y), 2)) / 2;

            for (int a = 0; a < polygonSides; a++)
            {
                shape[a] = new PointF(
                    x0 + r * (float)Math.Cos(a * angle * Math.PI / 180f),
                    y0 + r * (float)Math.Sin(a * angle * Math.PI / 180f));
            }
            return shape;
        }




        private void createDiamond(Pen penUsed, Point start, Point stop, bool drawFill)
        {
            // Find the center
            var centerX = (start.X + stop.X) / 2;
            var centerY = (start.Y + stop.Y) / 2;

            PointF[] diamond = new PointF[4];

            diamond[0] = new PointF(centerX, start.Y); // Top point
            diamond[1] = new PointF(stop.X, centerY); // Right point
            diamond[2] = new PointF(centerX, stop.Y); // Bottom point
            diamond[3] = new PointF(start.X, centerY); // Left point

            graphics.DrawPolygon(penUsed, diamond);

            if (drawFill)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPolygon(diamond);
                    graphics.FillPolygon(brush, diamond);
                    graphics.DrawPolygon(penUsed, diamond);
                }
            }
        }

        private void createTriangle(Pen penUsed, Point start, Point stop, bool drawFill)
        {
            // Find the center
            var centerX = (start.X + stop.X) / 2;
            var centerY = (start.Y + stop.Y) / 2;

            PointF[] triangle = new PointF[3];

            triangle[0] = new PointF(centerX, start.Y); // Top point
            triangle[1] = new PointF(stop.X, stop.Y);   // Right-bottom point
            triangle[2] = new PointF(start.X, stop.Y);  // Left-bottom point

            graphics.DrawPolygon(penUsed, triangle);

            if (drawFill)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPolygon(triangle);
                    graphics.FillPolygon(brush, triangle);
                    graphics.DrawPolygon(penUsed, triangle);
                }
            }
        }



        private void createCross(Pen penUsed, Point start, Point stop, bool drawFill)
        {
            int minX = Math.Min(start.X, stop.X);
            int minY = Math.Min(start.Y, stop.Y);
            int maxX = Math.Max(start.X, stop.X);
            int maxY = Math.Max(start.Y, stop.Y);

            int width = maxX - minX;
            int height = maxY - minY;

            int crossWidth = width / 3;
            int crossHeight = height / 3;

            Point[] crossPoints = new Point[12];

            crossPoints[0] = new Point(minX + crossWidth, minY);
            crossPoints[1] = new Point(minX + 2 * crossWidth, minY);
            crossPoints[2] = new Point(minX + 2 * crossWidth, minY + crossHeight);
            crossPoints[3] = new Point(maxX, minY + crossHeight);
            crossPoints[4] = new Point(maxX, minY + 2 * crossHeight);
            crossPoints[5] = new Point(minX + 2 * crossWidth, minY + 2 * crossHeight);
            crossPoints[6] = new Point(minX + 2 * crossWidth, maxY);
            crossPoints[7] = new Point(minX + crossWidth, maxY);
            crossPoints[8] = new Point(minX + crossWidth, minY + 2 * crossHeight);
            crossPoints[9] = new Point(minX, minY + 2 * crossHeight);
            crossPoints[10] = new Point(minX, minY + crossHeight);
            crossPoints[11] = new Point(minX + crossWidth, minY + crossHeight);

            graphics.DrawPolygon(penUsed, crossPoints);

            if (drawFill)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPolygon(crossPoints);
                    graphics.FillPolygon(brush, crossPoints); // Fill using the Point[] array directly
                    graphics.DrawPolygon(penUsed, crossPoints);   // Draw the outline
                }
            }

        }

        private void createStar(Pen penUsed, Point start, Point stop, bool drawFill)
        {
            int numPoints = 5;

            int minX = Math.Min(start.X, stop.X);
            int minY = Math.Min(start.Y, stop.Y);
            int maxX = Math.Max(start.X, stop.X);
            int maxY = Math.Max(start.Y, stop.Y);

            int width = maxX - minX;
            int height = maxY - minY;

            int outerRadius = Math.Min(width, height) / 2;
            int innerRadius = outerRadius / 2;

            Point center = new Point(minX + width / 2, minY + height / 2);

            Point[] starPoints = new Point[2 * numPoints];
            double angle = Math.PI / numPoints;

            for (int i = 0; i < 2 * numPoints; i++)
            {
                double radius = (i % 2 == 0) ? outerRadius : innerRadius;
                starPoints[i] = new Point(
                    center.X + (int)(radius * Math.Cos(i * angle - Math.PI / 2)),
                    center.Y + (int)(radius * Math.Sin(i * angle - Math.PI / 2))
                );
            }

            graphics.DrawPolygon(penUsed, starPoints);

            if (drawFill)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddPolygon(starPoints);
                    graphics.FillPolygon(brush, starPoints); // Fill using the Point[] array directly
                    graphics.DrawPolygon(penUsed, starPoints); // Draw the outline
                }
            }
        }


        private void createHeart(Pen penUsed, Point start, Point stop, bool drawFill)
        {
            int minX = Math.Min(start.X, stop.X);
            int minY = Math.Min(start.Y, stop.Y);
            int maxX = Math.Max(start.X, stop.X);
            int maxY = Math.Max(start.Y, stop.Y);

            int width = maxX - minX;
            int height = maxY - minY;

            Point[] heartPoints = new Point[7];

            // Top left curve
            heartPoints[0] = new Point(minX + width / 2, minY + height / 5);
            heartPoints[1] = new Point(minX + width / 10, minY);

            // Bottom left curve
            heartPoints[2] = new Point(minX, minY + 3 * height / 5);
            heartPoints[3] = new Point(minX + width / 2, maxY);

            // Bottom right curve
            heartPoints[4] = new Point(maxX, minY + 3 * height / 5);
            heartPoints[5] = new Point(maxX - width / 10, minY);

            // Top right curve
            heartPoints[6] = new Point(minX + width / 2, minY + height / 5);

            graphics.DrawBezier(penUsed, heartPoints[0], heartPoints[1], heartPoints[2], heartPoints[3]);
            graphics.DrawBezier(penUsed, heartPoints[3], heartPoints[4], heartPoints[5], heartPoints[6]);

            if (drawFill)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddBezier(heartPoints[0], heartPoints[1], heartPoints[2], heartPoints[3]);
                    path.AddBezier(heartPoints[3], heartPoints[4], heartPoints[5], heartPoints[6]);
                    graphics.FillPath(brush, path); // Fill using the GraphicsPath
                    graphics.DrawPath(penUsed, path); // Draw the outline
                }
            }
        }

        private void createCube(Pen penUsed, Point start, Point stop)
        {
            int minX = Math.Min(start.X, stop.X);
            int minY = Math.Min(start.Y, stop.Y);
            int maxX = Math.Max(start.X, stop.X);
            int maxY = Math.Max(start.Y, stop.Y);

            int width = maxX - minX;
            int height = maxY - minY;

            int cubeWidth = width / 3;
            int cubeHeight = height / 3;

            Point[] cubeFront = new Point[4];
            Point[] cubeBack = new Point[4];

            // Front face of the cube
            cubeFront[0] = new Point(minX + cubeWidth, minY);
            cubeFront[1] = new Point(maxX, minY);
            cubeFront[2] = new Point(maxX - cubeWidth, minY + cubeHeight);
            cubeFront[3] = new Point(minX, minY + cubeHeight);

            // Back face of the cube (simulated by shifting the front face)
            cubeBack[0] = new Point(cubeFront[0].X, cubeFront[0].Y + cubeHeight);
            cubeBack[1] = new Point(cubeFront[1].X, cubeFront[1].Y + cubeHeight);
            cubeBack[2] = new Point(cubeFront[2].X, cubeFront[2].Y + cubeHeight);
            cubeBack[3] = new Point(cubeFront[3].X, cubeFront[3].Y + cubeHeight);

            // Draw the front face
            graphics.DrawPolygon(penUsed, cubeFront);

            // Draw the connecting edges
            for (int i = 0; i < 4; i++)
            {
                graphics.DrawLine(penUsed, cubeFront[i], cubeBack[i]);
            }

            // Draw the back face
            graphics.DrawPolygon(penUsed, cubeBack);

            // Connect the vertices between front and back faces
            for (int i = 0; i < 4; i++)
            {
                graphics.DrawLine(penUsed, cubeFront[i], cubeBack[i]);
            }
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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // Assuming 'bitmap' is defined somewhere and initialized properly
                bitmap.Save(saveFileDialog.FileName);
            }
        }



        //-----------------------Brush Tools-----------------------//

        // Color picker dialog for the primary color
        private void ColorPicker1_Click(object sender, EventArgs e)
        {
            if (ColorPickerDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorPicker1.BackColor = ColorPickerDialog.Color;
                pen.Color = ColorPickerDialog.Color;
                brush = new SolidBrush(ColorPickerDialog.Color);
            }
        }

        // Color picker dialog for the secondary color
        private void ColorPicker2_Click(object sender, EventArgs e)
        {
            if (ColorPickerDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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

            // And switch the pen color
            pen.Color = ColorPicker1.BackColor;
        }


        private void ClearCanvas_Click(object sender, EventArgs e)
        {
            // Clear the bitmap with a white background
            graphics.Clear(Color.White);
            Canvas.Invalidate(); // Refresh the canvas
        }

        private void FillSelectButton_Click(object sender, EventArgs e)
        {
            fill = !fill;
            if (fill)
            {
                FillSelectButton.BackColor = Color.DarkGray;
            }
            else
            {
                FillSelectButton.BackColor = Color.Transparent;
            }
        }

        private void brushWidthTrackbar_Scroll(object sender, EventArgs e)
        {
            brushThickness = brushWidthTrackbar.Value;
            pen.Width = brushThickness;
            eraser.Width = brushThickness;
            brushThicknessValueLabel.Text = "Size: " + brushThickness;
        }


        //-----------------------Tool Picker-----------------------//

        private void RectangleSelectButton_Click(object sender, EventArgs e)
        {
            curTool = DrawingTool.Rectangle;
            CurrentToolLabel.Text = "Current Tool: Rectangle";
        }


        private void PolygonSelectorButton_Click(object sender, EventArgs e)
        {
            curTool = DrawingTool.Polygon;
            polygonCornerPanel.Show();
            CurrentToolLabel.Text = "Current Tool: Polygon";
        }

        private void circleSelectButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Circle;
            CurrentToolLabel.Text = "Current Tool: Circle";
        }

        private void SquareSelectButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Square;
            CurrentToolLabel.Text = "Current Tool: Square";
        }

        private void Diamond_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Diamond;
            CurrentToolLabel.Text = "Current Tool: Diamond";
        }

        private void CrossSelectButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Cross;
            CurrentToolLabel.Text = "Current Tool: Cross";
        }

        private void EraserSelectButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Eraser;
            CurrentToolLabel.Text = "Current Tool: Eraser";
        }

        private void TriangleSelectButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Triangle;
            CurrentToolLabel.Text = "Current Tool: Triangle";
        }

        private void StarSelectorButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Star;
            CurrentToolLabel.Text = "Current Tool: Star";
        }

        private void heartButtonSelector_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Heart;
            CurrentToolLabel.Text = "Current Tool: Heart";
        }

        private void cubeSelectButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Cube;
            CurrentToolLabel.Text = "Current tool: Check-Mark";
        }

        private void polygonCornerTrackBar_Scroll(object sender, EventArgs e)
        {
            polygonSides = polygonCornerTrackBar.Value;
            polygonSidesLabel.Text = "Polygon Sides: " + polygonSides;
        }

        private void LineSelectorButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Line;
            CurrentToolLabel.Text = "Current Tool: Line";
        }

        private void EllipseSelectButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();

            curTool = DrawingTool.Ellipse;
            CurrentToolLabel.Text = "Current Tool: Ellipse";
        }
 
        

    }
}