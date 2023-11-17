// Ignore Spelling: atomiki

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
            Cube,
            Annotate
        }
        DrawingTool curTool = DrawingTool.None;

        public Shapes()
        {
            InitializeComponent();
            Canvas.Focus();
        }

        List<insertedShape> toolList = new List<insertedShape>();



        //-----------------------Draw-----------------------//
        Graphics graphics;
        Bitmap bitmap;

        Point start, stop;
        List<Point> points = new List<Point>();
        Pen pen, eraser;
        Brush brush = new SolidBrush(Color.Black);
        int brushThickness = 8;
        bool draw;
        bool fill = false;
        int polygonSides = 5;

        private struct insertedShape
        {
            public DrawingTool tool;
            public Point start, stop;
            public Pen pen;
            public Brush brush;
            public int polygonSides, thickness; // Assign a default value here
            public bool fill;

            // Constructor for insertedShape struct
            public insertedShape(
                DrawingTool tool,
                Point start,
                Point stop,
                Color penColor,
                Color brushColor,
                int polygonSides,
                int penThickness,
                bool fill)
            {
                this.tool = tool;
                this.start = start;
                this.stop = stop;
                this.thickness = penThickness; // Assign a default value to brushThickness
                this.pen = new Pen(penColor, penThickness);
                this.brush = new SolidBrush(brushColor); // Initializing Brush with provided color
                this.polygonSides = polygonSides;
                this.fill = fill;
            }
        }
        private void ShapeDesigner_Load(object sender, EventArgs e)
        {
            bitmap = new Bitmap(Canvas.Width, Canvas.Height);

            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);


            pen = new Pen(Color.Black, brushThickness);
            eraser = new Pen(Canvas.BackColor, brushThickness);

            Canvas.Image = bitmap;
        }

        //
        //-----------------------Mouse events-----------------------//
        //

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
            drawShape(curTool, pen, brush, start, stop, polygonSides, fill);
            insertedShape shape = new insertedShape(curTool, start, stop, pen.Color, ColorPicker2.BackColor, polygonSides, brushThickness, fill);
            toolList.Add(shape);
        }

        private void drawShape(DrawingTool tool, Pen curPen, Brush curBrush, Point startP, Point stopP, int sides, bool fillShape)
        {

            switch (tool)
            {
                case DrawingTool.None:
                    break;

                case DrawingTool.Line:
                    graphics.DrawLine(curPen, startP, stopP);
                    break;

                case DrawingTool.Rectangle:
                    graphics.DrawRectangle(curPen, MakeRectangle(startP, stopP));
                    if (fillShape)
                        graphics.FillRectangle(curBrush, MakeRectangle(startP, stopP));
                    break;

                case DrawingTool.Polygon:
                    graphics.DrawPolygon(curPen, createPolygon(startP, stopP, sides));
                    if (fillShape)
                        graphics.FillPolygon(brush, createPolygon(startP, stopP, sides));
                    break;

                case DrawingTool.Ellipse:
                    graphics.DrawEllipse(curPen, MakeRectangle(startP, stopP));
                    if (fillShape)
                        graphics.FillEllipse(curBrush, MakeRectangle(startP, stopP));
                    break;

                case DrawingTool.Circle:
                    graphics.DrawEllipse(curPen, makeSquare(startP, stopP));
                    if (fillShape)
                        graphics.FillEllipse(curBrush, makeSquare(startP, stopP));
                    break;
                case DrawingTool.Square:
                    graphics.DrawRectangle(curPen, makeSquare(startP, stopP));
                    if (fillShape)
                        graphics.FillRectangle(curBrush, makeSquare(startP, stopP));
                    break;

                case DrawingTool.Diamond:
                    createDiamond(curPen, startP, stopP, false);
                    if (fillShape)
                        createDiamond(curPen, startP, stopP, true);
                    break;

                case DrawingTool.Cross:
                    createCross(curPen, startP, stopP, false);
                    if (fillShape)
                        createCross(curPen, startP, stopP, true);
                    break;
                case DrawingTool.Triangle:
                    createTriangle(curPen, startP, stopP, false);
                    if (fillShape)
                        createTriangle(pen, startP, stopP, true);
                    break;
                case DrawingTool.Star:
                    createStar(curPen, startP, stopP, false);
                    if (fillShape)
                        createStar(curPen, startP, stopP, true);
                    break;
                case DrawingTool.Heart:
                    createHeart(curPen, startP, stopP, false);
                    if (fillShape)
                        createHeart(curPen, startP, stopP, true);
                    break;
                case DrawingTool.Cube:
                    createCube(curPen, startP, stopP);
                    break;

            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if (draw)
            {
               redrawCanvas();

                drawShape(curTool, eraser, brush, start, stop, polygonSides, false);
                drawShape(curTool, pen, brush, start, e.Location, polygonSides, false);
                stop = e.Location;

            }

            Canvas.Refresh();
            //Changes the Mouse coordinates label
            MouseCoordsLabel.Text = e.X + ", " + e.Y + "px";

        }

        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            MouseCoordsLabel.Text = "";
        }

        //
        //-----------------------Shape designs-----------------------//
        //

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
        private PointF[] createPolygon(Point start, Point stop, int sides)
        {
            // Find the center
            var x0 = (start.X + stop.X) / 2;
            var y0 = (start.Y + stop.Y) / 2;

            shape = new PointF[sides];

            float angle = 360 / sides;

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


        //
        //-----------------------Strip Menus-----------------------//
        //
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
            saveFileDialog.FileName = ".png";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bitmap.Save(saveFileDialog.FileName);
            }
        }


        //
        //-----------------------Canvas Tools-----------------------//
        //
        private void redrawCanvas()
        {
            foreach (insertedShape insShape in toolList)
            {
                drawShape(insShape.tool, insShape.pen, insShape.brush, insShape.start, insShape.stop, insShape.polygonSides, insShape.fill);
            }
        }

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
            toolList.Clear();
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
        int distance = 5;
        private void Shapes_KeyDown(object sender, KeyEventArgs e)
        {
            if (toolList.Count == 0) return; // Check if toolList is empty

            int last = toolList.Count - 1;
            insertedShape lastShape = toolList[last];

            Point newStartPoint = lastShape.start;
            Point newStopPoint = lastShape.stop;

            // Check keyboard input and update points accordingly
            switch (e.KeyData)
            {
                case Keys.D:
                    newStartPoint = new Point(lastShape.start.X + distance, lastShape.start.Y);
                    newStopPoint = new Point(lastShape.stop.X + distance, lastShape.stop.Y);
                    break;
                case Keys.A:
                    newStartPoint = new Point(lastShape.start.X - distance, lastShape.start.Y);
                    newStopPoint = new Point(lastShape.stop.X - distance, lastShape.stop.Y);
                    break;
                case Keys.W:
                    newStartPoint = new Point(lastShape.start.X, lastShape.start.Y - distance);
                    newStopPoint = new Point(lastShape.stop.X, lastShape.stop.Y - distance);
                    break;
                case Keys.S:
                    newStartPoint = new Point(lastShape.start.X, lastShape.start.Y + distance);
                    newStopPoint = new Point(lastShape.stop.X, lastShape.stop.Y + distance);
                    break;
                case Keys.Q:
                    newStartPoint = new Point(lastShape.start.X + distance, lastShape.start.Y + distance);
                    newStopPoint = new Point(lastShape.stop.X - distance, lastShape.stop.Y - distance);
                    break;
                case Keys.E:
                    newStartPoint = new Point(lastShape.start.X - distance, lastShape.start.Y - distance);
                    newStopPoint = new Point(lastShape.stop.X + distance, lastShape.stop.Y + distance);
                    break;
            }


            // Create updated shape with the new points
            insertedShape updatedShape = new insertedShape(
                lastShape.tool,
                newStartPoint,
                newStopPoint,
                lastShape.pen.Color,
                ((SolidBrush)lastShape.brush).Color,
                lastShape.polygonSides,
                lastShape.thickness,
                lastShape.fill
            );

            // Update the last shape in toolList with the updated shape

            insertedShape eraseShape = toolList[last];
            toolList[last] = updatedShape;
            drawShape(eraseShape.tool, eraser, brush, eraseShape.start, eraseShape.stop, eraseShape.polygonSides, false);
            redrawCanvas();
            Canvas.Refresh();
        }

        //
        //-----------------------Tool Picker-----------------------//
        //

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

        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (toolList.Count > 0)
                toolList.RemoveAt(toolList.Count - 1);

            graphics.Clear(Color.White);
            Canvas.Invalidate(); // Refresh the canvas
            redrawCanvas();


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
        private void annotateSelectButton_Click(object sender, EventArgs e)
        {
            polygonCornerPanel.Hide();
            AnnotationTextBox.Show();
            curTool = DrawingTool.Annotate;
            CurrentToolLabel.Text = "Current Tool: Annotate";
        }
    }
}