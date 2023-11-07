using System.Drawing;
using System.Windows.Forms;

namespace atomiki1
{
    partial class ShapeDesigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanelTools = new System.Windows.Forms.Panel();
            this.ClearCanvas = new System.Windows.Forms.Button();
            this.FileMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonFile = new System.Windows.Forms.Button();
            this.ToolBoxPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LineSelectorButton = new System.Windows.Forms.Button();
            this.PolygonSelectorButton = new System.Windows.Forms.Button();
            this.RectangleSelectButton = new System.Windows.Forms.Button();
            this.EllipseSelectButton = new System.Windows.Forms.Button();
            this.SwapColorsButton = new System.Windows.Forms.Button();
            this.ColorPicker1 = new System.Windows.Forms.Button();
            this.ColorPicker2 = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MouseCoordsLabel = new System.Windows.Forms.Label();
            this.rightBorderPanel = new System.Windows.Forms.Panel();
            this.CurrentToolLabel = new System.Windows.Forms.Label();
            this.ColorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.LeftFiller = new System.Windows.Forms.Panel();
            this.RightFiller = new System.Windows.Forms.Panel();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TopPanelTools.SuspendLayout();
            this.FileMenuStrip.SuspendLayout();
            this.ToolBoxPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanelTools
            // 
            this.TopPanelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TopPanelTools.Controls.Add(this.ClearCanvas);
            this.TopPanelTools.Controls.Add(this.ButtonFile);
            this.TopPanelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelTools.Location = new System.Drawing.Point(0, 0);
            this.TopPanelTools.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.TopPanelTools.Name = "TopPanelTools";
            this.TopPanelTools.Size = new System.Drawing.Size(1417, 36);
            this.TopPanelTools.TabIndex = 1;
            // 
            // ClearCanvas
            // 
            this.ClearCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClearCanvas.BackColor = System.Drawing.Color.Transparent;
            this.ClearCanvas.ContextMenuStrip = this.FileMenuStrip;
            this.ClearCanvas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearCanvas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClearCanvas.FlatAppearance.BorderSize = 0;
            this.ClearCanvas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearCanvas.ForeColor = System.Drawing.Color.White;
            this.ClearCanvas.Location = new System.Drawing.Point(84, 0);
            this.ClearCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.ClearCanvas.Name = "ClearCanvas";
            this.ClearCanvas.Size = new System.Drawing.Size(84, 36);
            this.ClearCanvas.TabIndex = 1;
            this.ClearCanvas.Text = "Clear";
            this.ClearCanvas.UseVisualStyleBackColor = false;
            this.ClearCanvas.Click += new System.EventHandler(this.ClearCanvas_Click);
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.FileMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitAppToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.ShowItemToolTips = false;
            this.FileMenuStrip.Size = new System.Drawing.Size(101, 76);
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitAppToolStripMenuItem.Text = "Exit";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.stripMenuExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(97, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.ToolTipText = "Load Image";
            // 
            // ButtonFile
            // 
            this.ButtonFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonFile.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFile.ContextMenuStrip = this.FileMenuStrip;
            this.ButtonFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonFile.FlatAppearance.BorderSize = 0;
            this.ButtonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFile.ForeColor = System.Drawing.Color.White;
            this.ButtonFile.Location = new System.Drawing.Point(0, 0);
            this.ButtonFile.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonFile.Name = "ButtonFile";
            this.ButtonFile.Size = new System.Drawing.Size(84, 36);
            this.ButtonFile.TabIndex = 0;
            this.ButtonFile.Text = "File";
            this.ButtonFile.UseVisualStyleBackColor = false;
            this.ButtonFile.Click += new System.EventHandler(this.ButtonFile_Click);
            // 
            // ToolBoxPanel
            // 
            this.ToolBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToolBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBoxPanel.Controls.Add(this.panel3);
            this.ToolBoxPanel.Controls.Add(this.flowLayoutPanel1);
            this.ToolBoxPanel.Controls.Add(this.SwapColorsButton);
            this.ToolBoxPanel.Controls.Add(this.ColorPicker1);
            this.ToolBoxPanel.Controls.Add(this.ColorPicker2);
            this.ToolBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBoxPanel.Location = new System.Drawing.Point(0, 36);
            this.ToolBoxPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.ToolBoxPanel.Name = "ToolBoxPanel";
            this.ToolBoxPanel.Size = new System.Drawing.Size(1417, 88);
            this.ToolBoxPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(226, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 86);
            this.panel3.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LineSelectorButton);
            this.flowLayoutPanel1.Controls.Add(this.PolygonSelectorButton);
            this.flowLayoutPanel1.Controls.Add(this.RectangleSelectButton);
            this.flowLayoutPanel1.Controls.Add(this.EllipseSelectButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(226, 86);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // LineSelectorButton
            // 
            this.LineSelectorButton.BackgroundImage = global::atomiki1.Properties.Resources.White_Line_PNG;
            this.LineSelectorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineSelectorButton.FlatAppearance.BorderSize = 0;
            this.LineSelectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineSelectorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineSelectorButton.ForeColor = System.Drawing.Color.White;
            this.LineSelectorButton.Location = new System.Drawing.Point(4, 4);
            this.LineSelectorButton.Margin = new System.Windows.Forms.Padding(4);
            this.LineSelectorButton.Name = "LineSelectorButton";
            this.LineSelectorButton.Size = new System.Drawing.Size(35, 28);
            this.LineSelectorButton.TabIndex = 0;
            this.LineSelectorButton.UseVisualStyleBackColor = true;
            this.LineSelectorButton.Click += new System.EventHandler(this.LineSelectorButton_Click);
            // 
            // PolygonSelectorButton
            // 
            this.PolygonSelectorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PolygonSelectorButton.BackgroundImage = global::atomiki1.Properties.Resources.polygon;
            this.PolygonSelectorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PolygonSelectorButton.FlatAppearance.BorderSize = 0;
            this.PolygonSelectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolygonSelectorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PolygonSelectorButton.ForeColor = System.Drawing.Color.White;
            this.PolygonSelectorButton.Location = new System.Drawing.Point(47, 4);
            this.PolygonSelectorButton.Margin = new System.Windows.Forms.Padding(4);
            this.PolygonSelectorButton.Name = "PolygonSelectorButton";
            this.PolygonSelectorButton.Size = new System.Drawing.Size(35, 28);
            this.PolygonSelectorButton.TabIndex = 2;
            this.PolygonSelectorButton.UseVisualStyleBackColor = true;
            this.PolygonSelectorButton.Click += new System.EventHandler(this.PolygonSelectorButton_Click);
            // 
            // RectangleSelectButton
            // 
            this.RectangleSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.rectangle1;
            this.RectangleSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleSelectButton.FlatAppearance.BorderSize = 0;
            this.RectangleSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangleSelectButton.ForeColor = System.Drawing.Color.White;
            this.RectangleSelectButton.Location = new System.Drawing.Point(90, 4);
            this.RectangleSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.RectangleSelectButton.Name = "RectangleSelectButton";
            this.RectangleSelectButton.Size = new System.Drawing.Size(35, 28);
            this.RectangleSelectButton.TabIndex = 1;
            this.RectangleSelectButton.UseVisualStyleBackColor = true;
            this.RectangleSelectButton.Click += new System.EventHandler(this.RectangleSelectButton_Click);
            // 
            // EllipseSelectButton
            // 
            this.EllipseSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EllipseSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.ellipse;
            this.EllipseSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EllipseSelectButton.FlatAppearance.BorderSize = 0;
            this.EllipseSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EllipseSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EllipseSelectButton.ForeColor = System.Drawing.Color.White;
            this.EllipseSelectButton.Location = new System.Drawing.Point(133, 4);
            this.EllipseSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.EllipseSelectButton.Name = "EllipseSelectButton";
            this.EllipseSelectButton.Size = new System.Drawing.Size(35, 28);
            this.EllipseSelectButton.TabIndex = 3;
            this.EllipseSelectButton.UseVisualStyleBackColor = true;
            this.EllipseSelectButton.Click += new System.EventHandler(this.EllipseSelectButton_Click);
            // 
            // SwapColorsButton
            // 
            this.SwapColorsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SwapColorsButton.BackgroundImage = global::atomiki1.Properties.Resources.swap;
            this.SwapColorsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwapColorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwapColorsButton.FlatAppearance.BorderSize = 0;
            this.SwapColorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SwapColorsButton.Location = new System.Drawing.Point(1301, 22);
            this.SwapColorsButton.Margin = new System.Windows.Forms.Padding(4);
            this.SwapColorsButton.Name = "SwapColorsButton";
            this.SwapColorsButton.Size = new System.Drawing.Size(32, 28);
            this.SwapColorsButton.TabIndex = 3;
            this.SwapColorsButton.UseVisualStyleBackColor = true;
            this.SwapColorsButton.Click += new System.EventHandler(this.SwapColorsButton_Click);
            // 
            // ColorPicker1
            // 
            this.ColorPicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPicker1.BackColor = System.Drawing.Color.Black;
            this.ColorPicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPicker1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ColorPicker1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPicker1.Location = new System.Drawing.Point(1341, 33);
            this.ColorPicker1.Margin = new System.Windows.Forms.Padding(4);
            this.ColorPicker1.Name = "ColorPicker1";
            this.ColorPicker1.Size = new System.Drawing.Size(44, 34);
            this.ColorPicker1.TabIndex = 0;
            this.ColorPicker1.TabStop = false;
            this.ColorPicker1.UseVisualStyleBackColor = false;
            this.ColorPicker1.Click += new System.EventHandler(this.ColorPicker1_Click);
            // 
            // ColorPicker2
            // 
            this.ColorPicker2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPicker2.BackColor = System.Drawing.Color.White;
            this.ColorPicker2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorPicker2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ColorPicker2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPicker2.Location = new System.Drawing.Point(1355, 16);
            this.ColorPicker2.Margin = new System.Windows.Forms.Padding(4);
            this.ColorPicker2.Name = "ColorPicker2";
            this.ColorPicker2.Size = new System.Drawing.Size(44, 34);
            this.ColorPicker2.TabIndex = 2;
            this.ColorPicker2.UseVisualStyleBackColor = false;
            this.ColorPicker2.Click += new System.EventHandler(this.ColorPicker2_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BottomPanel.Controls.Add(this.panel1);
            this.BottomPanel.Controls.Add(this.CurrentToolLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BottomPanel.Location = new System.Drawing.Point(0, 661);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1417, 39);
            this.BottomPanel.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MouseCoordsLabel);
            this.panel1.Controls.Add(this.rightBorderPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 39);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImage = global::atomiki1.Properties.Resources.white_mouse;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MouseCoordsLabel
            // 
            this.MouseCoordsLabel.AutoSize = true;
            this.MouseCoordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseCoordsLabel.ForeColor = System.Drawing.Color.White;
            this.MouseCoordsLabel.Location = new System.Drawing.Point(43, 9);
            this.MouseCoordsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MouseCoordsLabel.Name = "MouseCoordsLabel";
            this.MouseCoordsLabel.Size = new System.Drawing.Size(56, 18);
            this.MouseCoordsLabel.TabIndex = 0;
            this.MouseCoordsLabel.Text = "            ";
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.BackColor = System.Drawing.Color.White;
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(164, 0);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(1, 39);
            this.rightBorderPanel.TabIndex = 2;
            // 
            // CurrentToolLabel
            // 
            this.CurrentToolLabel.AutoSize = true;
            this.CurrentToolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentToolLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentToolLabel.Location = new System.Drawing.Point(168, 9);
            this.CurrentToolLabel.Name = "CurrentToolLabel";
            this.CurrentToolLabel.Size = new System.Drawing.Size(95, 18);
            this.CurrentToolLabel.TabIndex = 5;
            this.CurrentToolLabel.Text = "Current Tool:";
            // 
            // LeftFiller
            // 
            this.LeftFiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LeftFiller.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftFiller.Location = new System.Drawing.Point(0, 124);
            this.LeftFiller.Margin = new System.Windows.Forms.Padding(4);
            this.LeftFiller.Name = "LeftFiller";
            this.LeftFiller.Size = new System.Drawing.Size(133, 537);
            this.LeftFiller.TabIndex = 5;
            // 
            // RightFiller
            // 
            this.RightFiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RightFiller.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightFiller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.RightFiller.Location = new System.Drawing.Point(1284, 124);
            this.RightFiller.Margin = new System.Windows.Forms.Padding(4);
            this.RightFiller.Name = "RightFiller";
            this.RightFiller.Size = new System.Drawing.Size(133, 537);
            this.RightFiller.TabIndex = 6;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 124);
            this.Canvas.Margin = new System.Windows.Forms.Padding(0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1417, 576);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 3;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseLeave += new System.EventHandler(this.Canvas_MouseLeave);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // ShapeDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1417, 700);
            this.Controls.Add(this.RightFiller);
            this.Controls.Add(this.LeftFiller);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.ToolBoxPanel);
            this.Controls.Add(this.TopPanelTools);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShapeDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Designer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShapeDesigner_Load);
            this.Resize += new System.EventHandler(this.ShapeDesigner_Resize);
            this.TopPanelTools.ResumeLayout(false);
            this.FileMenuStrip.ResumeLayout(false);
            this.ToolBoxPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopPanelTools;
        private System.Windows.Forms.Panel ToolBoxPanel;
        private System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button ButtonFile;
        private System.Windows.Forms.ContextMenuStrip FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button ColorPicker1;
        private System.Windows.Forms.Button ColorPicker2;
        private System.Windows.Forms.ColorDialog ColorPickerDialog;
        private System.Windows.Forms.Button SwapColorsButton;
        private System.Windows.Forms.Button ClearCanvas;
        private System.Windows.Forms.Label MouseCoordsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel LeftFiller;
        private System.Windows.Forms.Panel RightFiller;
        private System.Windows.Forms.Button LineSelectorButton;
        private System.Windows.Forms.Button RectangleSelectButton;
        private System.Windows.Forms.Button PolygonSelectorButton;
        private System.Windows.Forms.Label CurrentToolLabel;
        private System.Windows.Forms.Panel panel1;
        private Panel rightBorderPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Button EllipseSelectButton;
        private ToolStripMenuItem saveToolStripMenuItem;
        private SaveFileDialog saveFileDialog;
        private ToolStripMenuItem loadToolStripMenuItem;
    }
}

