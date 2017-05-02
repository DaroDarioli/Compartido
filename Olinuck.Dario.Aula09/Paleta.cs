using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Aula09
{
    public class Paleta
    {
        #region Atributos 

        private List <Tempera> _temperas;

        private int _cantMaxColores;

        #endregion

        #region Propiedades

        public Tempera this[int indice]
        {
            get { return this._temperas[indice];}

            set
            {
                if (indice >= 0 && indice < this._temperas.Count)
                    this._temperas[indice] = value;

                else if (indice == this._temperas.Count)
                    this._temperas.Add(value);
            }
        }

        #endregion

        private Paleta() :this (5)
        {
            //this._temperas = new Tempera[5];
            //this._cantMaxColores = 5;
        }

        public Paleta(int cant) 
        {
            this._temperas = new List<Tempera>();
            this._cantMaxColores = cant;
        }


        public static bool operator ==(Paleta PP, Tempera TT)
        {
            
            if(PP._temperas.Contains(TT))
                return true;
            else
                return false;          
        
        }
        

        public static bool operator !=(Paleta p, Tempera t)
        {

            if (p._temperas.Contains(t))
                return false;

            else
                return true;

        }

        public static Paleta operator +(Paleta PP, Tempera TT)
        {

            if (PP == TT)
            {
                Console.WriteLine("\nEl elemento ya fue cargado\n");
            }                
            else
            {
                if(PP._temperas.Count() >= PP._cantMaxColores)
                        Console.WriteLine("\nNo se puede agregar más elementos\n");
                else
                    PP._temperas.Add(TT);

            }           
            return PP;
        }
            


       public static Paleta operator -(Paleta PP, Tempera TT)
       {
           if (PP == TT)
               Console.WriteLine("\nEl elemento no existe en la lista\n");

           else
               PP._temperas.Remove(TT);

           return PP;
       }

      
       public string Mostrar()
       {
            

            StringBuilder sb = new StringBuilder();

            foreach (Tempera t in this._temperas)
            {
               Console.WriteLine(Tempera.Mostrar(t));
               
            }
             string auxRet = sb.ToString() + "Cantidad: " + this._temperas.Count();

            return auxRet;
       }     

        public static explicit operator string(Paleta p)
        {
           return p.Mostrar();

        }


       public static implicit operator int(Paleta p)
       {
           return p._cantMaxColores;
       }







      /*

       * opeartor + (paleta paleta)paleta
       * si son iguales colores retorna una nueva con suma cantidades


       */



    }
}
