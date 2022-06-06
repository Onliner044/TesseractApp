using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesseractApp.Shapes {
    public abstract class Primitive {
        public PointF Position { get; set; }

        public Primitive() {
            Position = new PointF();
        }

        public Primitive(PointF position) {
            Position = position;
        }

        /*public static PointF CenterPoint(Primitive primitive1, Primitive primitive2) {
            *//*return new PointF()
                .Add(primitive1.Position)
                .Add(primitive2.Position)
                .Multiply(0.5f);*//*
        }*/
    }
}
