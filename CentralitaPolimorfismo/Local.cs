using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Local : Llamada
    {
        protected float _costo;

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(Llamada unaLlamada, float costo) : this(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion, costo)
        {

        }
        public Local(string origen, string destino, float duracion, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }
       

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo LLamada: " + this.CalcularCosto() + "\n");
            return sb.ToString();

        }

        private float CalcularCosto()
        {
            return this._costo * this._duracion;
        }

        public override bool Equals(object obj)
        {

            if (obj is Local)
            {
                return ((Local)this == (Local)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }




    }
}
