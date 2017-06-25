using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Olinuck.Dario.ParcialII
{
    static class Ticketeadora
    {
        public static bool ImprimirTicket(this Cajon<Platano> c, string path)
        {
            DateTime local = DateTime.Now;
            string direccion1 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string dato = "Precio Total: " + c.PrecioTotal.ToString() + "Fecha: " + local.ToString();

            try
            {
                StreamWriter sw = new StreamWriter("E:\\CajonManzanas.txt");
                sw.WriteLine(dato);
                sw.Close();

                return true;

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;

            }


        }


        
    }
}
