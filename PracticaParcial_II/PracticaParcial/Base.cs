using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



using System.Data;
using System.Data.SqlClient;

namespace PracticaParcial
{
    public abstract class Base
    {

        private static int _subversion;

        private static int _version;

        public static TraerLista traigolista;

        //__________________

        private static SqlConnection _connection;

        private static SqlCommand _command;

        //___________________

        #region Propiedades

        public string Version
        {
            get { return _version.ToString(); }


            set
            {

                try
                {
                    _version = int.Parse(value);
                }
                catch
                {

                }

            }
        }

        public abstract string VersionFull
        {
            get;
        }


        #endregion

        static Base()
        {
            _subversion = 0;
            _version = 1;
        }


        public Base(int version, int subversion)
        {
            _version = version;
            _subversion = subversion;
            _connection = new SqlConnection(Properties.Settings.Default.Setting);
            _command = new SqlCommand();

        }

        public override int GetHashCode()
        {
            return _subversion + _version;
        }


        public static void EjecutarEvento(List<Base> lista)
        {
            foreach (Base b in lista)
            {

                if(b is DerivadaUno)
                {
                    Base.GuardarDatos("1");
                }
                if(b is DerivadaDos)
                {
                    Base.GuardarDatos("2");
                }

                

            }

            Queue<Base> cola = new Queue<Base>();

            traigolista = LeerDatos<Base>;

            cola = traigolista();

         //   CargarForm(cola);
            //apuntar a leer base

        }

        public static bool GuardarDatos<T>(T dato)where T :class
        {
         
            try
            {
                _command.Connection = _connection;
                _command.CommandType = CommandType.Text;
                _command.CommandText = "INSERT into Datos(version,subversion,derivada) VALUES (" + _version + "," + _subversion + "," + int.Parse(dato.ToString())+" )";
                _connection.Open();
                _command.ExecuteNonQuery();
                _connection.Close();
                return true;


            }
            catch (Exception e)
            {
                
                Test t = new Test();
                t.richTest.AppendText(e.Message);
                t.ShowDialog();

                return false;
            } 

        }



        public static Queue<T> LeerDatos<T>()
        {

            Queue<T> myQ = new Queue<T>();

            Queue Q = new Queue();


            try
            {
                _command.Connection = _connection;
                _command.CommandType = CommandType.Text;
                _command.CommandText = "SELECT * FROM Datos";
                _connection.Open();

                SqlDataReader sr = _command.ExecuteReader();

                while (sr.Read())
                {

                    Q.Enqueue(sr[0]);
                    Q.Enqueue(sr[1]);
                    Q.Enqueue(sr[2]);
                    Q.Enqueue(sr[3]);

                }
                sr.Close();
                _connection.Close();


                Test lectura = new Test();
                foreach(object o  in Q)
                {
                    lectura.richTest.AppendText(o.ToString());
                }
                
                lectura.ShowDialog();



                return myQ;

            }
            catch (Exception e)
            {

                Test lectura = new Test();
                lectura.richTest.AppendText(e.Message);
                lectura.ShowDialog();
            }

            return myQ; 

        }

        
        protected virtual string MostrarVersion()
        {
            return string.Format("{0}{1}",_version,_subversion);
        }

        public static string operator ~(Base b)
        {
            return Reverse((b.MostrarVersion()));
        }


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        
        public static void CargarForm(Queue<Base> cola)
        {


            Test t = new Test();
            
           
            foreach(Base c in cola)
            {
                t.richTest.AppendText(c.VersionFull);
            }

            t.ShowDialog();
        }



    }
}
