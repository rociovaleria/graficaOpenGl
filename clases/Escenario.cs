using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OpenTK;
using OpenTK.Graphics.OpenGL;


namespace GraficaOpenGl.clases
{
    class Escenario: ITrans
    {
        //origen de coordenadas igual que el game windows  3metodos add eliminar obtener con hasmap esc centro de masa

        Dictionary<String, Objeto> hashObjetos;
        [XmlIgnore]
        List<Objeto> listaobjetos;
        [XmlElement(ElementName = "centro")]
        public Vector3 centro;

        public Escenario()
        {
            hashObjetos = new Dictionary<String, Objeto>();
            listaobjetos = new List<Objeto>();

            centro = new Vector3 (0.5f, -0.5f, 0f);
        }
        public Escenario(Vector3 centro)
        {
            hashObjetos = new Dictionary<String, Objeto>();
            this.centro = centro;
            //listaobjetos = new List<Objeto>();
        }
        public Escenario(Dictionary<String, Objeto> hashObjetos)
        {
            this.hashObjetos = hashObjetos;
        }
        public void Dibujar()
        {

            foreach (KeyValuePair<String, Objeto> objeto in hashObjetos)
            {

                GL.PushMatrix();
                objeto.Value.Dibujar();
                GL.PopMatrix();

            }


        }

        public void Dibujar2()
        {

            foreach (var objeto in listaobjetos)
            {

                GL.PushMatrix();
                objeto.Dibujar2();
                GL.PopMatrix();

            }


        }

        public void AddObjeto(String clave, Objeto objeto)
        {
            //objeto.construir();

            hashObjetos.Add(clave, objeto);
            listaobjetos.Add(objeto);
        }


        public Objeto getObjeto(string clave)
        {
            Console.WriteLine(hashObjetos[clave]);
            return this.hashObjetos[clave];

        }
        public void RotateX(float Angle)
        {

            foreach (KeyValuePair<String, Objeto> figura in hashObjetos)
            {
                figura.Value.RotateX(Angle);

            }

        }
         
    public void RotateY(float Angle)
        {
            foreach (KeyValuePair<String, Objeto> figura in hashObjetos)
            {
                figura.Value.RotateY(Angle);

            }
        }

        public void RotateZ(float Angle)
        {
            foreach (KeyValuePair<String, Objeto> figura in hashObjetos)
            {
                figura.Value.RotateZ(Angle);

            }
        }
        public void closeMatrix()
        {
            GL.PopMatrix();
        }

        public void TraslateX(float valor)
        {
            foreach (KeyValuePair<string, Objeto> objeto in hashObjetos)
            {
                objeto.Value.TraslateX(valor);

            }
        }

        public void TraslateY(float valor)
        {
            foreach (KeyValuePair<string, Objeto> objeto in hashObjetos)
            {
                objeto.Value.TraslateY(valor);

            }
        }

        public void TraslateZ(float valor)
        {
            foreach (KeyValuePair<string, Objeto> objeto in hashObjetos)
            {
                objeto.Value.TraslateZ(valor);

            }
        }
        public void Scale(float valor)
        {
            foreach (KeyValuePair<string, Objeto> objeto in hashObjetos)
            {
                objeto.Value.Scale(valor);

            }
        }
    }
}
