using Drawing3D;
using Graphics;
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

            _tesseract = new Tesseract(size.Value);
            _tesseract.Transform.Origin = -Vector3.One * _tesseract.EdgeLength / 2.0f;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            
            _graphics3D.Clear(Color.White);

            _graphics3D.PushTransform();
            _tesseract.Draw(_graphics3D);
            _graphics3D.PopTransform();
        }

        private void color_Scroll(object sender, EventArgs e)
        {
            _tesseract.Pen.Color = Color.FromArgb(redValue.Value, greenValue.Value, blueValue.Value);

            Invalidate();
        }

        private void rotation_Scroll(object sender, EventArgs e)
        {
            float x = Converter.DegToRad(rotationX.Value);
            float y = Converter.DegToRad(rotationY.Value);
            float z = Converter.DegToRad(rotationZ.Value);

            _tesseract.Transform.Rotation = Quaternion.CreateFromAxisAngle(Vector3.UnitX, x);
            _tesseract.Transform.Rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitY, y);
            _tesseract.Transform.Rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitZ, z);

            Invalidate();
        }

        private void resetRotationButton_Click(object sender, EventArgs e)
        {
            _tesseract.Transform.Rotation = Quaternion.Identity;

            rotationX.Value = 0;
            rotationY.Value = 0;
            rotationZ.Value = 0;

            Invalidate();
        }

        private void resetColor_Click(object sender, EventArgs e)
        {
            _tesseract.Pen.Color = Color.Black;

            redValue.Value = 0;
            greenValue.Value = 0;
            blueValue.Value = 0;

            Invalidate();
        }

        private void resetSize_Click(object sender, EventArgs e)
        {
            size.Value = size.Maximum / 2;
            _tesseract.Transform.Scaling = Vector3.One;

            Invalidate();
        }

        private void size_Scroll(object sender, EventArgs e)
        {
            _tesseract.Transform.Scaling = Vector3.One * size.Value / _tesseract.EdgeLength;

            Invalidate();
        }
    }
}
