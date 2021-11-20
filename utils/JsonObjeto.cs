using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace GraficaOpenGl.utils
{
    class JsonObjeto
    {

        [JsonInclude]
        public List<JsonFace> faces;

        public JsonObject()
        {
        }

        public List<JsonFace> GetFaces()
        {
            return this.faces;
        }
    }
}
