using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoLeeException : Exception
    {
        public string _mensaje;

        public NoLeeException() : base() { }

        public NoLeeException(string mensaje) : base (mensaje)
        {
            this._mensaje = mensaje;
        }


        public NoLeeException(string mensaje, Exception e) : base(mensaje,e)
        {
            this._mensaje = mensaje;
        }
    }
}
