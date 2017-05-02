using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Moto : Vehiculo
    {
        private float _cilindrada;

        public Moto(string patente, byte ruedas,EMarcas marca, float cilindrada) :  base(patente,ruedas,marca)
        {
            this._cilindrada = cilindrada;
        }

        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Mostrar());
            sb.AppendLine("Cilindrada: " + this._cilindrada);

            return sb.ToString();
        }
    }
}
