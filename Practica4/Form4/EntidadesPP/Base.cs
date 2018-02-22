using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Data;


namespace EntidadesPP
{
    public abstract class Base
    {
        protected static int _subversion;
        protected static int _version;

        private static SqlConnection _conexion;
        private static SqlCommand _comando;

        static Base()
        {
            _version = 1;
            _subversion = 0;
           _conexion = new SqlConnection();//CadenaConexionMDE);//
            _comando = new SqlCommand();
            _comando.CommandType = System.Data.CommandType.Text;
            _comando.Connection = _conexion;
        }

        public string Version
        {
            set {

                if(ValidaCadena(value))
                {
                    _version = int.Parse(value);
                }

            }
            get { return _version.ToString(); }
        }

        public abstract string VersionFull
        {
            get;
        }

        protected Base() { }

        public Base(int vversion,int vsubversion)
        {
            _subversion = vsubversion;
            _version = vversion;
        }

        public static bool GuardarDatos<T>(T dato)where T:Base
        {

        }
        
        public bool LeerDatos<T>(Queue<T> q)
        {

        }

        public virtual string MostrarVersion()
        {
            return string.Format("{0}.{1}", _version, _subversion);
        }

        public bool ValidaCadena(string cadena)
        {
            foreach(char c in cadena)
            {
                if (c > 9 || c < 0 || c != '-')
                    return false;
            }

            return true;
        }

        public static string operator ~(Base b)
        {
            string cadena = b.MostrarVersion();
            cadena.Reverse();

            return cadena;
        }

        public override int GetHashCode()
        {
            return Base._subversion + Base._subversion;
        }
    }
}
