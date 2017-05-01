using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Parcial37
{
    class Usuario
    {
        private string _nombre;

        private string _apellido;

        private double _dni;

        public double DNI
        {
            get { return _dni; }
           
        }

        public Usuario(string nombre, string apellido, double dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
        }

        private string DevolverDatosFormatoString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(this._nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(this._apellido);
            sb.Append("DNI: ");
            sb.AppendLine(this._dni.ToString());

            return sb.ToString();


        }

        public string Mostrar(Usuario U)
        {
            return U.DevolverDatosFormatoString();
        }
    }
}
