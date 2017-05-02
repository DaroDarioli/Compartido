using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Auto : Vehiculo
    {
        private int _cantidadAsientos;

        public Auto(string patente, byte ruedas, EMarcas marca,int cantAsientos) : base (patente,ruedas,marca)
        {
            this._cantidadAsientos = cantAsientos;
        }

        public string MostraAuto()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Mostrar());
            sb.AppendLine("Cantidad de Asientos: " + this._cantidadAsientos);

            return sb.ToString();
        }
        

    }
}
