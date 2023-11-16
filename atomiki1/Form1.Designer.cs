using System.Drawing;
using System.Windows.Forms;

namespace atomiki1
{
    partial class Shapes
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
            this.ToolsLayoutPanel = new System.Windows.Forms.Panel();
            this.FillSelectButton = new System.Windows.Forms.Button();
            this.EraserSelectButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LineSelectorButton = new System.Windows.Forms.Button();
            this.PolygonSelectorButton = new System.Windows.Forms.Button();
            this.RectangleSelectButton = new System.Windows.Forms.Button();
            this.EllipseSelectButton = new System.Windows.Forms.Button();
            this.circleSelectButton = new System.Windows.Forms.Button();
            this.SquareSelectButton = new System.Windows.Forms.Button();
            this.DiamondSelectButton = new System.Windows.Forms.Button();
            this.CrossSelectButton = new System.Windows.Forms.Button();
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
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.brushWidthTrackbar = new System.Windows.Forms.TrackBar();
            this.brushThicknessValueLabel = new System.Windows.Forms.Label();
            this.TopPanelTools.SuspendLayout();
            this.FileMenuStrip.SuspendLayout();
            this.ToolBoxPanel.SuspendLayout();
            this.ToolsLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushWidthTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanelTools
            // 
            this.TopPanelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TopPanelTools.Controls.Add(this.ClearCanvas);
            this.TopPanelTools.Controls.Add(this.ButtonFile);
            this.TopPanelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelTools.Location = new System.Drawing.Point(0, 0);
            this.TopPanelTools.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TopPanelTools.Name = "TopPanelTools";
            this.TopPanelTools.Size = new System.Drawing.Size(1063, 29);
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
            this.ClearCanvas.Location = new System.Drawing.Point(63, 0);
            this.ClearCanvas.Margin = new System.Windows.Forms.Padding(0);
            this.ClearCanvas.Name = "ClearCanvas";
            this.ClearCanvas.Size = new System.Drawing.Size(63, 29);
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
            this.ButtonFile.Size = new System.Drawing.Size(63, 29);
            this.ButtonFile.TabIndex = 0;
            this.ButtonFile.Text = "File";
            this.ButtonFile.UseVisualStyleBackColor = false;
            this.ButtonFile.Click += new System.EventHandler(this.ButtonFile_Click);
            // 
            // ToolBoxPanel
            // 
            this.ToolBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToolBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolBoxPanel.Controls.Add(this.brushThicknessValueLabel);
            this.ToolBoxPanel.Controls.Add(this.brushWidthTrackbar);
            this.ToolBoxPanel.Controls.Add(this.ToolsLayoutPanel);
            this.ToolBoxPanel.Controls.Add(this.panel3);
            this.ToolBoxPanel.Controls.Add(this.flowLayoutPanel1);
            this.ToolBoxPanel.Controls.Add(this.SwapColorsButton);
            this.ToolBoxPanel.Controls.Add(this.ColorPicker1);
            this.ToolBoxPanel.Controls.Add(this.ColorPicker2);
            this.ToolBoxPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBoxPanel.Location = new System.Drawing.Point(0, 29);
            this.ToolBoxPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ToolBoxPanel.Name = "ToolBoxPanel";
            this.ToolBoxPanel.Size = new System.Drawing.Size(1063, 72);
            this.ToolBoxPanel.TabIndex = 2;
            // 
            // ToolsLayoutPanel
            // 
            this.ToolsLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToolsLayoutPanel.Controls.Add(this.FillSelectButton);
            this.ToolsLayoutPanel.Controls.Add(this.EraserSelectButton);
            this.ToolsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolsLayoutPanel.Location = new System.Drawing.Point(171, 0);
            this.ToolsLayoutPanel.Name = "ToolsLayoutPanel";
            this.ToolsLayoutPanel.Size = new System.Drawing.Size(36, 70);
            this.ToolsLayoutPanel.TabIndex = 7;
            // 
            // FillSelectButton
            // 
            this.FillSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FillSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.bucket;
            this.FillSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FillSelectButton.FlatAppearance.BorderSize = 0;
            this.FillSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FillSelectButton.ForeColor = System.Drawing.Color.White;
            this.FillSelectButton.Location = new System.Drawing.Point(5, 32);
            this.FillSelectButton.Name = "FillSelectButton";
            this.FillSelectButton.Size = new System.Drawing.Size(26, 23);
            this.FillSelectButton.TabIndex = 6;
            this.FillSelectButton.UseVisualStyleBackColor = true;
            this.FillSelectButton.Click += new System.EventHandler(this.FillSelectButton_Click);
            // 
            // EraserSelectButton
            // 
            this.EraserSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EraserSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.eraser;
            this.EraserSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EraserSelectButton.FlatAppearance.BorderSize = 0;
            this.EraserSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EraserSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EraserSelectButton.ForeColor = System.Drawing.Color.White;
            this.EraserSelectButton.Location = new System.Drawing.Point(5, 3);
            this.EraserSelectButton.Name = "EraserSelectButton";
            this.EraserSelectButton.Size = new System.Drawing.Size(26, 23);
            this.EraserSelectButton.TabIndex = 5;
            this.EraserSelectButton.UseVisualStyleBackColor = true;
            this.EraserSelectButton.Click += new System.EventHandler(this.EraserSelectButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(170, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 70);
            this.panel3.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.LineSelectorButton);
            this.flowLayoutPanel1.Controls.Add(this.RectangleSelectButton);
            this.flowLayoutPanel1.Controls.Add(this.circleSelectButton);
            this.flowLayoutPanel1.Controls.Add(this.SquareSelectButton);
            this.flowLayoutPanel1.Controls.Add(this.EllipseSelectButton);
            this.flowLayoutPanel1.Controls.Add(this.DiamondSelectButton);
            this.flowLayoutPanel1.Controls.Add(this.CrossSelectButton);
            this.flowLayoutPanel1.Controls.Add(this.PolygonSelectorButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 70);
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
            this.LineSelectorButton.Location = new System.Drawing.Point(3, 3);
            this.LineSelectorButton.Name = "LineSelectorButton";
            this.LineSelectorButton.Size = new System.Drawing.Size(26, 23);
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
            this.PolygonSelectorButton.Location = new System.Drawing.Point(67, 32);
            this.PolygonSelectorButton.Name = "PolygonSelectorButton";
            this.PolygonSelectorButton.Size = new System.Drawing.Size(26, 23);
            this.PolygonSelectorButton.TabIndex = 2;
            this.PolygonSelectorButton.UseVisualStyleBackColor = true;
            this.PolygonSelectorButton.Click += new System.EventHandler(this.PolygonSelectorButton_Click);
            // 
            // RectangleSelectButton
            // 
            this.RectangleSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.rectangle;
            this.RectangleSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RectangleSelectButton.FlatAppearance.BorderSize = 0;
            this.RectangleSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RectangleSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RectangleSelectButton.ForeColor = System.Drawing.Color.White;
            this.RectangleSelectButton.Location = new System.Drawing.Point(35, 3);
            this.RectangleSelectButton.Name = "RectangleSelectButton";
            this.RectangleSelectButton.Size = new System.Drawing.Size(26, 23);
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
            this.EllipseSelectButton.Location = new System.Drawing.Point(131, 3);
            this.EllipseSelectButton.Name = "EllipseSelectButton";
            this.EllipseSelectButton.Size = new System.Drawing.Size(26, 23);
            this.EllipseSelectButton.TabIndex = 3;
            this.EllipseSelectButton.UseVisualStyleBackColor = true;
            this.EllipseSelectButton.Click += new System.EventHandler(this.EllipseSelectButton_Click);
            // 
            // circleSelectButton
            // 
            this.circleSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.circleSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.circle;
            this.circleSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circleSelectButton.FlatAppearance.BorderSize = 0;
            this.circleSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circleSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleSelectButton.ForeColor = System.Drawing.Color.White;
            this.circleSelectButton.Location = new System.Drawing.Point(67, 3);
            this.circleSelectButton.Name = "circleSelectButton";
            this.circleSelectButton.Size = new System.Drawing.Size(26, 23);
            this.circleSelectButton.TabIndex = 4;
            this.circleSelectButton.UseVisualStyleBackColor = true;
            this.circleSelectButton.Click += new System.EventHandler(this.circleSelectButton_Click);
            // 
            // SquareSelectButton
            // 
            this.SquareSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SquareSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.square;
            this.SquareSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SquareSelectButton.FlatAppearance.BorderSize = 0;
            this.SquareSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SquareSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SquareSelectButton.ForeColor = System.Drawing.Color.White;
            this.SquareSelectButton.Location = new System.Drawing.Point(99, 3);
            this.SquareSelectButton.Name = "SquareSelectButton";
            this.SquareSelectButton.Size = new System.Drawing.Size(26, 23);
            this.SquareSelectButton.TabIndex = 5;
            this.SquareSelectButton.UseVisualStyleBackColor = true;
            this.SquareSelectButton.Click += new System.EventHandler(this.SquareSelectButton_Click);
            // 
            // DiamondSelectButton
            // 
            this.DiamondSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DiamondSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.diamond;
            this.DiamondSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DiamondSelectButton.FlatAppearance.BorderSize = 0;
            this.DiamondSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiamondSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiamondSelectButton.ForeColor = System.Drawing.Color.White;
            this.DiamondSelectButton.Location = new System.Drawing.Point(3, 32);
            this.DiamondSelectButton.Name = "DiamondSelectButton";
            this.DiamondSelectButton.Size = new System.Drawing.Size(26, 23);
            this.DiamondSelectButton.TabIndex = 6;
            this.DiamondSelectButton.UseVisualStyleBackColor = true;
            this.DiamondSelectButton.Click += new System.EventHandler(this.Diamond_Click);
            // 
            // CrossSelectButton
            // 
            this.CrossSelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CrossSelectButton.BackgroundImage = global::atomiki1.Properties.Resources.cross;
            this.CrossSelectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CrossSelectButton.FlatAppearance.BorderSize = 0;
            this.CrossSelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CrossSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossSelectButton.ForeColor = System.Drawing.Color.White;
            this.CrossSelectButton.Location = new System.Drawing.Point(35, 32);
            this.CrossSelectButton.Name = "CrossSelectButton";
            this.CrossSelectButton.Size = new System.Drawing.Size(26, 23);
            this.CrossSelectButton.TabIndex = 7;
            this.CrossSelectButton.UseVisualStyleBackColor = true;
            this.CrossSelectButton.Click += new System.EventHandler(this.CrossSelectButton_Click);
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
            this.SwapColorsButton.Location = new System.Drawing.Point(976, 18);
            this.SwapColorsButton.Name = "SwapColorsButton";
            this.SwapColorsButton.Size = new System.Drawing.Size(24, 23);
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
            this.ColorPicker1.Location = new System.Drawing.Point(1006, 27);
            this.ColorPicker1.Name = "ColorPicker1";
            this.ColorPicker1.Size = new System.Drawing.Size(33, 28);
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
            this.ColorPicker2.Location = new System.Drawing.Point(1016, 13);
            this.ColorPicker2.Name = "ColorPicker2";
            this.ColorPicker2.Size = new System.Drawing.Size(33, 28);
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
            this.BottomPanel.Location = new System.Drawing.Point(0, 537);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1063, 32);
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
            this.panel1.Size = new System.Drawing.Size(124, 32);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImage = global::atomiki1.Properties.Resources.white_mouse;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MouseCoordsLabel
            // 
            this.MouseCoordsLabel.AutoSize = true;
            this.MouseCoordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseCoordsLabel.ForeColor = System.Drawing.Color.White;
            this.MouseCoordsLabel.Location = new System.Drawing.Point(32, 7);
            this.MouseCoordsLabel.Name = "MouseCoordsLabel";
            this.MouseCoordsLabel.Size = new System.Drawing.Size(56, 18);
            this.MouseCoordsLabel.TabIndex = 0;
            this.MouseCoordsLabel.Text = "            ";
            // 
            // rightBorderPanel
            // 
            this.rightBorderPanel.BackColor = System.Drawing.Color.White;
            this.rightBorderPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorderPanel.Location = new System.Drawing.Point(123, 0);
            this.rightBorderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightBorderPanel.Name = "rightBorderPanel";
            this.rightBorderPanel.Size = new System.Drawing.Size(1, 32);
            this.rightBorderPanel.TabIndex = 2;
            // 
            // CurrentToolLabel
            // 
            this.CurrentToolLabel.AutoSize = true;
            this.CurrentToolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentToolLabel.ForeColor = System.Drawing.Color.White;
            this.CurrentToolLabel.Location = new System.Drawing.Point(126, 7);
            this.CurrentToolLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentToolLabel.Name = "CurrentToolLabel";
            this.CurrentToolLabel.Size = new System.Drawing.Size(95, 18);
            this.CurrentToolLabel.TabIndex = 5;
            this.CurrentToolLabel.Text = "Current Tool:";
            // 
            // LeftFiller
            // 
            this.LeftFiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LeftFiller.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftFiller.Location = new System.Drawing.Point(0, 101);
            this.LeftFiller.Name = "LeftFiller";
            this.LeftFiller.Size = new System.Drawing.Size(100, 436);
            this.LeftFiller.TabIndex = 5;
            // 
            // RightFiller
            // 
            this.RightFiller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RightFiller.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightFiller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.RightFiller.Location = new System.Drawing.Point(963, 101);
            this.RightFiller.Name = "RightFiller";
            this.RightFiller.Size = new System.Drawing.Size(100, 436);
            this.RightFiller.TabIndex = 6;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 101);
            this.Canvas.Margin = new System.Windows.Forms.Padding(0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(1063, 468);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 3;
            this.Canvas.TabStop = false;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseLeave += new System.EventHandler(this.Canvas_MouseLeave);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // brushWidthTrackbar
            // 
            this.brushWidthTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.brushWidthTrackbar.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.brushWidthTrackbar.Location = new System.Drawing.Point(213, 0);
            this.brushWidthTrackbar.Maximum = 26;
            this.brushWidthTrackbar.Minimum = 5;
            this.brushWidthTrackbar.Name = "brushWidthTrackbar";
            this.brushWidthTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.brushWidthTrackbar.Size = new System.Drawing.Size(45, 71);
            this.brushWidthTrackbar.TabIndex = 8;
            this.brushWidthTrackbar.Value = 8;
            this.brushWidthTrackbar.Scroll += new System.EventHandler(this.brushWidthTrackbar_Scroll);
            // 
            // brushThicknessValueLabel
            // 
            this.brushThicknessValueLabel.AutoSize = true;
            this.brushThicknessValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brushThicknessValueLabel.ForeColor = System.Drawing.Color.White;
            this.brushThicknessValueLabel.Location = new System.Drawing.Point(209, -1);
            this.brushThicknessValueLabel.Name = "brushThicknessValueLabel";
            this.brushThicknessValueLabel.Size = new System.Drawing.Size(46, 16);
            this.brushThicknessValueLabel.TabIndex = 10;
            this.brushThicknessValueLabel.Text = "Size: 8";
            // 
            // Shapes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1063, 569);
            this.Controls.Add(this.RightFiller);
            this.Controls.Add(this.LeftFiller);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.ToolBoxPanel);
            this.Controls.Add(this.TopPanelTools);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Name = "Shapes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Designer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ShapeDesigner_Load);
            this.TopPanelTools.ResumeLayout(false);
            this.FileMenuStrip.ResumeLayout(false);
            this.ToolBoxPanel.ResumeLayout(false);
            this.ToolBoxPanel.PerformLayout();
            this.ToolsLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brushWidthTrackbar)).EndInit();
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
        private Button circleSelectButton;
        private Button SquareSelectButton;
        private Button DiamondSelectButton;
        private Button CrossSelectButton;
        private Button FillSelectButton;
        private Button EraserSelectButton;
        private Panel ToolsLayoutPanel;
        private TrackBar brushWidthTrackbar;
        private Label brushThicknessValueLabel;
    }
}

