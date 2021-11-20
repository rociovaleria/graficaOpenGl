using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace GraficaOpenGl
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWindow window = new VentanaPrincipal(1000, 1000, "Casa");
            window.Run(1.0 / 60.0);
        }
    }
}
