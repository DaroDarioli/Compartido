using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    public class Comercial : Avion
    {
        protected int _cantidadDePasajeros;

        public override double Precio
        {
            set { _precio = value; }
            get { return _precio; }

        }


        public Comercial(double precio, double velocidad, int cantidad)
            : base(precio, velocidad)
        {
            this._cantidadDePasajeros = cantidad;
        }

     


    }
}
