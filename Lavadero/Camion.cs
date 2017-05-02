using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Camion : Vehiculo
    {
        private float _tara;

        public Camion(string patente, byte ruedas, EMarcas marca, float tara) : base(patente, ruedas, marca)
        {
            this._tara = tara;
        }

        public string MostarCamion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.Mostrar());
            sb.AppendLine("Tara: " + this._tara);

            return sb.ToString();
        }
      
    }
}
