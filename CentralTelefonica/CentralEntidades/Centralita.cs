using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralEntidades
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;

        protected String _razonSocial;


        public float GananciaPorLocal
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial); }

        }

        public float GananciaTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas); }

        }

        public List<Llamada> LLamadas
        {
            get { return this._listaDeLlamadas; }
        }


        private Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }


        private float CalcularGanancia(TipoLlamada tipo)
        {
            float auxRet = 0;

            foreach (Llamada l in this._listaDeLlamadas)
            {

                if ((l is Local) && ((tipo == TipoLlamada.Local || (tipo == TipoLlamada.Todas))))
                {
                    auxRet += ((Local)l).CostoLlamada;
                }


                if ((l is Provincial) && ((tipo == TipoLlamada.Provincial || (tipo == TipoLlamada.Todas))))
                {
                    auxRet += ((Provincial)l).CostoLlamada;
                }


            }
            return auxRet;
        }

        public void Mostrar()
        {
            Console.WriteLine("Razón social: " + this._razonSocial);
            Console.WriteLine("Ganancia: " + GananciaTotal.ToString());
            Console.WriteLine("\n-------Listado de llamadas-------\n");


            foreach (Llamada l in this._listaDeLlamadas)
            {
                l.Mostrar();
            }

        }

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

            Console.WriteLine("\n--------Listado ordenado por duración--------\n");

            Mostrar();
        }

    }

}
