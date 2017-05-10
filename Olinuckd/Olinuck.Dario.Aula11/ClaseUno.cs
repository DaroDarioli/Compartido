using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Aula11
{
    public class ClaseUno
    {
        protected string _atributoClaseUno;

        public virtual string Propiedad1
        {
            get { return "Clase Uno"; }           
        }

        public ClaseUno(string cadena)
        { 
            this._atributoClaseUno = cadena;
        }

        protected virtual string Mostrar()
        {
            return this._atributoClaseUno;        
        }

        public void Imprimir()
        {
            Console.WriteLine("Soy metodo clase uno");
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
