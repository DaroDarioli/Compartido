using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Aula16
{
    [Serializable]
    public class Persona
    {
        public string _nombre;

        public int _edad;

        public bool _esMayor;

        public Persona()
        { }

        public Persona(string nombre, int edad, bool mayor)
        {
            this._nombre = nombre;
            this._edad = edad;
            this._esMayor = mayor;
        }


        public override string ToString()
        {
            return "Nombre: "+this._nombre + " Edad: "+this._edad+" Mayor: "+this._esMayor.ToString();
        }
    }
}
