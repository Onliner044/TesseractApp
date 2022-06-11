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
    class Axis : Primitive
    {
        public Axis(float a)
        {
            Children.AddRange(new IDrawable[]
            {
                new Line(new Vector3(-a, 0, 0), new Vector3(a, 0, 0)),
                new Line(new Vector3(0, -a, 0), new Vector3(0, a, 0)),
                new Line(new Vector3(0, 0, -a), new Vector3(0, 0, a)),
            });

            Pen.Color = Color.Red;
        }
    }

    public partial class MainForm : Form
    {
        Canvas canvas;

        Axis axis;
        Cube cube;

        public MainForm()
        {
            InitializeComponent();

            axis = new Axis(10);
            cube = new Cube(100);
            cube.Transform.Origin = new Vector3(50,50,50);
            //cube.Transform.Translate(new Vector3(50,0,0), Mode.World);
            cube.Pen.Color = Color.Red;

            canvas = new Canvas(pictureBox.CreateGraphics());
            canvas.Add(axis);
            canvas.Add(cube);

            timer1.Interval = 10;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas.Clear(Color.White);

            cube.Transform.Rotate(new Vector3(1, 0, 1), 0.01f, Mode.World);
            
            canvas.Draw();
        }
    }
}
