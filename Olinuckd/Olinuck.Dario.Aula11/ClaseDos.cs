using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Aula11
{
    public class ClaseDos : ClaseUno
    {
        protected string _atributoClaseDos;

        public override string Propiedad1
        {
            get { return "Clase dos hereda de: " + base.Propiedad1; }
        }

        public ClaseDos(string cadena1, string cadena2)
            : base(cadena1)
        {
            this._atributoClaseDos = cadena1;
        
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + this._atributoClaseDos;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


        //public string MostrarClaseDos()
        //{
        //    return this._atributoClaseDos;
        //}

    }
}
