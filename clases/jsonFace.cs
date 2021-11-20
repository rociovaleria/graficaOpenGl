using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace GraficaOpenGl.clases
{
    public class jsonFace
    {
        [JsonInclude]
        public List<Vertice> vertices;

        [JsonInclude]
        public Vertice color;

        public jsonFace()
        {

        }

        public List<Vertice> GetVertices()
        {
            return this.vertices;
        }
        public Vertice GetColor()
        {
            return this.color;
        }
    }
}
