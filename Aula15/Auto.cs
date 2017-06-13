using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    public abstract class Auto : Vehiculo
    {
        protected string _patente;

        public override double Precio
        {
            set { _precio = value; }
            get { return _precio; }

        }

        public Auto(double precio, string patente)
            : base(precio)
        {
            this._patente = patente;
        }

        public abstract void MostrarPatente();

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio);
        }
    }
}
