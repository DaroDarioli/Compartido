using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Olinuck.Dario.Aula11;

namespace Olinuck.Dario.MainAula11
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno clase1 = new ClaseUno("Clase Uno");

            ClaseDos clase2 = new ClaseDos("Clase uno","clase dos");

            ClaseTres clase3 = new ClaseTres("clase uno", "clase dos", "clase tres");

            ClaseCuatro clase4 = new ClaseCuatro("clase uno", "clase dos", "clase tres","clase cuatro");

            List<ClaseUno> miLista = new List<ClaseUno>();

            miLista.Add(clase1);
            miLista.Add(clase2);
            miLista.Add(clase3);
            miLista.Add(clase4);

            Console.WriteLine("\n\n---------override ToString()------\n\n");
            
            foreach (ClaseUno c in miLista)
            {
                Console.WriteLine(c.ToString());
            }

            
            //foreach (ClaseUno c in miLista)
            //{                
            //    Console.WriteLine(c.Mostrar());      
            //}

            Console.WriteLine("\n\n---------Con propiedad------\n\n");
            
            foreach (ClaseUno c in miLista)
            {
                Console.WriteLine(c.Propiedad1);
            }

            //Console.WriteLine("\n\n---------sin override ------\n\n");

            //foreach (ClaseUno c in miLista)
            //{
            //  //  Console.WriteLine(c.);
            //}



            Console.ReadLine();
            
        }
    }
}
