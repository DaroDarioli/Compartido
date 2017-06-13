using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    public class Avion : Vehiculo,IAFIP,IARBA
    {
        protected double _velocidadMaxima;


        public override double Precio
        {
            set { _precio = value; }
            get { return _precio; }

        }

        public Avion(double precio, double velocidad)
            : base(precio)
        {
            this._velocidadMaxima = velocidad;
        }

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 0.33;
        }

        //NO PUEDE SER PUBLICO
        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.1;
        }
        
        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio);
        }
       
    }
}
