using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{


    delegate void EscribeMensaje(string mensaje);


    class ClienteDelegado
    {
        public EscribeMensaje DireccionDelMetodo;
        public int Divide(int A,int B)
        {
            int c = 0;

            if(B==0)
            {
                if(DireccionDelMetodo != null)
                {
                    DireccionDelMetodo("Dentro de divide ivision entre cero");
                }

            }
            else
            {
                c = A / B;
            }
            return c;
        }
    }
}
