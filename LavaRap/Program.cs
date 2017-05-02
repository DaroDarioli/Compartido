using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lavadero;

namespace LavaRap
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("AAA 111", 4, EMarcas.Honda, 4);
            Moto moto1 = new Moto("AAA 222", 2, EMarcas.Zanella, 200);
            Camion camion1 = new Camion("AAA 333", 18, EMarcas.Scania, 30000);

            Lavadero1 Avellaneda = new Lavadero1(400, 200, 500);
            Avellaneda += auto1;
            Avellaneda += moto1;
            Avellaneda += camion1;
            FormLavadero lav = new FormLavadero(Avellaneda.Mostrar);

            Console.WriteLine(Avellaneda.Mostrar);

            Avellaneda.Lista.Sort(Lavadero1.OrdenarVehiculosPorMArca);           
            Console.WriteLine("\n\tOrdenado por marca\n");
            Console.WriteLine(Avellaneda.Mostrar);
            Console.WriteLine("Facturado por coche: " + Avellaneda.MostrarTotalFacturado(Lavadero1.EVehiculos.Auto));
            Console.WriteLine("Facturado por moto: " + Avellaneda.MostrarTotalFacturado(Lavadero1.EVehiculos.Moto));
            Console.WriteLine("Facturado por camión: " + Avellaneda.MostrarTotalFacturado(Lavadero1.EVehiculos.Camion));
            Console.ReadLine();
        }
    }
}
