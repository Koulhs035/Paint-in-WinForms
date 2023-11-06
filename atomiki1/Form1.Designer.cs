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
            this.ButtonFile = new System.Windows.Forms.Button();
            this.FileMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBoxPanel = new System.Windows.Forms.Panel();
            this.SwapColorsButton = new System.Windows.Forms.Button();
            this.ColorPicker1 = new System.Windows.Forms.Button();
            this.ColorPicker2 = new System.Windows.Forms.Button();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ColorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.stripMenuRc.SuspendLayout();
            this.TopPanelTools.SuspendLayout();
            this.FileMenuStrip.SuspendLayout();
            this.ToolBoxPanel.SuspendLayout();
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
            this.TopPanelTools.Controls.Add(this.ButtonFile);
            this.TopPanelTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanelTools.Location = new System.Drawing.Point(0, 0);
            this.TopPanelTools.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TopPanelTools.Name = "TopPanelTools";
            this.TopPanelTools.Size = new System.Drawing.Size(1063, 29);
            this.TopPanelTools.TabIndex = 1;
            // 
            // ButtonFile
            // 
            this.ButtonFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonFile.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFile.ContextMenuStrip = this.FileMenuStrip;
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
            // ToolBoxPanel
            // 
            this.ToolBoxPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ToolBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.ColorPicker1.BackColor = System.Drawing.Color.White;
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
            this.ColorPicker2.BackColor = System.Drawing.Color.Black;
            this.ColorPicker2.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.ColorPicker2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorPicker2.Location = new System.Drawing.Point(1016, 13);
            this.ColorPicker2.Name = "ColorPicker2";
            this.ColorPicker2.Size = new System.Drawing.Size(33, 28);
            this.ColorPicker2.TabIndex = 2;
            this.ColorPicker2.UseVisualStyleBackColor = false;
            this.ColorPicker2.Click += new System.EventHandler(this.ColorPicker2_Click);
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.Transparent;
            this.Canvas.Location = new System.Drawing.Point(80, 116);
            this.Canvas.Margin = new System.Windows.Forms.Padding(0);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(891, 362);
            this.Canvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Canvas.TabIndex = 3;
            this.Canvas.TabStop = false;
            this.Canvas.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.Canvas_LoadCompleted);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 537);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1063, 32);
            this.BottomPanel.TabIndex = 4;
            // 
            // ShapeDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1063, 569);
            this.ContextMenuStrip = this.stripMenuRc;
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.ToolBoxPanel);
            this.Controls.Add(this.TopPanelTools);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Name = "ShapeDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shape Designer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.stripMenuRc.ResumeLayout(false);
            this.TopPanelTools.ResumeLayout(false);
            this.FileMenuStrip.ResumeLayout(false);
            this.ToolBoxPanel.ResumeLayout(false);
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
    }
}

