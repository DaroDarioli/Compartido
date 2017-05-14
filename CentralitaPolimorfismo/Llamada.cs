using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public abstract class Llamada
    {
        protected float _duracion;

        protected string _nroDestino;

        protected string _nroOrigen;

        public abstract float CostoLlamada
        {
            get; 
        }

        public string NroOrigen
        {
            get { return _nroOrigen; }
        }

        public float Duracion
        {
            get { return _duracion; }
        }

        public string NroDestino
        {
            get { return _nroDestino; }
        }

       
        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroOrigen = origen;
            this._nroDestino = destino;
        }

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Duracion: " + this.Duracion);
            sb.AppendLine("Origen: " + this.NroOrigen);
            sb.AppendLine("Destino: " + this._nroDestino);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {
            int auxRet = 0;

            if (uno._duracion > dos._duracion)
                auxRet = 1;

            if (uno._duracion < dos._duracion)
                auxRet = -1;

            return auxRet;

        }

        public static bool operator == (Llamada a,Llamada b)
        {
            return (a.NroDestino == b.NroDestino && a.NroOrigen == b.NroOrigen);
           
        }

        public static bool operator !=(Llamada a, Llamada b)
        {
            return (a == b) ? false : true;
        }

        public override bool Equals(object obj)
        {

            if(obj is Llamada)
            {
                return (this == (Llamada)obj);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
