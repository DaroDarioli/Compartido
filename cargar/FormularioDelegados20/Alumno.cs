using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioDelegados20
{
    class Alumno
    {
        private string _apellido;

        private int _dni;

        private string _fotoAlumno;

        private string  _nombre;

        public string  Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        
        public string FotoAlumno
        {
            get { return _fotoAlumno; }
            set { _fotoAlumno = value; }
        }
        
        public int DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }
        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this._apellido = apellido;
            this._dni = dni;
            this._nombre = nombre;
            this._fotoAlumno = ruta;
        }
        
    }
}
