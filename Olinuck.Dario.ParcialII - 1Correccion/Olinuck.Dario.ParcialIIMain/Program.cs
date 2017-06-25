using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olinuck.Dario.ParcialII;

namespace Olinuck.Dario.ParcialIIMain
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Manzana m1 = new Manzana(564f, ConsoleColor.Blue, "Sur");
            Manzana m2 = new Manzana(564f, ConsoleColor.Cyan, "Argentina");

            Cajon<Manzana> c1 = new Cajon<Manzana>(3);

            c1 = c1 + m1;
            c1 = c1 + m2;

            if(Serializar(c1))
                Console.WriteLine("Se pudo serializar el cajón");
         
            Console.ReadLine();
        }

        private static bool Serializar(ISerializable obj)
        {
            return(obj.SerializarXML());
              
        }

        private static bool Deserializar(ISerializable obj)
        {
            return (obj.SerializarXML());
        }


    }
}
