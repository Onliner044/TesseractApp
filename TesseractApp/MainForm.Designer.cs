namespace TesseractApp {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.canvas = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fillColorGroupBox = new System.Windows.Forms.GroupBox();
            this.fillRedValue = new System.Windows.Forms.TrackBar();
            this.fillGreenValue = new System.Windows.Forms.TrackBar();
            this.fillBlueValue = new System.Windows.Forms.TrackBar();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.resetFillColor = new System.Windows.Forms.Button();
            this.outlineColorGroupBox = new System.Windows.Forms.GroupBox();
            this.outlineRedValue = new System.Windows.Forms.TrackBar();
            this.outlineGreenValue = new System.Windows.Forms.TrackBar();
            this.outlineBlueValue = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.resetOutlineColor = new System.Windows.Forms.Button();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.outlinesCheckBox = new System.Windows.Forms.CheckBox();
            this.verticesCheckBox = new System.Windows.Forms.CheckBox();
            this.fillCheckBox = new System.Windows.Forms.CheckBox();
            this.verticesColorGroupBox = new System.Windows.Forms.GroupBox();
            this.verticesRedValue = new System.Windows.Forms.TrackBar();
            this.verticesGreenValue = new System.Windows.Forms.TrackBar();
            this.verticesBlueValue = new System.Windows.Forms.TrackBar();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.resetVerticesColor = new System.Windows.Forms.Button();
            this.rotationGroupBox = new System.Windows.Forms.GroupBox();
            this.rotationX = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rotationY = new System.Windows.Forms.TrackBar();
            this.rotationZ = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetRotation = new System.Windows.Forms.Button();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.size = new System.Windows.Forms.TrackBar();
            this.resetSize = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resetOptions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.fillColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fillRedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillGreenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillBlueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.outlineColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outlineRedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlineGreenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlineBlueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.optionsGroupBox.SuspendLayout();
            this.verticesColorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticesRedValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticesGreenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticesBlueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.rotationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationZ)).BeginInit();
            this.sizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.AutoScroll = true;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(811, 600);
            this.canvas.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 350;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.canvas);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(1165, 600);
            this.splitContainer1.SplitterDistance = 350;
            this.splitContainer1.TabIndex = 2;
            // 
            // fillColorGroupBox
            // 
            this.fillColorGroupBox.Controls.Add(this.resetFillColor);
            this.fillColorGroupBox.Controls.Add(this.pictureBox4);
            this.fillColorGroupBox.Controls.Add(this.pictureBox5);
            this.fillColorGroupBox.Controls.Add(this.pictureBox6);
            this.fillColorGroupBox.Controls.Add(this.fillBlueValue);
            this.fillColorGroupBox.Controls.Add(this.fillGreenValue);
            this.fillColorGroupBox.Controls.Add(this.fillRedValue);
            this.fillColorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillColorGroupBox.Location = new System.Drawing.Point(3, 203);
            this.fillColorGroupBox.Name = "fillColorGroupBox";
            this.fillColorGroupBox.Size = new System.Drawing.Size(169, 194);
            this.fillColorGroupBox.TabIndex = 0;
            this.fillColorGroupBox.TabStop = false;
            this.fillColorGroupBox.Text = "Fill color";
            // 
            // fillRedValue
            // 
            this.fillRedValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillRedValue.Location = new System.Drawing.Point(27, 19);
            this.fillRedValue.Maximum = 255;
            this.fillRedValue.Name = "fillRedValue";
            this.fillRedValue.Size = new System.Drawing.Size(129, 45);
            this.fillRedValue.TabIndex = 0;
            this.fillRedValue.TickFrequency = 5;
            this.fillRedValue.Scroll += new System.EventHandler(this.fillColor_Scroll);
            // 
            // fillGreenValue
            // 
            this.fillGreenValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillGreenValue.Location = new System.Drawing.Point(27, 63);
            this.fillGreenValue.Maximum = 255;
            this.fillGreenValue.Name = "fillGreenValue";
            this.fillGreenValue.Size = new System.Drawing.Size(129, 45);
            this.fillGreenValue.TabIndex = 0;
            this.fillGreenValue.TickFrequency = 5;
            this.fillGreenValue.Scroll += new System.EventHandler(this.fillColor_Scroll);
            // 
            // fillBlueValue
            // 
            this.fillBlueValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fillBlueValue.Location = new System.Drawing.Point(27, 108);
            this.fillBlueValue.Maximum = 255;
            this.fillBlueValue.Name = "fillBlueValue";
            this.fillBlueValue.Size = new System.Drawing.Size(129, 45);
            this.fillBlueValue.TabIndex = 0;
            this.fillBlueValue.TickFrequency = 5;
            this.fillBlueValue.Scroll += new System.EventHandler(this.fillColor_Scroll);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Red;
            this.pictureBox6.Location = new System.Drawing.Point(6, 24);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(15, 15);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Green;
            this.pictureBox5.Location = new System.Drawing.Point(6, 68);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Blue;
            this.pictureBox4.Location = new System.Drawing.Point(6, 114);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // resetFillColor
            // 
            this.resetFillColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetFillColor.Location = new System.Drawing.Point(49, 146);
            this.resetFillColor.MaximumSize = new System.Drawing.Size(200, 23);
            this.resetFillColor.MinimumSize = new System.Drawing.Size(75, 23);
            this.resetFillColor.Name = "resetFillColor";
            this.resetFillColor.Size = new System.Drawing.Size(75, 23);
            this.resetFillColor.TabIndex = 2;
            this.resetFillColor.Text = "Reset";
            this.resetFillColor.UseVisualStyleBackColor = true;
            this.resetFillColor.Click += new System.EventHandler(this.resetFillColor_Click);
            // 
            // outlineColorGroupBox
            // 
            this.outlineColorGroupBox.Controls.Add(this.resetOutlineColor);
            this.outlineColorGroupBox.Controls.Add(this.pictureBox3);
            this.outlineColorGroupBox.Controls.Add(this.pictureBox2);
            this.outlineColorGroupBox.Controls.Add(this.pictureBox1);
            this.outlineColorGroupBox.Controls.Add(this.outlineBlueValue);
            this.outlineColorGroupBox.Controls.Add(this.outlineGreenValue);
            this.outlineColorGroupBox.Controls.Add(this.outlineRedValue);
            this.outlineColorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outlineColorGroupBox.Location = new System.Drawing.Point(3, 3);
            this.outlineColorGroupBox.Name = "outlineColorGroupBox";
            this.outlineColorGroupBox.Size = new System.Drawing.Size(169, 194);
            this.outlineColorGroupBox.TabIndex = 0;
            this.outlineColorGroupBox.TabStop = false;
            this.outlineColorGroupBox.Text = "Outline color";
            // 
            // outlineRedValue
            // 
            this.outlineRedValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outlineRedValue.Location = new System.Drawing.Point(27, 19);
            this.outlineRedValue.Maximum = 255;
            this.outlineRedValue.Name = "outlineRedValue";
            this.outlineRedValue.Size = new System.Drawing.Size(129, 45);
            this.outlineRedValue.TabIndex = 0;
            this.outlineRedValue.TickFrequency = 5;
            this.outlineRedValue.Scroll += new System.EventHandler(this.outlineColor_Scroll);
            // 
            // outlineGreenValue
            // 
            this.outlineGreenValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outlineGreenValue.Location = new System.Drawing.Point(27, 63);
            this.outlineGreenValue.Maximum = 255;
            this.outlineGreenValue.Name = "outlineGreenValue";
            this.outlineGreenValue.Size = new System.Drawing.Size(129, 45);
            this.outlineGreenValue.TabIndex = 0;
            this.outlineGreenValue.TickFrequency = 5;
            this.outlineGreenValue.Scroll += new System.EventHandler(this.outlineColor_Scroll);
            // 
            // outlineBlueValue
            // 
            this.outlineBlueValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outlineBlueValue.Location = new System.Drawing.Point(27, 108);
            this.outlineBlueValue.Maximum = 255;
            this.outlineBlueValue.Name = "outlineBlueValue";
            this.outlineBlueValue.Size = new System.Drawing.Size(129, 45);
            this.outlineBlueValue.TabIndex = 0;
            this.outlineBlueValue.TickFrequency = 5;
            this.outlineBlueValue.Scroll += new System.EventHandler(this.outlineColor_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(6, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(6, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.Location = new System.Drawing.Point(6, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 15);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // resetOutlineColor
            // 
            this.resetOutlineColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetOutlineColor.Location = new System.Drawing.Point(40, 146);
            this.resetOutlineColor.MaximumSize = new System.Drawing.Size(200, 23);
            this.resetOutlineColor.MinimumSize = new System.Drawing.Size(75, 23);
            this.resetOutlineColor.Name = "resetOutlineColor";
            this.resetOutlineColor.Size = new System.Drawing.Size(75, 23);
            this.resetOutlineColor.TabIndex = 2;
            this.resetOutlineColor.Text = "Reset";
            this.resetOutlineColor.UseVisualStyleBackColor = true;
            this.resetOutlineColor.Click += new System.EventHandler(this.resetOuterColor_Click);
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.resetOptions);
            this.optionsGroupBox.Controls.Add(this.fillCheckBox);
            this.optionsGroupBox.Controls.Add(this.verticesCheckBox);
            this.optionsGroupBox.Controls.Add(this.outlinesCheckBox);
            this.optionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsGroupBox.Location = new System.Drawing.Point(178, 3);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(169, 194);
            this.optionsGroupBox.TabIndex = 1;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // outlinesCheckBox
            // 
            this.outlinesCheckBox.AutoSize = true;
            this.outlinesCheckBox.Checked = true;
            this.outlinesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.outlinesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outlinesCheckBox.Location = new System.Drawing.Point(47, 26);
            this.outlinesCheckBox.Name = "outlinesCheckBox";
            this.outlinesCheckBox.Size = new System.Drawing.Size(76, 21);
            this.outlinesCheckBox.TabIndex = 0;
            this.outlinesCheckBox.Text = "outlines";
            this.outlinesCheckBox.UseVisualStyleBackColor = true;
            this.outlinesCheckBox.CheckedChanged += new System.EventHandler(this.outlinesCheckBox_CheckedChanged);
            // 
            // verticesCheckBox
            // 
            this.verticesCheckBox.AutoSize = true;
            this.verticesCheckBox.Checked = true;
            this.verticesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.verticesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.verticesCheckBox.Location = new System.Drawing.Point(47, 70);
            this.verticesCheckBox.Name = "verticesCheckBox";
            this.verticesCheckBox.Size = new System.Drawing.Size(76, 21);
            this.verticesCheckBox.TabIndex = 0;
            this.verticesCheckBox.Text = "vertices";
            this.verticesCheckBox.UseVisualStyleBackColor = true;
            this.verticesCheckBox.CheckedChanged += new System.EventHandler(this.verticesCheckBox_CheckedChanged);
            // 
            // fillCheckBox
            // 
            this.fillCheckBox.AutoSize = true;
            this.fillCheckBox.Checked = true;
            this.fillCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fillCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillCheckBox.Location = new System.Drawing.Point(47, 116);
            this.fillCheckBox.Name = "fillCheckBox";
            this.fillCheckBox.Size = new System.Drawing.Size(40, 21);
            this.fillCheckBox.TabIndex = 0;
            this.fillCheckBox.Text = "fill";
            this.fillCheckBox.UseVisualStyleBackColor = true;
            this.fillCheckBox.CheckedChanged += new System.EventHandler(this.fillCheckBox_CheckedChanged);
            // 
            // verticesColorGroupBox
            // 
            this.verticesColorGroupBox.Controls.Add(this.resetVerticesColor);
            this.verticesColorGroupBox.Controls.Add(this.pictureBox7);
            this.verticesColorGroupBox.Controls.Add(this.pictureBox8);
            this.verticesColorGroupBox.Controls.Add(this.pictureBox9);
            this.verticesColorGroupBox.Controls.Add(this.verticesBlueValue);
            this.verticesColorGroupBox.Controls.Add(this.verticesGreenValue);
            this.verticesColorGroupBox.Controls.Add(this.verticesRedValue);
            this.verticesColorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticesColorGroupBox.Location = new System.Drawing.Point(3, 403);
            this.verticesColorGroupBox.Name = "verticesColorGroupBox";
            this.verticesColorGroupBox.Size = new System.Drawing.Size(169, 194);
            this.verticesColorGroupBox.TabIndex = 2;
            this.verticesColorGroupBox.TabStop = false;
            this.verticesColorGroupBox.Text = "Vertices color";
            // 
            // verticesRedValue
            // 
            this.verticesRedValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticesRedValue.Location = new System.Drawing.Point(27, 19);
            this.verticesRedValue.Maximum = 255;
            this.verticesRedValue.Name = "verticesRedValue";
            this.verticesRedValue.Size = new System.Drawing.Size(129, 45);
            this.verticesRedValue.TabIndex = 0;
            this.verticesRedValue.TickFrequency = 5;
            this.verticesRedValue.Scroll += new System.EventHandler(this.verticesColor_Scroll);
            // 
            // verticesGreenValue
            // 
            this.verticesGreenValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticesGreenValue.Location = new System.Drawing.Point(27, 63);
            this.verticesGreenValue.Maximum = 255;
            this.verticesGreenValue.Name = "verticesGreenValue";
            this.verticesGreenValue.Size = new System.Drawing.Size(129, 45);
            this.verticesGreenValue.TabIndex = 0;
            this.verticesGreenValue.TickFrequency = 5;
            this.verticesGreenValue.Scroll += new System.EventHandler(this.verticesColor_Scroll);
            // 
            // verticesBlueValue
            // 
            this.verticesBlueValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.verticesBlueValue.Location = new System.Drawing.Point(27, 108);
            this.verticesBlueValue.Maximum = 255;
            this.verticesBlueValue.Name = "verticesBlueValue";
            this.verticesBlueValue.Size = new System.Drawing.Size(129, 45);
            this.verticesBlueValue.TabIndex = 0;
            this.verticesBlueValue.TickFrequency = 5;
            this.verticesBlueValue.Scroll += new System.EventHandler(this.verticesColor_Scroll);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Red;
            this.pictureBox9.Location = new System.Drawing.Point(6, 24);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(15, 15);
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Green;
            this.pictureBox8.Location = new System.Drawing.Point(6, 68);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(15, 15);
            this.pictureBox8.TabIndex = 1;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Blue;
            this.pictureBox7.Location = new System.Drawing.Point(6, 114);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(15, 15);
            this.pictureBox7.TabIndex = 1;
            this.pictureBox7.TabStop = false;
            // 
            // resetVerticesColor
            // 
            this.resetVerticesColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetVerticesColor.Location = new System.Drawing.Point(49, 146);
            this.resetVerticesColor.MaximumSize = new System.Drawing.Size(200, 23);
            this.resetVerticesColor.MinimumSize = new System.Drawing.Size(75, 23);
            this.resetVerticesColor.Name = "resetVerticesColor";
            this.resetVerticesColor.Size = new System.Drawing.Size(75, 23);
            this.resetVerticesColor.TabIndex = 2;
            this.resetVerticesColor.Text = "Reset";
            this.resetVerticesColor.UseVisualStyleBackColor = true;
            this.resetVerticesColor.Click += new System.EventHandler(this.resetVerticesColor_Click);
            // 
            // rotationGroupBox
            // 
            this.rotationGroupBox.Controls.Add(this.resetRotation);
            this.rotationGroupBox.Controls.Add(this.label3);
            this.rotationGroupBox.Controls.Add(this.label2);
            this.rotationGroupBox.Controls.Add(this.rotationZ);
            this.rotationGroupBox.Controls.Add(this.rotationY);
            this.rotationGroupBox.Controls.Add(this.label1);
            this.rotationGroupBox.Controls.Add(this.rotationX);
            this.rotationGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationGroupBox.Location = new System.Drawing.Point(178, 203);
            this.rotationGroupBox.Name = "rotationGroupBox";
            this.rotationGroupBox.Size = new System.Drawing.Size(169, 194);
            this.rotationGroupBox.TabIndex = 0;
            this.rotationGroupBox.TabStop = false;
            this.rotationGroupBox.Text = "Rotation";
            // 
            // rotationX
            // 
            this.rotationX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationX.Location = new System.Drawing.Point(30, 19);
            this.rotationX.Maximum = 360;
            this.rotationX.Name = "rotationX";
            this.rotationX.Size = new System.Drawing.Size(126, 45);
            this.rotationX.TabIndex = 0;
            this.rotationX.TickFrequency = 5;
            this.rotationX.Scroll += new System.EventHandler(this.rotation_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // rotationY
            // 
            this.rotationY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationY.Location = new System.Drawing.Point(30, 63);
            this.rotationY.Maximum = 360;
            this.rotationY.Name = "rotationY";
            this.rotationY.Size = new System.Drawing.Size(126, 45);
            this.rotationY.TabIndex = 0;
            this.rotationY.TickFrequency = 5;
            this.rotationY.Scroll += new System.EventHandler(this.rotation_Scroll);
            // 
            // rotationZ
            // 
            this.rotationZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationZ.Location = new System.Drawing.Point(30, 108);
            this.rotationZ.Maximum = 360;
            this.rotationZ.Name = "rotationZ";
            this.rotationZ.Size = new System.Drawing.Size(126, 45);
            this.rotationZ.TabIndex = 0;
            this.rotationZ.TickFrequency = 5;
            this.rotationZ.Scroll += new System.EventHandler(this.rotation_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "z";
            // 
            // resetRotation
            // 
            this.resetRotation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetRotation.Location = new System.Drawing.Point(40, 145);
            this.resetRotation.MaximumSize = new System.Drawing.Size(200, 23);
            this.resetRotation.MinimumSize = new System.Drawing.Size(75, 23);
            this.resetRotation.Name = "resetRotation";
            this.resetRotation.Size = new System.Drawing.Size(75, 23);
            this.resetRotation.TabIndex = 2;
            this.resetRotation.Text = "Reset";
            this.resetRotation.UseVisualStyleBackColor = true;
            this.resetRotation.Click += new System.EventHandler(this.resetRotationButton_Click);
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.resetSize);
            this.sizeGroupBox.Controls.Add(this.size);
            this.sizeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizeGroupBox.Location = new System.Drawing.Point(178, 403);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(169, 194);
            this.sizeGroupBox.TabIndex = 0;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Size";
            // 
            // size
            // 
            this.size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.size.Location = new System.Drawing.Point(19, 63);
            this.size.Maximum = 100;
            this.size.Minimum = -100;
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(124, 45);
            this.size.TabIndex = 0;
            this.size.TickFrequency = 5;
            this.size.Scroll += new System.EventHandler(this.size_Scroll);
            // 
            // resetSize
            // 
            this.resetSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetSize.Location = new System.Drawing.Point(40, 146);
            this.resetSize.MaximumSize = new System.Drawing.Size(200, 23);
            this.resetSize.MinimumSize = new System.Drawing.Size(75, 23);
            this.resetSize.Name = "resetSize";
            this.resetSize.Size = new System.Drawing.Size(75, 23);
            this.resetSize.TabIndex = 2;
            this.resetSize.Text = "Reset";
            this.resetSize.UseVisualStyleBackColor = true;
            this.resetSize.Click += new System.EventHandler(this.resetSize_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.sizeGroupBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.rotationGroupBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.verticesColorGroupBox, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.optionsGroupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outlineColorGroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.fillColorGroupBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 600);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resetOptions
            // 
            this.resetOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetOptions.Location = new System.Drawing.Point(47, 143);
            this.resetOptions.MaximumSize = new System.Drawing.Size(200, 23);
            this.resetOptions.MinimumSize = new System.Drawing.Size(75, 23);
            this.resetOptions.Name = "resetOptions";
            this.resetOptions.Size = new System.Drawing.Size(75, 23);
            this.resetOptions.TabIndex = 2;
            this.resetOptions.Text = "Reset";
            this.resetOptions.UseVisualStyleBackColor = true;
            this.resetOptions.Click += new System.EventHandler(this.resetOptions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 600);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(800, 530);
            this.Name = "MainForm";
            this.Text = "Tesseract";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.fillColorGroupBox.ResumeLayout(false);
            this.fillColorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fillRedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillGreenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillBlueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.outlineColorGroupBox.ResumeLayout(false);
            this.outlineColorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outlineRedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlineGreenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlineBlueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.verticesColorGroupBox.ResumeLayout(false);
            this.verticesColorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticesRedValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticesGreenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticesBlueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.rotationGroupBox.ResumeLayout(false);
            this.rotationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationZ)).EndInit();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox sizeGroupBox;
        private System.Windows.Forms.Button resetSize;
        private System.Windows.Forms.TrackBar size;
        private System.Windows.Forms.GroupBox rotationGroupBox;
        private System.Windows.Forms.Button resetRotation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar rotationZ;
        private System.Windows.Forms.TrackBar rotationY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar rotationX;
        private System.Windows.Forms.GroupBox verticesColorGroupBox;
        private System.Windows.Forms.Button resetVerticesColor;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TrackBar verticesBlueValue;
        private System.Windows.Forms.TrackBar verticesGreenValue;
        private System.Windows.Forms.TrackBar verticesRedValue;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox fillCheckBox;
        private System.Windows.Forms.CheckBox verticesCheckBox;
        private System.Windows.Forms.CheckBox outlinesCheckBox;
        private System.Windows.Forms.GroupBox outlineColorGroupBox;
        private System.Windows.Forms.Button resetOutlineColor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar outlineBlueValue;
        private System.Windows.Forms.TrackBar outlineGreenValue;
        private System.Windows.Forms.TrackBar outlineRedValue;
        private System.Windows.Forms.GroupBox fillColorGroupBox;
        private System.Windows.Forms.Button resetFillColor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TrackBar fillBlueValue;
        private System.Windows.Forms.TrackBar fillGreenValue;
        private System.Windows.Forms.TrackBar fillRedValue;
        private System.Windows.Forms.Button resetOptions;
    }
}

