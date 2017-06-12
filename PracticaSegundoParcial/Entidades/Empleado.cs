using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Empleado : Persona, IArchivos<string>
    {
      

        protected override int Legajo
        {
            get { return this._legajo; }

            set { this._legajo = CargarLegajo(value); }
        }

        public int CargarLegajo(int leg)
        {
            if ((leg % 0 == 1) || (leg < 0))
            {
                throw new LegajoInvalidoException("Legajo invalido");
            }
            else
                return leg;
        }

        public Empleado(string nombre, string apellido, int legajo) : base(nombre,apellido,legajo)
        {

        }

        public static string MostrarDatos(Empleado e)
        {
            //StringBuilder sBuilder = new StringBuilder();
            //sBuilder.AppendLine("NOMBRE: " + e._nombre);
            //sBuilder.AppendLine("APELLIDO: " + e._apellido);
            //sBuilder.AppendLine("LEGAJO: " + e._legajo);
            //sBuilder.AppendLine("<------------------------------->");

            return e.ToString();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public bool Guardar(string archivo, string datos)
        {

            try
            {
                using (StreamWriter sw1 = new StreamWriter(archivo)) // bloque using me asegurar liberar recursos
                {
                    sw1.WriteLine(datos);
                }
                return true;
            }
            catch (Exception e)
            {

                throw new NoGuardoException(e.Message);
                              
            }
        }

        /// <summary>
        /// Lee un arhivo de texto y devuelve los datos como string
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool Leer(string archivo, out string datos)
        {
            bool auxRet = true;

            StringBuilder sb = new StringBuilder();

            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    string aux;
                    do
                    {
                        aux = sr.ReadLine();
                        sb.AppendLine(aux);

                    } while (aux != null);
                    datos = sb.ToString();
                }

            }
            catch (Exception e)
            {

                throw new NoLeeException(e.Message);

            }
            return auxRet;

        }
    }
}
