using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejemplos e = new Ejemplos();

            e.EjemploDelegado();

            Console.Write("presiona 'enter' para terminar");
            Console.ReadLine();
        }
    }
}
