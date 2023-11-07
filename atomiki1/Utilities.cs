using System;
using System.Drawing; // Assuming you're using System.Drawing for 'bitmap' variable
using System.Windows.Forms; // You seem to be working with Windows Forms

namespace atomiki1
{
    partial class Shapes
    {
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



        //-----------------------Color picker-----------------------//

        // Color picker dialog for the primary color
        private void ColorPicker1_Click(object sender, EventArgs e)
        {
            if (ColorPickerDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ColorPicker1.BackColor = ColorPickerDialog.Color;
                pen.Color = ColorPickerDialog.Color;
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










    }
}
