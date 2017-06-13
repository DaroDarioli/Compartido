using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    public class Deportivo : Auto, IAFIP,IARBA
    {
        protected int _caballosFuerza;

        public override double Precio
        {
            set { _precio = value; }
            get { return _precio; }

        }

        public Deportivo(double precio, string patente, int caballos)
            : base(precio, patente)
        {
            this._caballosFuerza = caballos;
        }
               

        public double CalcularImpuesto()
        {
            return this._precio * 0.28;
        }

        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
        }

       
    }
}
