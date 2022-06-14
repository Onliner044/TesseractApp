using Drawing3D;
using Drawing3D.Contracts;
using Drawing3D.Primitives;
using Drawing3D.Utils;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Windows.Forms;

namespace TesseractApp
{
    public partial class MainForm : Form
    {
        Canvas canvas;
        Graphics3D graphics3D;

        Tesseract tesseract;

        public MainForm()
        {
            InitializeComponent();

            graphics3D = new Graphics3D(pictureBox.CreateGraphics());

            tesseract = new Tesseract(100);

            //canvas = new Canvas(pictureBox.CreateGraphics());
            //canvas.Add(axis);
            //canvas.Add(cube);
            //canvas.Add(tesseract);

            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tesseract.Transform.Rotate(new Vector3(0f, 1f, 0f), 0.01f);

            graphics3D.Clear(Color.White);
            graphics3D.PushTransform();
            graphics3D.Translate(new Vector3(-50));
            graphics3D.Rotation(tesseract.Transform.Rotation);
            tesseract.Draw(graphics3D);
            graphics3D.PopTransform();
        }
    }
}
