using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Aula11
{
    public class ClaseCuatro : ClaseTres
    {
        protected string _atributoClaseCuatro;

        //public override string Propiedad1
        //{
        //    get
        //    {
        //        return "Clase cuatro hereda de: " + base.Propiedad1;
        //    }
        //}


        public ClaseCuatro(string cad1, string cad2, string cad3, string cad4)
            : base(cad2, cad3, cad4)
        {
            this._atributoClaseCuatro = cad1;
        }
    }
}
