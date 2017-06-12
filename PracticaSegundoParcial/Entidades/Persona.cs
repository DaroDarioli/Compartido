using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        protected string _nombre;

        protected string _apellido;

        protected int _legajo;

        protected abstract int Legajo
        {
            get;

            set;
        }



        #endregion
        #region Propiedades

        public Persona(string nombre, string apellido, int legajo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._legajo = legajo;

        }

        public override string ToString()
        {
            return "Nombre: "+this._nombre  +" Apellido: "+this._apellido + " Legajo: "+this._legajo;
        }




        #endregion
    }
}
