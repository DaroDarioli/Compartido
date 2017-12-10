using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Ejemplos
    {


        public void EjemploDelegado()
        {
            ClienteDelegado c = new ClienteDelegado();
            c.DireccionDelMetodo = Escribe;
            c.DireccionDelMetodo += Escribe2;

            Console.WriteLine(c.Divide(4, 0));

        }

        #region Métodos de escritura

        void Escribe(string mensaje)
        {
            Console.WriteLine(mensaje);
        }


        void Escribe2(string mensaje)
        {
            Console.WriteLine("Escribe2: {0}",mensaje);
        }

        #endregion
    }

}
