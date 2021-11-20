using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraficaOpenGl.clases;
using GraficaOpenGl.objetos;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
namespace GraficaOpenGl
{
    class VentanaPrincipal:GameWindow 
    {
        Escenario escenario;
        Vector3 centroCasa = new Vector3(-0.3f, 0.3f, 0.0f);
        Vector3 centroCasa2 = new Vector3(0.3f,- 0.5f, 0.0f);
        //Objeto casa = new Objeto();
        float theta = 0.45f;
       
        float scaleValue = 1f;
        jsonSerializer serializador = new jsonSerializer();



        public VentanaPrincipal(int width, int height, string title):base(width,height,GraphicsMode.Default,title)
        {

            

            Objeto casa = new Objeto("casa",centroCasa);

            casa.agregarParte("base", "base.json");
            casa.agregarParte("techo", "techo.json");
            casa.agregarParte("puerta", "puerta.json");
           
            Dictionary<String, Objeto> objects = new Dictionary<string, Objeto>();
            //objects.Add("cubo2", new Objeto("cube2.json",centroCubo));
            Objeto casa2 = new Objeto("casa2", centroCasa2);
            casa2.agregarParte("base", "base.json");
            casa2.agregarParte("techo", "techo.json");
            escenario = new Escenario();
            escenario.AddObjeto(casa.nombre,casa);
            escenario.AddObjeto(casa2.nombre, casa2);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.ClearColor(0.8431f, 0.3373f, 6745.3f, 1.0f);
            var input = OpenTK.Input.Keyboard.GetState();
            // escenario.Dibujar();
            escenario.getObjeto("casa").Dibujar();
                //escenario.getObjeto("casa").RotateZ(theta);

          
            escenario.getObjeto("casa2").Dibujar();
              escenario.getObjeto("casa").RotateY("techo" ,theta);
             escenario.getObjeto("casa").TraslateY(0.001f);
            //  escenario.RotateY(theta);
           // escenario.RotateY(theta);

            if (input.IsKeyDown(Key.X))
            {
                escenario.getObjeto("casa").RotateX(theta);
            }
            if (input.IsKeyDown(Key.Y))
            {
                escenario.getObjeto("casa").RotateY(theta);
            }
            if (input.IsKeyDown(Key.Z))
            {
                escenario.getObjeto("casa").RotateZ(theta);

            }
            if (input.IsKeyDown(Key.Escape))
            {
                Close();
            }

            Context.SwapBuffers();
            base.OnRenderFrame(e);
            theta += 0.0001f;
            scaleValue -= 0.0001f;
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
        protected override void OnUnload(EventArgs e)
        {

            base.OnUnload(e);
        }
    }
}
