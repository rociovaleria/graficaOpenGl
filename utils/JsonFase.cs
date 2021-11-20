using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using GraficaOpenGl.clases;
using System.Text.Json.Serialization;

namespace GraficaOpenGl.utils
{
    class JsonFase
    {
        [JsonInclude]
        public List<ver> vertices;
        [JsonInclude]
        public Vertex color;

        public JsonFace()
        {

        }

        public List<Vertice> GetVertices()
        {
            return this.vertices;
        }
    }
}
