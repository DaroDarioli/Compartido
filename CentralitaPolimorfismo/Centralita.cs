using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;

        protected String _razonSocial;

        #region Propiedades


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

        #endregion


        #region Constructores

        private Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        #endregion
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


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razón social: " + this._razonSocial);
            sb.AppendLine("Ganancia: " + GananciaTotal.ToString());
            sb.AppendLine("\n-------Listado de llamadas-------\n");


            foreach (Llamada l in this._listaDeLlamadas)
            {
                sb.AppendLine(l.ToString());
            }

            return sb.ToString();

        }


        private void AgregarLlamada(Llamada unaLlamada)
        {
            this._listaDeLlamadas.Add(unaLlamada);
        }

        public static bool operator == (Centralita central, Llamada unaLlamada)
        {
            foreach(Llamada l in central._listaDeLlamadas)
            {
                if (l == unaLlamada)
                    return true;
            }

            return false;
        }


        public static bool operator !=(Centralita central, Llamada unaLlamada)
        {
            return (central == unaLlamada)? false : true;
        }

        public static Centralita operator + (Centralita central, Llamada unaLlamada)
        {
            if (central == unaLlamada)
            {
                Console.WriteLine("La llamada ya está cargada!!!");
            }
            else
            {
                central.AgregarLlamada(unaLlamada);
            }
            return central;                
            
        }






        //public void Mostrar()
        //{
        //    Console.WriteLine("Razón social: " + this._razonSocial);
        //    Console.WriteLine("Ganancia: " + GananciaTotal.ToString());
        //    Console.WriteLine("\n-------Listado de llamadas-------\n");


        //    foreach (Llamada l in this._listaDeLlamadas)
        //    {
        //        l.Mostrar();
        //    }

        //}

        public void OrdenarLlamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

            Console.WriteLine("\n--------Listado ordenado por duración--------\n");

            this.ToString();
        }

    }

}
