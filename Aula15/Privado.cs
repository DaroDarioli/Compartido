using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula15
{
    public class Privado : Avion
    {
        protected int _valoracionServicioDeAbordo;

        public override double Precio
        {
            set { _precio = value; }
            get { return _precio; }

        }

        public Privado(double precio, double velocidad, int valor)
            : base(precio, velocidad)
        {
            this._valoracionServicioDeAbordo = valor;
        }

    }
}
