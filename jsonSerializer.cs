using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GraficaOpenGl
{
    class jsonSerializer
    {
        public jsonSerializer()
        {
        }

        public T Read<T>(String jsonFileName)
        {
            String result = File.ReadAllText(jsonFileName);
            T obj = JsonSerializer.Deserialize<T>(result);
            return obj;
        }
    }
}
