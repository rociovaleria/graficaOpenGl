using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK;


namespace GraficaOpenGl.clases

{
    public class Face : ITrans
    {
      
        public List<Vector3> vertices { get; set; }

     

        public Vector3 centro;
        public Vector3 color;


        public Face()
        {
            vertices = new List<Vector3>();
          
            centro.X = 0; centro.Y = 0; centro.Z = 0;

        }
        public Face(List<Vector3> vertices, Vector3 color)
        {

            this.vertices = vertices;
           // this.color. = color.X;
            this.color = color;

        }

        public double CX
        {
            set { centro.X = (float)value; }

            get { return centro.X; }
        }
        public double CY
        {
            set { centro.Y = (float)value; }

            get { return centro.Y; }
        }
        public double CZ
        {
            set { centro.Z = (float)value; }

            get { return centro.Z; }
        }


       
        public void addVertice(Vector3 vertice)
        {
            vertices.Add(vertice);
        }



        public void RotateX(float Angle)
        {

            GL.MatrixMode(MatrixMode.Modelview);

            for (int i = 0; i < vertices.Count; i++)
            {
                Matrix3 matrix = Matrix3.CreateRotationX(MathHelper.DegreesToRadians(Angle));
                vertices[i] = vertices[i] * matrix;
            }
        }

        public void RotateY(float Angle)
        {   
                GL.MatrixMode(MatrixMode.Modelview);

            for (int i = 0; i < vertices.Count; i++)
            {   
                Matrix3 matrix = Matrix3.CreateRotationY(MathHelper.DegreesToRadians(Angle));
                vertices[i] = vertices[i] * matrix;
                //GL.Rotate(MathHelper.DegreesToRadians(Angle), vertices[i].X, vertices[i].Y, vertices[i].Z);
                
            }
        }

        public void RotateZ(float Angle)
        {

            GL.MatrixMode(MatrixMode.Modelview);

            for (int i = 0; i < vertices.Count; i++)
            {
                Matrix3 matrix = Matrix3.CreateRotationZ(MathHelper.DegreesToRadians(Angle));
                vertices[i] = vertices[i] * matrix;
            }
        }
        public void Dibujar()
        {
            GL.Color3(this.color.X, this.color.Y, this.color.Z);

            GL.Begin(BeginMode.Quads);
            foreach (var vertice in this.vertices)
            {
                GL.Vertex3(vertice);
            }
            GL.End();

            GL.Flush();

        }

        public void Traslate(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }
        public void Scale(float v)
        {
            GL.MatrixMode(MatrixMode.Modelview);

            for (int i = 0; i < vertices.Count; i++)
            {

               
                Matrix3 scale = Matrix3.CreateScale(v,v,v);
                vertices[i] = vertices[i] * scale; 
            }
        }


        public void TraslateX(float valor)
        {
            GL.MatrixMode(MatrixMode.Modelview);

            for (int i = 0; i < vertices.Count; i++)
            {
                Matrix4 traslate = Matrix4.CreateTranslation(valor,0,0);
                Vector4 aux = new Vector4(vertices[i].X, vertices[i].Y, vertices[i].Z, 1.0f) * traslate;
                vertices[i] = new Vector3(aux.X,aux.Y,aux.Z);
            }
        }
        public void TraslateY(float valor)
        {
            GL.MatrixMode(MatrixMode.Modelview);

            for (int i = 0; i < vertices.Count; i++)
            {
                Matrix4 traslate = Matrix4.CreateTranslation(0,valor, 0);
                Vector4 aux = new Vector4(vertices[i].X, vertices[i].Y, vertices[i].Z, 1.0f) * traslate;
                vertices[i] = new Vector3(aux.X, aux.Y, aux.Z);
            }
        }
        public void TraslateZ(float valor)
        {
            GL.MatrixMode(MatrixMode.Modelview);

            for (int i = 0; i < vertices.Count; i++)
            {
                Matrix4 traslate = Matrix4.CreateTranslation(0, 0, valor);
                Vector4 aux = new Vector4(vertices[i].X, vertices[i].Y, vertices[i].Z, 1.0f) * traslate;
                vertices[i] = new Vector3(aux.X, aux.Y, aux.Z);
            }
        }
    }

}
