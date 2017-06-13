using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    class Familiar : Auto
    {
        protected int _cantAsientos;


        public override double Precio
        {
            set { _precio = value; }
            get { return _precio; }

        }


        public Familiar(double precio, string patente, int cantAsientos)
            : base(precio, patente)
        {
            this._cantAsientos = cantAsientos;
        }


        public override void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
        }
    }

}
