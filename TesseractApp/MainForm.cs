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

        private System.Timers.Timer _timer;

        public MainForm()
        {
            InitializeComponent();

            _timer = new System.Timers.Timer(10);

            _graphics3D = new Graphics3D(canvas);
            _graphics3D.Renderer.SetZBuffer(true);
            _graphics3D.Renderer.SetDoubleBuffered(true);
            _graphics3D.Renderer.SetBackgroundColor(Color.White);

            _graphics3D.Paint += Graphics3D_Paint;
            _graphics3D.Canvas.MouseWheel += Graphics3D_Control_MouseWheel;
            _graphics3D.Canvas.MouseDown += Graphics3D_Control_MouseDown;
            _graphics3D.Canvas.MouseMove += Graphics3D_Control_MouseMove;

            KeyUp += MainForm_KeyUp;
            KeyDown += MainForm_KeyDown;
            _timer.Elapsed += Timer_Tick; 

            _tesseract = new Tesseract(1);
            _tesseract.Transform.Origin = -Vector3.One * _tesseract.EdgeLength / 2.0f;

            ApplyColor();
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
            int screenSize;

            if (canvas.Width < canvas.Height)
            {
                screenSize = canvas.Width;
            }
            else
            {
                screenSize = canvas.Height;
            }

            _tesseract.Transform.Scaling = Vector3.One * screenSize / 2.0f * (1.0f + shapeSize.Value / (float)shapeSize.Maximum);

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

            _timer.Stop();

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

            ApplyRotation(rotationX.Value, rotationY.Value, rotationZ.Value);
        }

        private void Color_Scroll(object sender, EventArgs e)
        {
            ApplyColor();
        }

        private void Rotation_ValueChanged(object sender, EventArgs e)
        {
            ApplyRotation(rotationX.Value, rotationY.Value, rotationZ.Value);
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            float degPerSec = 0;
            float x = 0;
            float y = 0;
            float z = 0;

            rotationSpeed.Invoke((MethodInvoker)delegate
            {
                degPerSec = rotationSpeed.Value;
            });

            rotationX.Invoke((MethodInvoker)delegate {
                if (autoRotationX.Checked)
                {
                    x = (360 + (rotationX.Value + degPerSec) % 360) % 360;
                    rotationX.Value = (int)x;
                }
                else
                {
                    x = rotationX.Value;
                }
            });

            rotationY.Invoke((MethodInvoker)delegate {
                if (autoRotationY.Checked)
                {
                    y = (360 + (rotationY.Value + degPerSec) % 360) % 360;
                    rotationY.Value = (int)y;
                }
                else
                {
                    y = rotationY.Value;
                }
            });

            rotationZ.Invoke((MethodInvoker)delegate {
                if (autoRotationZ.Checked)
                {
                    z = (360 + (rotationZ.Value + degPerSec) % 360) % 360;
                    rotationZ.Value = (int)z;
                }
                else
                {
                    z = rotationZ.Value;
                }
            });

            ApplyRotation(x, y, z);
        }

        private void ApplyRotation(float xDeg, float yDeg, float zDeg)
        {
            float xRad = Converter.DegToRad(xDeg);
            float yRad = Converter.DegToRad(yDeg);
            float zRad = Converter.DegToRad(zDeg);

            if (eulerRotation.Checked)
            {
                _tesseract.Transform.Rotation = Quaternion.CreateFromAxisAngle(Vector3.UnitX, xRad);
                _tesseract.Transform.Rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitY, yRad);
                _tesseract.Transform.Rotation *= Quaternion.CreateFromAxisAngle(Vector3.UnitZ, zRad);
            }
            else
            {
                _tesseract.Transform.Rotation = Quaternion.CreateFromYawPitchRoll(yRad, xRad, zRad);
            }
        }

        private void ApplyColor()
        {
            _tesseract.OutlineColor = Color.FromArgb(alphaOutline.Value, redOutline.Value, greenOutline.Value, blueOutline.Value);
            _tesseract.FillColor = Color.FromArgb(alphaFill.Value, redFill.Value, greenFill.Value, blueFill.Value);
            _tesseract.VerticesColor = Color.FromArgb(alphaVertices.Value, redVertices.Value, greenVertices.Value, blueVertices.Value);
        }

        private void Rotation_Scroll(object sender, EventArgs e)
        {
            ApplyRotation(rotationX.Value, rotationY.Value, rotationZ.Value);
        }
        
        private void AutoRotationButton_Click(object sender, EventArgs e)
        {
            _timer.Start();
        }

        private void PauseAutoRotationButton_Click(object sender, EventArgs e)
        {
            _timer.Stop();
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
