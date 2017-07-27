using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Aula17
{
    public class Deposito<T>
    {

        private int _capacidadMaxima;

        private List<T> _lista;

        public T atr;      

        public Deposito(int capacidad)
        {
            this.atr = default(T);
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }

        public bool Agregar(T a)
        {

            if (this._lista.Count >= this._capacidadMaxima)
            {
                return false;
            }
            else
            {
                this._lista.Add(a);
                return true;
            }  

        }

        public static bool operator +(Deposito<T> d, T a)
        {
            return (d.Agregar(a))? true : false;
        }

        private int GetIndice(T a)
        {
            int indice = -1;
            int contador = 0;

            foreach (T b in this._lista)
            {
                if (a.Equals(b))
                {
                    indice = contador;
                    break;
                }
                contador++;
            }
            return indice;
        }

        public static bool operator -(Deposito<T> d, T a)
        {
            return (d.Remover(a)) ? true : false;                 
        
        }

        public bool Remover(T a)
        {
            int x = this.GetIndice(a);
            if (x != -1)
            {
                this._lista.RemoveAt(x);
                return true;
            }
            return false; 

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Listado de: "+ typeof(T).Name);


            sb.AppendLine("Capacidad maxima: "+this._capacidadMaxima);

            foreach(T a in this._lista)
            {
               sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }


        public override bool Equals(object obj)
        {
 	         return base.Equals(obj);
        }
     
    }
}
