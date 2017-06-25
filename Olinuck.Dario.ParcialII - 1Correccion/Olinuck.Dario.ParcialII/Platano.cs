using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.ParcialII
{
    public class Platano : Fruta
    {

        public string _paisOrigen;

        public override bool TieneCarozo
        {
            get{return false;}
        }

        public string Tipo
        {
            get { return "Platano"; }
        }

        public Platano(float peso, ConsoleColor color, string pais)
            : base(peso, color)
        {
            this._paisOrigen = pais;
        
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "pais: "+this._paisOrigen;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }


    }
}
