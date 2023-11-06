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
            this.stripMenuRc = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanelTools = new System.Windows.Forms.Panel();
            this.ClearCanvas = new System.Windows.Forms.Button();
            this.FileMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonFile = new System.Windows.Forms.Button();
            this.ToolBoxPanel = new System.Windows.Forms.Panel();
            this.ColorPicker1 = new System.Windows.Forms.Button();
            this.ColorPicker2 = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.MouseCoordsLabel = new System.Windows.Forms.Label();
            this.ColorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.LeftFiller = new System.Windows.Forms.Panel();
            this.RightFiller = new System.Windows.Forms.Panel();
            this.ShapesPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.LineSelectorButton = new System.Windows.Forms.Button();
            this.SwapColorsButton = new System.Windows.Forms.Button();
            this.stripMenuRc.SuspendLayout();
            this.TopPanelTools.SuspendLayout();
            this.FileMenuStrip.SuspendLayout();
            this.ToolBoxPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.ShapesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // stripMenuRc
            // 
            this.stripMenuRc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuExit});
            this.stripMenuRc.Name = "stripMenuRc";
            this.stripMenuRc.Size = new System.Drawing.Size(94, 26);
            // 
            // stripMenuExit
            // 
            this.stripMenuExit.Name = "stripMenuExit";
            this.stripMenuExit.Size = new System.Drawing.Size(93, 22);
            this.stripMenuExit.Text = "Exit";
            this.stripMenuExit.Click += new System.EventHandler(this.stripMenuExit_Click);
            // 
            // TopPanelTools
            // 
            this.TopPanelTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
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
            this.ClearCanvas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.toolStripSeparator1});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.ShowItemToolTips = false;
            this.FileMenuStrip.Size = new System.Drawing.Size(94, 32);
            // 
            // exitAppToolStripMenuItem
            // 
            this.exitAppToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            this.exitAppToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitAppToolStripMenuItem.Text = "Exit";
            this.exitAppToolStripMenuItem.Click += new System.EventHandler(this.stripMenuExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(90, 6);
            // 
            // ButtonFile
            // 
            this.ButtonFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonFile.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFile.ContextMenuStrip = this.FileMenuStrip;
            this.ButtonFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.ToolBoxPanel.Controls.Add(this.ShapesPanel);
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
            this.BottomPanel.Controls.Add(this.pictureBox1);
            this.BottomPanel.Controls.Add(this.MouseCoordsLabel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 537);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1063, 32);
            this.BottomPanel.TabIndex = 4;
            // 
            // MouseCoordsLabel
            // 
            this.MouseCoordsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MouseCoordsLabel.AutoSize = true;
            this.MouseCoordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MouseCoordsLabel.ForeColor = System.Drawing.Color.White;
            this.MouseCoordsLabel.Location = new System.Drawing.Point(30, 7);
            this.MouseCoordsLabel.Name = "MouseCoordsLabel";
            this.MouseCoordsLabel.Size = new System.Drawing.Size(0, 18);
            this.MouseCoordsLabel.TabIndex = 0;
            // 
            // LeftFiller
            // 
            this.LeftFiller.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftFiller.Location = new System.Drawing.Point(0, 101);
            this.LeftFiller.Name = "LeftFiller";
            this.LeftFiller.Size = new System.Drawing.Size(100, 436);
            this.LeftFiller.TabIndex = 5;
            // 
            // RightFiller
            // 
            this.RightFiller.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightFiller.Location = new System.Drawing.Point(963, 101);
            this.RightFiller.Name = "RightFiller";
            this.RightFiller.Size = new System.Drawing.Size(100, 436);
            this.RightFiller.TabIndex = 6;
            // 
            // ShapesPanel
            // 
            this.ShapesPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.ShapesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ShapesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShapesPanel.Controls.Add(this.LineSelectorButton);
            this.ShapesPanel.Location = new System.Drawing.Point(11, 5);
            this.ShapesPanel.Name = "ShapesPanel";
            this.ShapesPanel.Size = new System.Drawing.Size(186, 60);
            this.ShapesPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.BackgroundImage = global::atomiki1.Properties.Resources.white_mouse;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.Color.White;
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
            // LineSelectorButton
            // 
            this.LineSelectorButton.BackgroundImage = global::atomiki1.Properties.Resources.White_Line_PNG;
            this.LineSelectorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LineSelectorButton.FlatAppearance.BorderSize = 0;
            this.LineSelectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LineSelectorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineSelectorButton.ForeColor = System.Drawing.Color.White;
            this.LineSelectorButton.Location = new System.Drawing.Point(3, 2);
            this.LineSelectorButton.Name = "LineSelectorButton";
            this.LineSelectorButton.Size = new System.Drawing.Size(26, 23);
            this.LineSelectorButton.TabIndex = 0;
            this.LineSelectorButton.UseVisualStyleBackColor = true;
            this.LineSelectorButton.Click += new System.EventHandler(this.LineSelectorButton_Click);
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
            // ShapeDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1063, 569);
            this.ContextMenuStrip = this.stripMenuRc;
            this.Controls.Add(this.RightFiller);
            this.Controls.Add(this.LeftFiller);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.ToolBoxPanel);
            this.Controls.Add(this.TopPanelTools);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Name = "ShapeDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Designer";
            this.Load += new System.EventHandler(this.ShapeDesigner_Load);
            this.Resize += new System.EventHandler(this.ShapeDesigner_Resize);
            this.stripMenuRc.ResumeLayout(false);
            this.TopPanelTools.ResumeLayout(false);
            this.FileMenuStrip.ResumeLayout(false);
            this.ToolBoxPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ShapesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip stripMenuRc;
        private System.Windows.Forms.ToolStripMenuItem stripMenuExit;
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
        private System.Windows.Forms.Panel ShapesPanel;
        private System.Windows.Forms.Button LineSelectorButton;
    }
}

