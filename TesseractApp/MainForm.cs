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

        private Point _lastMouseClickLocation;
        private Point _mouseLocation;
        private bool _isControlKeyDown;

        public MainForm()
        {
            InitializeComponent();

            _graphics3D = new Graphics3D(canvas);
            _graphics3D.Renderer.SetZBuffer(true);
            _graphics3D.Renderer.SetDoubleBuffered(true);
            _graphics3D.Renderer.SetBackgroundColor(Color.White);

            _graphics3D.Paint += Graphics3D_Paint;
            _graphics3D.Canvas.MouseWheel += Graphics3D_Control_MouseWheel;
            _graphics3D.Canvas.MouseDown += Graphics3D_Control_MouseDown;
            _graphics3D.Canvas.MouseMove += Graphics3D_Control_MouseMove;

            KeyDown += MainForm_KeyDown;
            KeyUp += MainForm_KeyUp;

            _tesseract = new Tesseract(1);
            _tesseract.Transform.Origin = -Vector3.One * _tesseract.EdgeLength / 2.0f;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                _isControlKeyDown = false;

                _lastMouseClickLocation = _mouseLocation;
                _lastMouseClickLocation.X -= rotationY.Value;
                _lastMouseClickLocation.Y -= rotationX.Value;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                _isControlKeyDown = true;

                _lastMouseClickLocation = _mouseLocation;
                _lastMouseClickLocation.X += rotationZ.Value;
                _lastMouseClickLocation.Y -= rotationX.Value;
            }
        }

        private void Graphics3D_Paint(object sender, PaintEventArgs e)
        {
            _tesseract.Transform.Scaling = Vector3.One * canvas.Height / 2.0f * (1.0f + shapeSize.Value / (float)shapeSize.Maximum);

            _graphics3D.Clear();

            _graphics3D.PushTransform();
            _tesseract.Draw(_graphics3D);
            _graphics3D.PopTransform();
        }

        private void Graphics3D_Control_MouseWheel(object sender, MouseEventArgs e)
        {
            int deltaScroll = Math.Abs(e.Delta) / e.Delta * shapeSize.TickFrequency;

            if (shapeSize.Value + deltaScroll > shapeSize.Maximum)
            {
                deltaScroll = shapeSize.Maximum - shapeSize.Value;
            }
            else if (shapeSize.Value + deltaScroll < shapeSize.Minimum)
            {
                deltaScroll = shapeSize.Minimum - shapeSize.Value;
            }

            shapeSize.Value += deltaScroll;
        }

        private void Graphics3D_Control_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _lastMouseClickLocation = e.Location;
                _lastMouseClickLocation.Y -= rotationX.Value;

                if (_isControlKeyDown)
                {
                    _lastMouseClickLocation.X += rotationZ.Value;
                }
                else
                {
                    _lastMouseClickLocation.X -= rotationY.Value;
                }
            }
        }

        private void Graphics3D_Control_MouseMove(object sender, MouseEventArgs e)
        {
            _mouseLocation = e.Location;

            if (e.Button != MouseButtons.Left)
            {
                return;
            }

            if (_isControlKeyDown)
            {
                rotationX.Value = (360 + (e.Y - _lastMouseClickLocation.Y) % 360) % 360;
                rotationZ.Value = (360 + (_lastMouseClickLocation.X - e.X) % 360) % 360;
            }
            else
            {
                rotationX.Value = (360 + (e.Y - _lastMouseClickLocation.Y) % 360) % 360;
                rotationY.Value = (360 + (e.X - _lastMouseClickLocation.X) % 360) % 360;
            }
        }

        private void OutlineColor_Scroll(object sender, EventArgs e)
        {
            _tesseract.OutlineColor = Color.FromArgb(alphaOutline.Value, redOutline.Value, greenOutline.Value, blueOutline.Value);
        }

        private void FillColor_Scroll(object sender, EventArgs e)
        {
            _tesseract.FillColor = Color.FromArgb(alphaFill.Value, redFill.Value, greenFill.Value, blueFill.Value);
        }

        private void VerticesColor_Scroll(object sender, EventArgs e)
        {
            _tesseract.VerticesColor = Color.FromArgb(alphaVertices.Value, redVertices.Value, greenVertices.Value, blueVertices.Value);
        }

        private void Rotation_ValueChanged(object sender, EventArgs e)
        {
            float x = Converter.DegToRad(rotationX.Value);
            float y = Converter.DegToRad(rotationY.Value);
            float z = Converter.DegToRad(rotationZ.Value);

            if (eulerRotation.Checked)
            {
                _tesseract.Transform.Rotation = Quaternion.CreateFromAxisAngle(Vector3.UnitX, x);
                _tesseract.Transform.Rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitY, y);
                _tesseract.Transform.Rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitZ, z);
            }
            else
            {
                _tesseract.Transform.Rotation = Quaternion.CreateFromYawPitchRoll(y, x, z);
            }
        }

        private void OutlinesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tesseract.HasOutline = outlinesCheckBox.Checked;
        }

        private void VerticesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tesseract.HasVertices = verticesCheckBox.Checked;
        }

        private void FillCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _tesseract.InnerCube.HasFill = fillCheckBox.Checked;
        }

        private void ResetOutlineColor_Click(object sender, EventArgs e)
        {
            _tesseract.OutlineColor = Color.Black;

            redOutline.Value = 0;
            greenOutline.Value = 0;
            blueOutline.Value = 0;
            alphaOutline.Value = 255;
        }

        private void ResetFillColor_Click(object sender, EventArgs e)
        {
            _tesseract.FillColor = Color.Black;

            redFill.Value = 0;
            greenFill.Value = 0;
            blueFill.Value = 0;
            alphaFill.Value = 255;
        }

        private void ResetVerticesColor_Click(object sender, EventArgs e)
        {
            _tesseract.VerticesColor = Color.Black;

            redVertices.Value = 0;
            greenVertices.Value = 0;
            blueVertices.Value = 0;
            alphaVertices.Value = 255;
        }

        private void ResetRotationButton_Click(object sender, EventArgs e)
        {
            _tesseract.Transform.Rotation = Quaternion.Identity;

            rotationX.Value = 0;
            rotationY.Value = 0;
            rotationZ.Value = 0;
        }

        private void ResetSize_Click(object sender, EventArgs e)
        {
            shapeSize.Value = 0;
            _tesseract.Transform.Scaling = Vector3.One;
        }

        private void ResetOptions_Click(object sender, EventArgs e)
        {
            verticesCheckBox.Checked = true;
            outlinesCheckBox.Checked = true;
            fillCheckBox.Checked = true;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            _graphics3D.Resize();
        }

        private void SplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            _graphics3D.Resize();
        }
    }
}
