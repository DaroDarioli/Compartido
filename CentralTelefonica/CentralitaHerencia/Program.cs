using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralEntidades;


namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central1 = new Centralita("Telefonica");


            //Local llamda1 = new Local("Chacarita", "Vicente Lopez", 0.3f, 2.65f);
            central1.LLamadas.Add(new Local("Chacarita", "Vicente Lopez", 0.3f, 2.65f));
            central1.LLamadas.Add(new Provincial(Franja.Franja_1, new Llamada("Almagro", "Lanus", 0.21f)));
            central1.LLamadas.Add(new Local("Palermo", "Barracas", 0.45f, 1.99f));
            central1.LLamadas.Add(new Provincial(Franja.Franja_3, new Llamada("Almagro", "Lanus", 0.21f)));

            central1.Mostrar();
            central1.OrdenarLlamadas();

            Console.ReadLine();

        }
    }
}
