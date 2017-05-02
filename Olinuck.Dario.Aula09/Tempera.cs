using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Aula09
{
    public class Tempera
    {
          private ConsoleColor _color;

          private string _marca;

          private int _cantidad;      


          public Tempera(ConsoleColor color, string marca, int cantidad)
          {
              this._color = color;
              this._marca = marca;
              this._cantidad = cantidad;
          }

          public Tempera()
          {
           
          } 



          private string Mostrar()
          {
            return "Color: " + this._color + " Marca: " + this._marca + " Cantidad: " + this._cantidad;
          }
             

         public static string Mostrar(Tempera temp)
         {
            return temp.Mostrar();           
         }
         
         public static bool operator == (Tempera t1, Tempera t2)
         {
              return t1._marca == t2._marca && t1._color == t2._color  ? true : false;
         }

         public static bool operator !=(Tempera t1, Tempera t2)
         {
             return t1 == t2? false : true;
         }

         public static implicit operator int(Tempera t)
         {
            return t._cantidad;
         }

         public static explicit operator string(Tempera t)
         {
            return t.Mostrar();
         }

         public static Tempera operator + (Tempera t1,Tempera t2)
         {             

             if(t1 == t2)
             {
                  t1 +=t2._cantidad;
                  t2 +=t1._cantidad;                
             }
             
             return t1;

         }

          public static Tempera operator + (Tempera t1,int auxCantidad)
          {      
                       
                  t1._cantidad +=auxCantidad;                          
                          
             return t1;

         }

          public static implicit operator Tempera(string marca)
          {

              return new Tempera(ConsoleColor.Blue, marca, 8);
          }

          
          public static bool  operator == (Tempera t, string marca)
          {
             return t._marca == marca ? true : false;
               
          }

        public static bool operator !=(Tempera t, string marca)
        {
            return t._marca == marca ? false  : true;

        }





    }
}



//+ (tempera, tempera) : tempera
//-> si temperas iguales, acumula cantidad


//+ (tempera, int) : tempera
//-> acumula cantidad 
//}
