namespace MiniPaint
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPicture = new System.Windows.Forms.PictureBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.IdColor = new System.Windows.Forms.Label();
            this.groupBoxShape = new System.Windows.Forms.GroupBox();
            this.btn_curve = new System.Windows.Forms.Button();
            this.btnEllips = new System.Windows.Forms.Button();
            this.btnSquere = new System.Windows.Forms.Button();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSize = new System.Windows.Forms.GroupBox();
            this.sizeBar = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.groupBoxShape.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.menu.SuspendLayout();
            this.groupBoxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.imgPicture);
            this.panel1.Location = new System.Drawing.Point(22, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 513);
            this.panel1.TabIndex = 0;
            // 
            // imgPicture
            // 
            this.imgPicture.Location = new System.Drawing.Point(-1, -1);
            this.imgPicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(890, 514);
            this.imgPicture.TabIndex = 0;
            this.imgPicture.TabStop = false;
            this.imgPicture.Click += new System.EventHandler(this.imgPicture_Click);
            this.imgPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgPicture_MouseDown);
            this.imgPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgPicture_MouseMove);
            this.imgPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgPicture_MouseUp);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(6, 32);
            this.btnClean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(87, 38);
            this.btnClean.TabIndex = 2;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // IdColor
            // 
            this.IdColor.BackColor = System.Drawing.Color.Black;
            this.IdColor.Location = new System.Drawing.Point(17, 23);
            this.IdColor.Name = "IdColor";
            this.IdColor.Size = new System.Drawing.Size(46, 57);
            this.IdColor.TabIndex = 4;
            this.IdColor.Click += new System.EventHandler(this.IdColor_Click);
            // 
            // groupBoxShape
            // 
            this.groupBoxShape.Controls.Add(this.btn_curve);
            this.groupBoxShape.Controls.Add(this.btnEllips);
            this.groupBoxShape.Controls.Add(this.btnSquere);
            this.groupBoxShape.Location = new System.Drawing.Point(215, 576);
            this.groupBoxShape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxShape.Name = "groupBoxShape";
            this.groupBoxShape.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxShape.Size = new System.Drawing.Size(297, 95);
            this.groupBoxShape.TabIndex = 5;
            this.groupBoxShape.TabStop = false;
            this.groupBoxShape.Text = "Shapes";
            // 
            // btn_curve
            // 
            this.btn_curve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_curve.Location = new System.Drawing.Point(204, 27);
            this.btn_curve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_curve.Name = "btn_curve";
            this.btn_curve.Size = new System.Drawing.Size(84, 48);
            this.btn_curve.TabIndex = 5;
            this.btn_curve.Text = "Pencil";
            this.btn_curve.UseVisualStyleBackColor = true;
            this.btn_curve.Click += new System.EventHandler(this.btn_curve_Click);
            // 
            // btnEllips
            // 
            this.btnEllips.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEllips.Location = new System.Drawing.Point(112, 27);
            this.btnEllips.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEllips.Name = "btnEllips";
            this.btnEllips.Size = new System.Drawing.Size(86, 48);
            this.btnEllips.TabIndex = 4;
            this.btnEllips.Text = "Circle";
            this.btnEllips.UseVisualStyleBackColor = true;
            this.btnEllips.Click += new System.EventHandler(this.btnEllips_Click);
            // 
            // btnSquere
            // 
            this.btnSquere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSquere.Location = new System.Drawing.Point(6, 27);
            this.btnSquere.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSquere.Name = "btnSquere";
            this.btnSquere.Size = new System.Drawing.Size(100, 48);
            this.btnSquere.TabIndex = 3;
            this.btnSquere.Text = "Rectangle";
            this.btnSquere.UseVisualStyleBackColor = true;
            this.btnSquere.Click += new System.EventHandler(this.btnSquere_Click);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.IdColor);
            this.groupBoxColor.Location = new System.Drawing.Point(518, 576);
            this.groupBoxColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxColor.Size = new System.Drawing.Size(75, 95);
            this.groupBoxColor.TabIndex = 6;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.btnRedo);
            this.groupBoxAction.Controls.Add(this.btnUndo);
            this.groupBoxAction.Controls.Add(this.btnClean);
            this.groupBoxAction.Location = new System.Drawing.Point(599, 576);
            this.groupBoxAction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxAction.Size = new System.Drawing.Size(281, 95);
            this.groupBoxAction.TabIndex = 7;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Actions";
            // 
            // btnRedo
            // 
            this.btnRedo.Enabled = false;
            this.btnRedo.Location = new System.Drawing.Point(178, 32);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(97, 38);
            this.btnRedo.TabIndex = 6;
            this.btnRedo.Text = "Redo";
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(99, 32);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(73, 38);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.Control;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu.Size = new System.Drawing.Size(928, 33);
            this.menu.TabIndex = 8;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.fileToolStripMenuItem.Text = "Options";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(101, 29);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // polishToolStripMenuItem
            // 
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            this.polishToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.polishToolStripMenuItem.Text = "Polish";
            this.polishToolStripMenuItem.Click += new System.EventHandler(this.polishToolStripMenuItem_Click);
            // 
            // groupBoxSize
            // 
            this.groupBoxSize.Controls.Add(this.sizeBar);
            this.groupBoxSize.Location = new System.Drawing.Point(58, 569);
            this.groupBoxSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSize.Name = "groupBoxSize";
            this.groupBoxSize.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSize.Size = new System.Drawing.Size(157, 102);
            this.groupBoxSize.TabIndex = 9;
            this.groupBoxSize.TabStop = false;
            this.groupBoxSize.Text = "Size";
            // 
            // sizeBar
            // 
            this.sizeBar.Location = new System.Drawing.Point(7, 18);
            this.sizeBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sizeBar.Minimum = 1;
            this.sizeBar.Name = "sizeBar";
            this.sizeBar.Size = new System.Drawing.Size(150, 69);
            this.sizeBar.TabIndex = 0;
            this.sizeBar.Value = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(928, 684);
            this.Controls.Add(this.groupBoxSize);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxShape);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PaintPluginSystem";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.groupBoxShape.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxAction.ResumeLayout(false);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.groupBoxSize.ResumeLayout(false);
            this.groupBoxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label IdColor;
        private System.Windows.Forms.GroupBox groupBoxShape;
        private System.Windows.Forms.Button btnEllips;
        private System.Windows.Forms.Button btnSquere;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.PictureBox imgPicture;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxSize;
        private System.Windows.Forms.TrackBar sizeBar;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.Button btn_curve;
    }
}

