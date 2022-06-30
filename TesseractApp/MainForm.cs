using Graphics;
using Graphics.Primitives;
using Graphics.Utils;
using System;
using System.Drawing;
using System.Numerics;
using System.Windows.Forms;

namespace TesseractApp
{
    public partial class MainForm : Form
    {
        private Graphics3D _graphics3D;
        private Tesseract _tesseract;

        public MainForm()
        {
            InitializeComponent();

            _graphics3D = new Graphics3D(canvas);
            _graphics3D.Paint += graphics3D_Paint;

            _tesseract = new Tesseract(1);
            _tesseract.Transform.Origin = -Vector3.One * _tesseract.EdgeLength / 2.0f;
        }

        private void graphics3D_Paint(object sender, PaintEventArgs e)
        {
            _tesseract.Transform.Scaling = Vector3.One * canvas.Height / 2.0f * (1.0f + size.Value / (float)size.Maximum);

            _graphics3D.Clear(Color.White);

            _graphics3D.PushTransform();
            _tesseract.Draw(_graphics3D);
            _graphics3D.PopTransform();
        }

        private void outlineColor_Scroll(object sender, EventArgs e)
        {
            _tesseract.OutlineColor = Color.FromArgb(outlineRedValue.Value, outlineGreenValue.Value, outlineBlueValue.Value);

            _graphics3D.Invalidate();
        }

        private void fillColor_Scroll(object sender, EventArgs e)
        {
            _tesseract.FillColor = Color.FromArgb(fillRedValue.Value, fillGreenValue.Value, fillBlueValue.Value);

            _graphics3D.Invalidate();
        }

        private void verticesColor_Scroll(object sender, EventArgs e)
        {
            _tesseract.VerticesColor = Color.FromArgb(verticesRedValue.Value, verticesGreenValue.Value, verticesBlueValue.Value);

            _graphics3D.Invalidate();
        }

        private void rotation_Scroll(object sender, EventArgs e)
        {
            float x = Converter.DegToRad(rotationX.Value);
            float y = Converter.DegToRad(rotationY.Value);
            float z = Converter.DegToRad(rotationZ.Value);

            _tesseract.Transform.Rotation = Quaternion.CreateFromAxisAngle(Vector3.UnitX, x);
            _tesseract.Transform.Rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitY, y);
            _tesseract.Transform.Rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitZ, z);

            _graphics3D.Invalidate();
        }

        private void size_Scroll(object sender, EventArgs e)
        {
            _graphics3D.Invalidate();
        }

        private void outlinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tesseract.HasOutline = outlinesCheckBox.Checked;
            _graphics3D.Invalidate();
        }

        private void verticesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tesseract.HasVertices = verticesCheckBox.Checked;
            _graphics3D.Invalidate();
        }

        private void fillCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tesseract.InnerCube.HasFill = fillCheckBox.Checked;
            _graphics3D.Invalidate();
        }

        private void resetRotationButton_Click(object sender, EventArgs e)
        {
            _tesseract.Transform.Rotation = Quaternion.Identity;

            rotationX.Value = 0;
            rotationY.Value = 0;
            rotationZ.Value = 0;

            _graphics3D.Invalidate();
        }

        private void resetOuterColor_Click(object sender, EventArgs e)
        {
            _tesseract.OutlineColor = Color.Black;

            outlineRedValue.Value = 0;
            outlineGreenValue.Value = 0;
            outlineBlueValue.Value = 0;

            _graphics3D.Invalidate();
        }

        private void resetFillColor_Click(object sender, EventArgs e)
        {
            _tesseract.FillColor = Color.Black;

            fillRedValue.Value = 0;
            fillGreenValue.Value = 0;
            fillBlueValue.Value = 0;

            _graphics3D.Invalidate();
        }

        private void resetSize_Click(object sender, EventArgs e)
        {
            size.Value = 0;
            _tesseract.Transform.Scaling = Vector3.One;

            _graphics3D.Invalidate();
        }

        private void resetOptions_Click(object sender, EventArgs e)
        {
            verticesCheckBox.Checked = true;
            outlinesCheckBox.Checked = true;
            fillCheckBox.Checked = true;
        }

        private void resetVerticesColor_Click(object sender, EventArgs e)
        {
            _tesseract.VerticesColor = Color.Black;

            verticesRedValue.Value = 0;
            verticesGreenValue.Value = 0;
            verticesBlueValue.Value = 0;

            _graphics3D.Invalidate();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            _graphics3D.Invalidate();
        }
    }
}
