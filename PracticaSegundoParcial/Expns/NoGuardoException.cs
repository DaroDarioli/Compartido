using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoGuardoException : Exception
    {
        public string _mensaje;
        public NoGuardoException() : base() { }

        public NoGuardoException(string mensaje) : base (mensaje)
        {
            this._mensaje = mensaje;
        }

        public NoGuardoException(string mensaje, Exception e) : base(mensaje,e)
        {
            this._mensaje = mensaje;
        }


    }
}
