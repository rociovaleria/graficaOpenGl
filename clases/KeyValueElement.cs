using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GraficaOpenGl.clases
{
    [Serializable]
    [XmlInclude(typeof(Face))]

    class KeyValueElement
    {
        public string Key { get; set; }
        public dynamic Valor { get; set; }
    }
}
