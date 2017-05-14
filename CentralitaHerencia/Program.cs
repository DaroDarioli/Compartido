using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using CentralEntidades;
using CentralitaPolimorfismo;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central1 = new Centralita("Telefonica");

            Local l1 = new Local("4512-4578", "7845-4512", 0.3f, 2.65f);
            Provincial l2 = new Provincial("4578-8956", Franja.Franja_1, 0.2f, "7845-4512");
            Local l3 = new Local("7845-7845", "7845-4512", 0.45f, 1.99f);
            Provincial l4 = new Provincial(Franja.Franja_3, l2);

            central1 += l1;
            central1 += l2;
            central1 += l3;
            central1 += l4;
            Console.WriteLine(central1.ToString()); 

            Console.ReadLine();

        }
    }
}
