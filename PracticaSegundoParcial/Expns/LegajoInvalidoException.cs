using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class LegajoInvalidoException : Exception
    {
        public string _msg;
        public LegajoInvalidoException(string msg)  :base(msg) {
            this._msg = msg;
        }
    }
}
