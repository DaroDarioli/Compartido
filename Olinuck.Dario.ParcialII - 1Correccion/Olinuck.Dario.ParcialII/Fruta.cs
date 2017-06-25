using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.ParcialII
{
    public abstract class Fruta
    {
        protected ConsoleColor _color;

        protected float _peso;

        public abstract bool TieneCarozo
        {
            get;
        }

        public Fruta() { }  // para serializar
        public Fruta(float peso, ConsoleColor color)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        { 
            return "PEso: "+this._peso + " Color: " +this._color;
        }
    }
}
