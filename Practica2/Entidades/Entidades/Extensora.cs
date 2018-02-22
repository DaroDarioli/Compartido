using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static  class Extensora
    {
        public static int EldelMedio(int a, int b,int c)
        {
            if(a == b || b == c || a == c)
            {
                throw new NoSePuedeException();
               
            }
            else
            {
                if (a < b && a > c || a > b && a < c)
                    return a;

                if (b < a && b > c || b > a && b < c)
                    return b;

                if (c < a && c > b || c > a && c < b)
                    return b;
            }
            return 0;
        }


        public static Queue<double> Invierte(Queue<double> fila)
        {

            Queue<double> d = new Queue<double>();

            Stack<double> milista = new Stack<double>();

            foreach(double w in fila)
            {
                milista.Push(w);                
            }
            milista.Reverse();

            foreach(double u in milista)
            {
                d.Enqueue(u);
            }


            return d;
        }


        public static Queue<double> Carga(Queue<double> fila)
        {
            for (int i = 1; i < 4; i++)
            {
                fila.Enqueue(i);
            }

            return fila;
        }



        public static void CuentaLetras(this String cadena)
        {
            char a = 'a';
            char A = 'A';
            int contador = 0;

            foreach(char b in cadena)
            {
                if (b == a || b == A)
                    contador++;
            }

            Console.WriteLine("Posee {0} letras a - A", contador);


        }
    }


    public class Class1
    {
    }
}
