using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Drawing3D.Primitives
{
    public class PrimitivePath
    {
        public List<Vector3> Path { get; protected set; }

        public PrimitivePath()
        {
            Path = new List<Vector3>();
        }


    }
}
