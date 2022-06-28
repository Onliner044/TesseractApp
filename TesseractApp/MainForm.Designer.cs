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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.resetColor = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.blueValue = new System.Windows.Forms.TrackBar();
            this.greenValue = new System.Windows.Forms.TrackBar();
            this.redValue = new System.Windows.Forms.TrackBar();
            this.rotationGroupBox = new System.Windows.Forms.GroupBox();
            this.resetRotationButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rotationZ = new System.Windows.Forms.TrackBar();
            this.rotationY = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rotationX = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resetSize = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.TrackBar();
            this.canvas = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.colorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).BeginInit();
            this.rotationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.resetColor);
            this.colorGroupBox.Controls.Add(this.pictureBox3);
            this.colorGroupBox.Controls.Add(this.pictureBox2);
            this.colorGroupBox.Controls.Add(this.pictureBox1);
            this.colorGroupBox.Controls.Add(this.blueValue);
            this.colorGroupBox.Controls.Add(this.greenValue);
            this.colorGroupBox.Controls.Add(this.redValue);
            this.colorGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.colorGroupBox.Location = new System.Drawing.Point(0, 175);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(279, 175);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Color";
            // 
            // resetColor
            // 
            this.resetColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetColor.Location = new System.Drawing.Point(95, 146);
            this.resetColor.MaximumSize = new System.Drawing.Size(200, 23);
            this.resetColor.MinimumSize = new System.Drawing.Size(75, 23);
            this.resetColor.Name = "resetColor";
            this.resetColor.Size = new System.Drawing.Size(75, 23);
            this.resetColor.TabIndex = 2;
            this.resetColor.Text = "Reset";
            this.resetColor.UseVisualStyleBackColor = true;
            this.resetColor.Click += new System.EventHandler(this.resetColor_Click);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(6, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            // blueValue
            // 
            this.blueValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueValue.Location = new System.Drawing.Point(27, 108);
            this.blueValue.Maximum = 255;
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(239, 45);
            this.blueValue.TabIndex = 0;
            this.blueValue.TickFrequency = 5;
            this.blueValue.Scroll += new System.EventHandler(this.color_Scroll);
            // 
            // greenValue
            // 
            this.greenValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.greenValue.Location = new System.Drawing.Point(27, 63);
            this.greenValue.Maximum = 255;
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(239, 45);
            this.greenValue.TabIndex = 0;
            this.greenValue.TickFrequency = 5;
            this.greenValue.Scroll += new System.EventHandler(this.color_Scroll);
            // 
            // redValue
            // 
            this.redValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.redValue.Location = new System.Drawing.Point(27, 19);
            this.redValue.Maximum = 255;
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(239, 45);
            this.redValue.TabIndex = 0;
            this.redValue.TickFrequency = 5;
            this.redValue.Scroll += new System.EventHandler(this.color_Scroll);
            // 
            // rotationGroupBox
            // 
            this.rotationGroupBox.Controls.Add(this.resetRotationButton);
            this.rotationGroupBox.Controls.Add(this.label3);
            this.rotationGroupBox.Controls.Add(this.label2);
            this.rotationGroupBox.Controls.Add(this.rotationZ);
            this.rotationGroupBox.Controls.Add(this.rotationY);
            this.rotationGroupBox.Controls.Add(this.label1);
            this.rotationGroupBox.Controls.Add(this.rotationX);
            this.rotationGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.rotationGroupBox.Location = new System.Drawing.Point(0, 0);
            this.rotationGroupBox.Name = "rotationGroupBox";
            this.rotationGroupBox.Size = new System.Drawing.Size(279, 175);
            this.rotationGroupBox.TabIndex = 0;
            this.rotationGroupBox.TabStop = false;
            this.rotationGroupBox.Text = "Rotation";
            // 
            // resetRotationButton
            // 
            this.resetRotationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetRotationButton.Location = new System.Drawing.Point(95, 146);
            this.resetRotationButton.Name = "resetRotationButton";
            this.resetRotationButton.Size = new System.Drawing.Size(75, 23);
            this.resetRotationButton.TabIndex = 2;
            this.resetRotationButton.Text = "Reset";
            this.resetRotationButton.UseVisualStyleBackColor = true;
            this.resetRotationButton.Click += new System.EventHandler(this.resetRotationButton_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "y";
            // 
            // rotationZ
            // 
            this.rotationZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationZ.Location = new System.Drawing.Point(30, 108);
            this.rotationZ.Maximum = 360;
            this.rotationZ.Name = "rotationZ";
            this.rotationZ.Size = new System.Drawing.Size(236, 45);
            this.rotationZ.TabIndex = 0;
            this.rotationZ.TickFrequency = 5;
            this.rotationZ.Scroll += new System.EventHandler(this.rotation_Scroll);
            // 
            // rotationY
            // 
            this.rotationY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationY.Location = new System.Drawing.Point(30, 63);
            this.rotationY.Maximum = 360;
            this.rotationY.Name = "rotationY";
            this.rotationY.Size = new System.Drawing.Size(236, 45);
            this.rotationY.TabIndex = 0;
            this.rotationY.TickFrequency = 5;
            this.rotationY.Scroll += new System.EventHandler(this.rotation_Scroll);
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
            // rotationX
            // 
            this.rotationX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rotationX.Location = new System.Drawing.Point(30, 19);
            this.rotationX.Maximum = 360;
            this.rotationX.Name = "rotationX";
            this.rotationX.Size = new System.Drawing.Size(236, 45);
            this.rotationX.TabIndex = 0;
            this.rotationX.TickFrequency = 5;
            this.rotationX.Scroll += new System.EventHandler(this.rotation_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resetSize);
            this.groupBox1.Controls.Add(this.size);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 350);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // resetSize
            // 
            this.resetSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.resetSize.Location = new System.Drawing.Point(95, 56);
            this.resetSize.MaximumSize = new System.Drawing.Size(200, 23);
            this.resetSize.MinimumSize = new System.Drawing.Size(75, 23);
            this.resetSize.Name = "resetSize";
            this.resetSize.Size = new System.Drawing.Size(75, 23);
            this.resetSize.TabIndex = 2;
            this.resetSize.Text = "Reset";
            this.resetSize.UseVisualStyleBackColor = true;
            this.resetSize.Click += new System.EventHandler(this.resetSize_Click);
            // 
            // size
            // 
            this.size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.size.Location = new System.Drawing.Point(17, 19);
            this.size.Maximum = 100;
            this.size.Minimum = -100;
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(234, 45);
            this.size.TabIndex = 0;
            this.size.TickFrequency = 5;
            this.size.Scroll += new System.EventHandler(this.size_Scroll);
            // 
            // canvas
            // 
            this.canvas.AutoScroll = true;
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(0, 0);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(797, 600);
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.colorGroupBox);
            this.splitContainer1.Panel1.Controls.Add(this.rotationGroupBox);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.canvas);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 400;
            this.splitContainer1.Size = new System.Drawing.Size(1080, 600);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 600);
            this.Controls.Add(this.splitContainer1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Tesseract";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.colorGroupBox.ResumeLayout(false);
            this.colorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).EndInit();
            this.rotationGroupBox.ResumeLayout(false);
            this.rotationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotationZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.Button resetColor;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar blueValue;
        private System.Windows.Forms.TrackBar greenValue;
        private System.Windows.Forms.TrackBar redValue;
        private System.Windows.Forms.GroupBox rotationGroupBox;
        private System.Windows.Forms.Button resetRotationButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar rotationZ;
        private System.Windows.Forms.TrackBar rotationY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar rotationX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button resetSize;
        private System.Windows.Forms.TrackBar size;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

