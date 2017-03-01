namespace Paint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DrawSpace = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Pencil = new System.Windows.Forms.ToolStripButton();
            this.Brush = new System.Windows.Forms.ToolStripButton();
            this.Fill = new System.Windows.Forms.ToolStripButton();
            this.Eraser = new System.Windows.Forms.ToolStripButton();
            this.Write = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.switchColor = new System.Windows.Forms.PictureBox();
            this.frontColor = new System.Windows.Forms.PictureBox();
            this.behindColor = new System.Windows.Forms.PictureBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.blackColor = new System.Windows.Forms.ToolStripButton();
            this.whiteColor = new System.Windows.Forms.ToolStripButton();
            this.redColor = new System.Windows.Forms.ToolStripButton();
            this.greenColor = new System.Windows.Forms.ToolStripButton();
            this.blueColor = new System.Windows.Forms.ToolStripButton();
            this.yellowColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LineSize = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toaDoX = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toaDoY = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawSpace)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behindColor)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(663, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.resizToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // resizToolStripMenuItem
            // 
            this.resizToolStripMenuItem.Name = "resizToolStripMenuItem";
            this.resizToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.resizToolStripMenuItem.Text = "R&esiz";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // DrawSpace
            // 
            this.DrawSpace.BackColor = System.Drawing.Color.White;
            this.DrawSpace.Location = new System.Drawing.Point(27, 96);
            this.DrawSpace.Name = "DrawSpace";
            this.DrawSpace.Size = new System.Drawing.Size(621, 325);
            this.DrawSpace.TabIndex = 1;
            this.DrawSpace.TabStop = false;
            this.DrawSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawSpace_MouseDown);
            this.DrawSpace.MouseLeave += new System.EventHandler(this.DrawSpace_MouseLeave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pencil,
            this.Brush,
            this.Fill,
            this.Eraser,
            this.Write,
            this.toolStripButton8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(24, 421);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Pencil
            // 
            this.Pencil.CheckOnClick = true;
            this.Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
            this.Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(21, 20);
            this.Pencil.Text = "toolStripButton3";
            // 
            // Brush
            // 
            this.Brush.CheckOnClick = true;
            this.Brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Brush.Image = ((System.Drawing.Image)(resources.GetObject("Brush.Image")));
            this.Brush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Brush.Name = "Brush";
            this.Brush.Size = new System.Drawing.Size(21, 20);
            this.Brush.Text = "toolStripButton1";
            // 
            // Fill
            // 
            this.Fill.CheckOnClick = true;
            this.Fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fill.Image = ((System.Drawing.Image)(resources.GetObject("Fill.Image")));
            this.Fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(21, 20);
            this.Fill.Text = "toolStripButton2";
            // 
            // Eraser
            // 
            this.Eraser.CheckOnClick = true;
            this.Eraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Eraser.Image")));
            this.Eraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(21, 20);
            this.Eraser.Text = "toolStripButton4";
            // 
            // Write
            // 
            this.Write.CheckOnClick = true;
            this.Write.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Write.Image = ((System.Drawing.Image)(resources.GetObject("Write.Image")));
            this.Write.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(21, 20);
            this.Write.Text = "toolStripButton5";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.CheckOnClick = true;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.toolStrip3);
            this.panel1.Controls.Add(this.switchColor);
            this.panel1.Controls.Add(this.frontColor);
            this.panel1.Controls.Add(this.behindColor);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(27, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 75);
            this.panel1.TabIndex = 4;
            // 
            // toolStrip3
            // 
            this.toolStrip3.AutoSize = false;
            this.toolStrip3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2,
            this.toolStripSeparator3});
            this.toolStrip3.Location = new System.Drawing.Point(0, 36);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(592, 33);
            this.toolStrip3.TabIndex = 7;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox2.Text = "Fill Style";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // switchColor
            // 
            this.switchColor.Image = ((System.Drawing.Image)(resources.GetObject("switchColor.Image")));
            this.switchColor.Location = new System.Drawing.Point(595, 36);
            this.switchColor.Name = "switchColor";
            this.switchColor.Size = new System.Drawing.Size(10, 12);
            this.switchColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.switchColor.TabIndex = 5;
            this.switchColor.TabStop = false;
            this.switchColor.Click += new System.EventHandler(this.switchColor_Click);
            // 
            // frontColor
            // 
            this.frontColor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.frontColor.Location = new System.Drawing.Point(608, 24);
            this.frontColor.Name = "frontColor";
            this.frontColor.Size = new System.Drawing.Size(25, 24);
            this.frontColor.TabIndex = 6;
            this.frontColor.TabStop = false;
            this.frontColor.Click += new System.EventHandler(this.frontColor_Click);
            // 
            // behindColor
            // 
            this.behindColor.BackColor = System.Drawing.Color.White;
            this.behindColor.Location = new System.Drawing.Point(595, 9);
            this.behindColor.Name = "behindColor";
            this.behindColor.Size = new System.Drawing.Size(25, 24);
            this.behindColor.TabIndex = 5;
            this.behindColor.TabStop = false;
            this.behindColor.Click += new System.EventHandler(this.behindColor_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripSeparator2,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator1,
            this.blackColor,
            this.whiteColor,
            this.redColor,
            this.greenColor,
            this.blueColor,
            this.yellowColor,
            this.toolStripLabel1,
            this.LineSize,
            this.toolStripComboBox3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(592, 36);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 36);
            this.toolStripComboBox1.Text = "Font";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.CheckOnClick = true;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 33);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.CheckOnClick = true;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 33);
            this.toolStripButton7.Text = "toolStripButton7";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.CheckOnClick = true;
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 33);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.CheckOnClick = true;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 33);
            this.toolStripButton10.Text = "toolStripButton10";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // blackColor
            // 
            this.blackColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blackColor.Image = ((System.Drawing.Image)(resources.GetObject("blackColor.Image")));
            this.blackColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blackColor.Name = "blackColor";
            this.blackColor.Size = new System.Drawing.Size(23, 33);
            this.blackColor.Text = "toolStripButton12";
            this.blackColor.Click += new System.EventHandler(this.blackColor_Click);
            // 
            // whiteColor
            // 
            this.whiteColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.whiteColor.Image = ((System.Drawing.Image)(resources.GetObject("whiteColor.Image")));
            this.whiteColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.whiteColor.Name = "whiteColor";
            this.whiteColor.Size = new System.Drawing.Size(23, 33);
            this.whiteColor.Text = "toolStripButton13";
            this.whiteColor.Click += new System.EventHandler(this.whiteColor_Click);
            // 
            // redColor
            // 
            this.redColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redColor.Image = ((System.Drawing.Image)(resources.GetObject("redColor.Image")));
            this.redColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redColor.Name = "redColor";
            this.redColor.Size = new System.Drawing.Size(23, 33);
            this.redColor.Text = "toolStripButton11";
            this.redColor.Click += new System.EventHandler(this.redColor_Click);
            // 
            // greenColor
            // 
            this.greenColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.greenColor.Image = ((System.Drawing.Image)(resources.GetObject("greenColor.Image")));
            this.greenColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenColor.Name = "greenColor";
            this.greenColor.Size = new System.Drawing.Size(23, 33);
            this.greenColor.Text = "toolStripButton14";
            this.greenColor.Click += new System.EventHandler(this.greenColor_Click);
            // 
            // blueColor
            // 
            this.blueColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.blueColor.Image = ((System.Drawing.Image)(resources.GetObject("blueColor.Image")));
            this.blueColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blueColor.Name = "blueColor";
            this.blueColor.Size = new System.Drawing.Size(23, 33);
            this.blueColor.Text = "toolStripButton15";
            this.blueColor.Click += new System.EventHandler(this.blueColor_Click);
            // 
            // yellowColor
            // 
            this.yellowColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.yellowColor.Image = ((System.Drawing.Image)(resources.GetObject("yellowColor.Image")));
            this.yellowColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.yellowColor.Name = "yellowColor";
            this.yellowColor.Size = new System.Drawing.Size(23, 33);
            this.yellowColor.Text = "toolStripButton16";
            this.yellowColor.Click += new System.EventHandler(this.yellowColor_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(52, 33);
            this.toolStripLabel1.Text = "Line Size";
            // 
            // LineSize
            // 
            this.LineSize.Name = "LineSize";
            this.LineSize.Size = new System.Drawing.Size(121, 36);
            this.LineSize.SelectedIndexChanged += new System.EventHandler(this.LineSize_SelectedIndexChanged);
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 23);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // toaDoX
            // 
            this.toaDoX.AutoSize = true;
            this.toaDoX.Location = new System.Drawing.Point(110, 428);
            this.toaDoX.Name = "toaDoX";
            this.toaDoX.Size = new System.Drawing.Size(35, 13);
            this.toaDoX.TabIndex = 6;
            this.toaDoX.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y";
            // 
            // toaDoY
            // 
            this.toaDoY.AutoSize = true;
            this.toaDoY.Location = new System.Drawing.Point(192, 428);
            this.toaDoY.Name = "toaDoY";
            this.toaDoY.Size = new System.Drawing.Size(35, 13);
            this.toaDoY.TabIndex = 8;
            this.toaDoY.Text = "label4";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(663, 445);
            this.Controls.Add(this.toaDoY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toaDoX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DrawSpace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawSpace)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frontColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behindColor)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox DrawSpace;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Brush;
        private System.Windows.Forms.ToolStripButton Fill;
        private System.Windows.Forms.ToolStripButton Pencil;
        private System.Windows.Forms.ToolStripButton Eraser;
        private System.Windows.Forms.ToolStripButton Write;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton blackColor;
        private System.Windows.Forms.ToolStripButton whiteColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton redColor;
        private System.Windows.Forms.ToolStripButton greenColor;
        private System.Windows.Forms.ToolStripButton blueColor;
        private System.Windows.Forms.ToolStripButton yellowColor;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox LineSize;
        private System.Windows.Forms.PictureBox frontColor;
        private System.Windows.Forms.PictureBox behindColor;
        private System.Windows.Forms.PictureBox switchColor;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toaDoX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label toaDoY;
    }
}

