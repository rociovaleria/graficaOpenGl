using GraficaOpenGl.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;


namespace GraficaOpenGl.objetos
{
    class Triangulo 
        //: Objeto
    {


       /* public Triangulo() : base(0.0f, 0.25f, new Vector3(0.0f, 0.0f, 0f))
        {

        }
        public Triangulo(float largo, float ancho, Vector3 centro) : base(largo, ancho, centro)
        {
            

        }
        public override void color(double r, double g, double b)
        {
            this.r = r;
            this.g = g;
            this.b = b;

        }
        

        public override void construir()
        {
            setBase();
            setTecho();
        }
        public void setBase()
        {
            Fase fig = new Fase();
           
          fig.addVertice(new Vector3(-ancho / 2 +centro.X, largo / 2 + centro.Y, 0+centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 +centro.X, -largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, -largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            

            //adelante
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, -largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, -largo / 2 + centro.Y, 0 + centro.Z));
            //atras z
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, -largo / 2 + centro.Y,  -ancho+ centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho  + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho  + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, -largo / 2 + centro.Y, -ancho  + centro.Z));
            //der
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, -largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, -largo / 2 + centro.Y, 0 + centro.Z));

            //izq
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, -largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, -largo / 2 + centro.Y, 0 + centro.Z));

            //abajo
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, -largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, -largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, -largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, -largo / 2 + centro.Y, 0 + centro.Z));


            //arriba
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));

            fig.color(0.4784f, 0.2431f, 0.1333f);

            addFase("base", fig);
            addFase2(fig);
        }
        public void setTecho()
        {
            Fase fig = new Fase();
            //adelante
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            fig.addVertice(new Vector3(0 + centro.X, largo / 2 + centro.Y, -largo/2 + centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            //izq
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(0 + centro.X, largo / 2 + centro.Y, largo / 2 + centro.Z));
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));
            //atras
            fig.addVertice(new Vector3(ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho + centro.Z));
            fig.addVertice(new Vector3(0 + centro.X, largo / 2 + centro.Y,- largo / 2 + centro.Z));
           
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho + centro.Z));
            //derecha
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, -ancho + centro.Z));
          
            fig.addVertice(new Vector3(0 + centro.X, largo / 2 + centro.Y,- largo / 2 + centro.Z));
            fig.addVertice(new Vector3(-ancho / 2 + centro.X, largo / 2 + centro.Y, 0 + centro.Z));


            fig.color(0.5784f, 0.6431f, 0.1333f);
            addFase("techo", fig);

        }*/


    }
}
