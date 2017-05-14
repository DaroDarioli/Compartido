using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralEntidades
{
    public class Llamada
    {
        protected float _duracion;

        protected string _nroDestino;

        protected string _nroOrigen;

        public string NroOrigen
        {
            get { return _nroOrigen; }
        }

        public string NroDestino
        {
            get { return _nroDestino; }
        }

        public float Duracion
        {
            get { return _duracion; }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._duracion = duracion;
            this._nroOrigen = origen;
            this._nroDestino = destino;
        }

        public virtual void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Duracion: " + this.Duracion);
            sb.AppendLine("Origen: " + this.NroOrigen);
            sb.AppendLine("Destino: " + this._nroDestino);

            Console.Write(sb.ToString());
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



    }
}
