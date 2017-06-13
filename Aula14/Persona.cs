using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14
{
    public class Persona
    {
        protected string _nombre;

        protected string _apellido;

        protected int _edad;

        protected ESexo1 _sexo;

        public string Nombre
        {
            get { return this._nombre;  }
        }

        public ESexo1 Sexo
        {
            get { return this._sexo;  }                       
        }


        public Persona(string nombre, string apellido, int edad, ESexo1 sexo)
        {
            this._nombre = nombre;

            this._apellido = apellido;

            this._edad = edad;

            this._sexo = sexo;           
        
        }

        public static string ObtenerInfo(Persona p)
        { 
            return "Nombre: "+p._nombre+" Apellido: "+p._apellido+" Edad: "+p._edad+" Sexo: "+p._sexo.ToString();
        }

    }
   
}
