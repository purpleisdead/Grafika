namespace KomputarnaGrafika
{
    partial class DrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutCtrlXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteCtrlVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Group = new System.Windows.Forms.ToolStripMenuItem();
            this.ungroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RectangleButton = new System.Windows.Forms.ToolStripButton();
            this.ElipseButton = new System.Windows.Forms.ToolStripButton();
            this.LineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.NameLayout = new System.Windows.Forms.ToolStripLabel();
            this.NameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.FiguresLayout = new System.Windows.Forms.ToolStripLabel();
            this.ListOfNamesComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WTextBox = new System.Windows.Forms.TextBox();
            this.HTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.W = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.Label();
            this.RectF = new System.Windows.Forms.Label();
            this.RotateButton = new System.Windows.Forms.Button();
            this.Rotate = new System.Windows.Forms.Label();
            this.RotateValues = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Thickness = new System.Windows.Forms.Label();
            this.ThicknessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FillColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BorderdColorButton = new System.Windows.Forms.Button();
            this.BorderColorDialog = new System.Windows.Forms.ColorDialog();
            this.FillColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.edithToolStripMenuItem,
            this.modifyToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveCtrlSToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exportToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveCtrlSToolStripMenuItem.Text = "Save    Ctrl + S";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(146, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // edithToolStripMenuItem
            // 
            this.edithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutCtrlXToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteCtrlVToolStripMenuItem,
            this.toolStripSeparator4,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator5,
            this.selectAllCtrlAToolStripMenuItem});
            this.edithToolStripMenuItem.Name = "edithToolStripMenuItem";
            this.edithToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.edithToolStripMenuItem.Text = "Edit";
            // 
            // cutCtrlXToolStripMenuItem
            // 
            this.cutCtrlXToolStripMenuItem.Name = "cutCtrlXToolStripMenuItem";
            this.cutCtrlXToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cutCtrlXToolStripMenuItem.Text = "Cut     Ctrl + X";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.copyToolStripMenuItem.Text = "Copy    Ctrl + C";
            // 
            // pasteCtrlVToolStripMenuItem
            // 
            this.pasteCtrlVToolStripMenuItem.Name = "pasteCtrlVToolStripMenuItem";
            this.pasteCtrlVToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pasteCtrlVToolStripMenuItem.Text = "Paste   Ctrl + V";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(164, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // selectAllCtrlAToolStripMenuItem
            // 
            this.selectAllCtrlAToolStripMenuItem.Name = "selectAllCtrlAToolStripMenuItem";
            this.selectAllCtrlAToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.selectAllCtrlAToolStripMenuItem.Text = "Select all  Ctrl + A";
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Group,
            this.ungroupToolStripMenuItem});
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.modifyToolStripMenuItem.Text = "Modify";
            // 
            // Group
            // 
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(121, 22);
            this.Group.Text = "Group";
            this.Group.Click += new System.EventHandler(this.Group_Click);
            // 
            // ungroupToolStripMenuItem
            // 
            this.ungroupToolStripMenuItem.Name = "ungroupToolStripMenuItem";
            this.ungroupToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.ungroupToolStripMenuItem.Text = "Ungroup";
            this.ungroupToolStripMenuItem.Click += new System.EventHandler(this.Ungroup_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(699, 479);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawObject);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RectangleButton,
            this.ElipseButton,
            this.LineButton,
            this.toolStripSeparator6,
            this.NameLayout,
            this.NameTextBox,
            this.FiguresLayout,
            this.ListOfNamesComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(699, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RectangleButton
            // 
            this.RectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("RectangleButton.Image")));
            this.RectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RectangleButton.Name = "RectangleButton";
            this.RectangleButton.Size = new System.Drawing.Size(23, 22);
            this.RectangleButton.Text = "RectangleButton";
            this.RectangleButton.Click += new System.EventHandler(this.RectangleButton_Click);
            // 
            // ElipseButton
            // 
            this.ElipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ElipseButton.Image = ((System.Drawing.Image)(resources.GetObject("ElipseButton.Image")));
            this.ElipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ElipseButton.Name = "ElipseButton";
            this.ElipseButton.Size = new System.Drawing.Size(23, 22);
            this.ElipseButton.Text = "Elipse";
            this.ElipseButton.Click += new System.EventHandler(this.ElipseButton_Click);
            // 
            // LineButton
            // 
            this.LineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LineButton.Image = ((System.Drawing.Image)(resources.GetObject("LineButton.Image")));
            this.LineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineButton.Name = "LineButton";
            this.LineButton.Size = new System.Drawing.Size(23, 22);
            this.LineButton.Text = "LineButton";
            this.LineButton.Click += new System.EventHandler(this.LineButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // NameLayout
            // 
            this.NameLayout.Name = "NameLayout";
            this.NameLayout.Size = new System.Drawing.Size(42, 22);
            this.NameLayout.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // FiguresLayout
            // 
            this.FiguresLayout.Name = "FiguresLayout";
            this.FiguresLayout.Size = new System.Drawing.Size(48, 22);
            this.FiguresLayout.Text = "Figures:";
            // 
            // ListOfNamesComboBox
            // 
            this.ListOfNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ListOfNamesComboBox.Name = "ListOfNamesComboBox";
            this.ListOfNamesComboBox.Size = new System.Drawing.Size(121, 25);
            this.ListOfNamesComboBox.SelectedIndexChanged += new System.EventHandler(this.ListOfNamesComboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.WTextBox);
            this.panel1.Controls.Add(this.HTextBox);
            this.panel1.Controls.Add(this.YTextBox);
            this.panel1.Controls.Add(this.XTextBox);
            this.panel1.Controls.Add(this.W);
            this.panel1.Controls.Add(this.H);
            this.panel1.Controls.Add(this.Y);
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.RectF);
            this.panel1.Controls.Add(this.RotateButton);
            this.panel1.Controls.Add(this.Rotate);
            this.panel1.Controls.Add(this.RotateValues);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Thickness);
            this.panel1.Controls.Add(this.ThicknessNumericUpDown);
            this.panel1.Controls.Add(this.FillColorButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BorderdColorButton);
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 95);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // WTextBox
            // 
            this.WTextBox.Location = new System.Drawing.Point(445, 59);
            this.WTextBox.Name = "WTextBox";
            this.WTextBox.Size = new System.Drawing.Size(37, 20);
            this.WTextBox.TabIndex = 25;
            // 
            // HTextBox
            // 
            this.HTextBox.Location = new System.Drawing.Point(445, 33);
            this.HTextBox.Name = "HTextBox";
            this.HTextBox.Size = new System.Drawing.Size(37, 20);
            this.HTextBox.TabIndex = 24;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(381, 60);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(37, 20);
            this.YTextBox.TabIndex = 23;
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(381, 33);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(37, 20);
            this.XTextBox.TabIndex = 22;
            // 
            // W
            // 
            this.W.AutoSize = true;
            this.W.Location = new System.Drawing.Point(424, 61);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(18, 13);
            this.W.TabIndex = 21;
            this.W.Text = "W";
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Location = new System.Drawing.Point(424, 36);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(15, 13);
            this.H.TabIndex = 20;
            this.H.Text = "H";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Location = new System.Drawing.Point(361, 62);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(14, 13);
            this.Y.TabIndex = 19;
            this.Y.Text = "Y";
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Location = new System.Drawing.Point(361, 36);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(14, 13);
            this.X.TabIndex = 18;
            this.X.Text = "X";
            // 
            // RectF
            // 
            this.RectF.AutoSize = true;
            this.RectF.Location = new System.Drawing.Point(403, 12);
            this.RectF.Name = "RectF";
            this.RectF.Size = new System.Drawing.Size(36, 13);
            this.RectF.TabIndex = 17;
            this.RectF.Text = "RectF";
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(601, 63);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(64, 23);
            this.RotateButton.TabIndex = 16;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // Rotate
            // 
            this.Rotate.AutoSize = true;
            this.Rotate.Location = new System.Drawing.Point(542, 30);
            this.Rotate.Name = "Rotate";
            this.Rotate.Size = new System.Drawing.Size(39, 13);
            this.Rotate.TabIndex = 14;
            this.Rotate.Text = "Rotate";
            // 
            // RotateValues
            // 
            this.RotateValues.Location = new System.Drawing.Point(601, 30);
            this.RotateValues.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.RotateValues.Name = "RotateValues";
            this.RotateValues.Size = new System.Drawing.Size(73, 20);
            this.RotateValues.TabIndex = 15;
            this.RotateValues.ValueChanged += new System.EventHandler(this.RotateValues_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Matrix";
            // 
            // Thickness
            // 
            this.Thickness.AutoSize = true;
            this.Thickness.Location = new System.Drawing.Point(149, 29);
            this.Thickness.Name = "Thickness";
            this.Thickness.Size = new System.Drawing.Size(56, 13);
            this.Thickness.TabIndex = 5;
            this.Thickness.Text = "Thickness";
            // 
            // ThicknessNumericUpDown
            // 
            this.ThicknessNumericUpDown.Location = new System.Drawing.Point(152, 45);
            this.ThicknessNumericUpDown.Name = "ThicknessNumericUpDown";
            this.ThicknessNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.ThicknessNumericUpDown.TabIndex = 4;
            this.ThicknessNumericUpDown.ValueChanged += new System.EventHandler(this.ThicknessNumericUpDown_ValueChanged);
            // 
            // FillColorButton
            // 
            this.FillColorButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FillColorButton.Location = new System.Drawing.Point(89, 49);
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.Size = new System.Drawing.Size(30, 30);
            this.FillColorButton.TabIndex = 3;
            this.FillColorButton.UseVisualStyleBackColor = false;
            this.FillColorButton.Click += new System.EventHandler(this.FillColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fill Color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borderd Color";
            // 
            // BorderdColorButton
            // 
            this.BorderdColorButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderdColorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderdColorButton.Location = new System.Drawing.Point(89, 12);
            this.BorderdColorButton.Name = "BorderdColorButton";
            this.BorderdColorButton.Size = new System.Drawing.Size(30, 30);
            this.BorderdColorButton.TabIndex = 0;
            this.BorderdColorButton.UseVisualStyleBackColor = false;
            this.BorderdColorButton.Click += new System.EventHandler(this.BorderdColorButton_Click);
            // 
            // DrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DrawForm";
            this.Text = "Draw";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotateValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThicknessNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edithToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutCtrlXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteCtrlVToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem selectAllCtrlAToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RectangleButton;
        private System.Windows.Forms.ToolStripButton ElipseButton;
        private System.Windows.Forms.ToolStripButton LineButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BorderdColorButton;
        private System.Windows.Forms.ColorDialog BorderColorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FillColorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog FillColorDialog;
        private System.Windows.Forms.Label Thickness;
        private System.Windows.Forms.NumericUpDown ThicknessNumericUpDown;
        private System.Windows.Forms.ToolStripMenuItem Group;
        private System.Windows.Forms.ToolStripMenuItem ungroupToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Rotate;
        private System.Windows.Forms.NumericUpDown RotateValues;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.TextBox WTextBox;
        private System.Windows.Forms.TextBox HTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.Label W;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label RectF;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel NameLayout;
        private System.Windows.Forms.ToolStripTextBox NameTextBox;
        private System.Windows.Forms.ToolStripLabel FiguresLayout;
        private System.Windows.Forms.ToolStripComboBox ListOfNamesComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

