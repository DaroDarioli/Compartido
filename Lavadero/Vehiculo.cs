using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public abstract class Vehiculo
    {
        private string _patente;

        private Byte _cantRuedas;

        private EMarcas _marca;

        public EMarcas Marca
        {
            get { return _marca; }
           
        }


        public string Patente
        {
            get { return _patente; }
           
        }

        public Vehiculo(string patente, Byte ruedas, EMarcas marca)
        {
            this._patente = patente;
            this._marca = marca;
            this._cantRuedas = ruedas;
        }

        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Patente: " + this._patente);
            sb.AppendLine("Cantidad de ruedas: " + this._cantRuedas);
            sb.AppendLine("Marca: " + this._marca);

            return sb.ToString();
                
        }

        public static bool operator == (Vehiculo AA,Vehiculo BB)
        {
            return (AA._marca == BB._marca && AA._patente == BB._patente)? true : false;
        }

        public static bool operator !=(Vehiculo AA, Vehiculo BB)
        {
            return (AA == BB) ? false : true;
        }


    }


    public enum EMarcas {  Honda, Ford, Zanella, Scania,Iveco, Fiat}
}
