using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    class Carreta : Vehiculo, IARBA
    {
        public override double Precio
        {
            set { _precio = value; }
            get { return _precio; }

        }
        
        public Carreta(double precio)
            : base(precio)
        { }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio);
        }


        public double CalcularImpuesto()
        {
            return this._precio * 0.33;
        }
    }
}
