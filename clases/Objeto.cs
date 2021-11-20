using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace GraficaOpenGl.clases
{

    public class Objeto : ITrans
    {

  
        public List<Face> listafases;
        public String nombre;

        public Dictionary<string, Face> hashFases { get; set; }

 
        public Vector3 centro;
      
        public float ancho;
    
        public float largo;
        
        

        public Objeto(string nombre, Vector3 centro)
        {
          
            this.centro = centro;
            this.nombre = nombre;
            hashFases = new Dictionary<string, Face>();
            listafases = new List<Face>();
            //Init();
        }
        public Objeto(string nombre)
        {
            hashFases = new Dictionary<string, Face>();
            centro.X = 0; centro.Y = 0; centro.Z = 0;
            listafases = new List<Face>();
            this.nombre = nombre;
            //Init();
        }

        public void agregarParte(string nombreFase, string nombreArchivo) {
            Init(nombreFase, nombreArchivo);

        }
        private void Init(string nombreFase, string nombreArchivo)
        {
            jsonSerializer jsonReader = new jsonSerializer();

            jsonObjeto jsonObject = jsonReader.Read<jsonObjeto>(nombreArchivo);

            List<jsonFace> jsonFaces = jsonObject.GetFaces();
            foreach (jsonFace jsonFace in jsonFaces)
            {
                List<Vector3> vertices = new List<Vector3>();
                List<Vertice> jsonVertices = jsonFace.GetVertices();
                foreach (Vertice vertex in jsonVertices)
                {
                    vertices.Add(new Vector3(vertex.X+centro.X, vertex.Y+centro.Y, vertex.Z+centro.Z));
                }
                Vertice jsonColor = jsonFace.GetColor();
                Vector3 color = new Vector3(jsonColor.X, jsonColor.Y, jsonColor.Z);

                this.listafases.Add(new Face(vertices, color));
                this.hashFases.Add(nombreFase, new Face(vertices, color));
            }
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

        public void addFase(string nombreFase, Face fase)
        {

            hashFases.Add(nombreFase, fase);
        }

        public void addFase2(Face fase)
        {

            listafases.Add(fase);
        }
        public void Dibujar()
        {

            foreach (KeyValuePair<string, Face> objeto in hashFases)
            {
                objeto.Value.Dibujar();


            }

        }
        public void Dibujar2()
        {
            foreach (var fase in listafases)
            {
                fase.Dibujar();


            }

        }
        public void RotateX(float Angle)
        {
            foreach (KeyValuePair<string, Face> figura in hashFases)
            {
                figura.Value.RotateX(Angle);

            }

        }
        public void RotateX(String part, float angle)
        {
            hashFases[part].RotateX(angle);
        }
        public void RotateY(float Angle)
        {
            foreach (KeyValuePair<string, Face> figura in hashFases)
            {
                figura.Value.RotateY(Angle);

            }

        }

        public void RotateY(String part, float angle) {
            hashFases[part].RotateY(angle);
        }

        public void RotateZ(float Angle)
        {
            foreach (KeyValuePair<string, Face> figura in hashFases)
            {
                figura.Value.RotateZ(Angle);

            }

        }
        public void RotateZ(String part, float angle)
        {
            hashFases[part].RotateZ(angle);
        }

        //  public abstract void construir();

        public void Traslate(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void Scale(float valor)
        {
            foreach (KeyValuePair<string, Face> figura in hashFases)
            {
                figura.Value.Scale(valor);

            }
        }


        public void TraslateX(float valor)
        {
            foreach (KeyValuePair<string, Face> face in hashFases)
            {
                face.Value.TraslateX(valor);

            }
        }


        public void TraslateY(float valor)
        {
            foreach (KeyValuePair<string, Face> face in hashFases)
            {
                face.Value.TraslateY(valor);

            }
        }


        public void TraslateZ(float valor)
        {
            foreach (KeyValuePair<string, Face> face in hashFases)
            {
                face.Value.TraslateZ(valor);

            }
        }


    }
}
