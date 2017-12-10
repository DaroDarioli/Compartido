using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    class DerivadaDos : Base
    {
        public override string VersionFull
        {
            get
            {
                return this.MostrarVersion();
            }
        }

        public DerivadaDos() : base(1,0) { }

              

        protected override string MostrarVersion()
        {
            return string.Format("{0}",2);
        }


        public static void EjecutarEvento2(List<Base> lista)
        {
            foreach (Base b in lista)
            {

                if (b is DerivadaUno)
                {
                    Base.GuardarDatos("1");
                }
                if (b is DerivadaDos)
                {
                    Base.GuardarDatos("2");
                }



            }
            //apuntar a leer base

        }
    }
}
