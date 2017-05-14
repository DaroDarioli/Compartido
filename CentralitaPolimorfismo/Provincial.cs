using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Provincial : Llamada
    {
        private Franja _franjaHoraria;

        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }


        public override string ToString()
        {
            return this.Mostrar();
        }

        public Provincial(Franja miFranja, Llamada unaLlamada) : this(unaLlamada.NroOrigen, miFranja, unaLlamada.Duracion, unaLlamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float auxCosto = 0;

            if (this._franjaHoraria == Franja.Franja_1)
            {
                auxCosto = 0.99f;
            }              
            else if (this._franjaHoraria == Franja.Franja_2)
            {
                auxCosto = 1.25f;
            }               
            if (this._franjaHoraria == Franja.Franja_3)
            {
                auxCosto = 0.66f;
            }               

            return auxCosto * this._duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Franja horaria: " + this._franjaHoraria);
            sb.AppendLine("Costo LLamada: " + this.CalcularCosto() + "\n");
            return sb.ToString();

        }

        public override bool Equals(object obj)
        {

            if (obj is Provincial)
            {
                return ((Provincial)this == (Provincial)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public enum Franja { Franja_1, Franja_2, Franja_3 }
    public enum TipoLlamada { Local, Provincial, Todas }
}
