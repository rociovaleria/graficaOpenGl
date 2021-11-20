using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace GraficaOpenGl.clases
{
    public class jsonObjeto
    {
        [JsonInclude]
        public List<jsonFace> faces;

        public jsonObjeto()
        {
        }

        public List<jsonFace> GetFaces()
        {
            return this.faces;
        }
    }
}
