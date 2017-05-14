using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralEntidades
{
    public class Provincial : Llamada
    {
        private Franja _franjaHoraria;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }

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
                auxCosto = 0.99f;

            if (this._franjaHoraria == Franja.Franja_2)
                auxCosto = 1.25f;

            if (this._franjaHoraria == Franja.Franja_3)
                auxCosto = 0.66f;

            return auxCosto * this._duracion;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Costo LLamada: " + this.CalcularCosto() + "\n\n");

        }
    }

    public enum Franja { Franja_1, Franja_2, Franja_3 }
    public enum TipoLlamada { Local, Provincial, Todas }
}
