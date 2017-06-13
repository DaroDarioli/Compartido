using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public abstract double Precio
        {
            set;

            get;

        }

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }

        public abstract void MostrarPrecio();
        
            
        
    }
}
