using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.ParcialII
{
    public interface ISerializable
    {
        string RutaArchivo { get; set; }

        bool DeserializarXML();

        bool SerializarXML();
    }
}
