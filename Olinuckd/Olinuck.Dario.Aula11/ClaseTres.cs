using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Aula11
{
    public class ClaseTres : ClaseDos
    {
        protected string _atributoClaseTres;

        public override string Propiedad1
        {
            get { return "Clase tres hereda de: " + base.Propiedad1; }
        }

        public ClaseTres(String cadena1, String cadena2,String cadena3):base(cadena2,cadena3)
        {
            this._atributoClaseTres = cadena1;
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + this._atributoClaseTres;
        }

        //public string MostrarClaseTres()
        //{
        //    return this.PropiedadTres;
        //}


    }
}
