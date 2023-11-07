using System;

namespace atomiki1
{
    partial class Shapes
    {
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

    }
}