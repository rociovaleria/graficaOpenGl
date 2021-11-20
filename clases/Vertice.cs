using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Text.Json.Serialization;
namespace GraficaOpenGl.clases
{
    

   public  class Vertice
    {
        [JsonInclude]
        public float x;
        [JsonInclude]
        public float y;
        [JsonInclude]
        public float z;

        public Vertice()
        {
            this.x = 0;
            this.y = 0;
            this.z = 0;
        }
        public Vertice(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
        public float X
        {
            set { x = value; }
            get { return x; }
        }
        public float Y
        {
            set { y = value; }
            get { return y; }
        }
        public float Z
        {
            set { z = value; }
            get { return z; }
        }
        public void Dibujar()
        {
            GL.Vertex3(x, y, z);

        }


    }
}
