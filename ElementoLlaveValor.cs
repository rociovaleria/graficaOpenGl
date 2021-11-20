using GraficaOpenGl.clases;
using System;
using System.Xml.Serialization;

namespace GraficaOpenGl
{
    [Serializable]
    public class ElementoLlaveValor
    {
        public string Key { get; set; }

        
        public Face Valor { get; set; }
    }
}
