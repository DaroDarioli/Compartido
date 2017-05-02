using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibaryOperarios;

namespace Olinuck.Dario.Ejer39
{
    public class Fabrica
    {
        private Operario[] _operarios;

        private string _razonSocial;

        public Fabrica()
        {
            this._operarios = new Operario[5];
        }

        public Fabrica(string razonSocial): this ()
        {
            this._razonSocial = razonSocial;
        }

        public string Mostrar()
        {
            return this.MostrarOperarios();
        }
         
        
        public static void MostrarCosto(Fabrica fab)
        {
            Console.WriteLine("Costo Total: {0}", fab.RetornarCostos());

        }
            
        private string MostrarOperarios()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nEmpresa: " + this._razonSocial + "\nOperarios: \n\n");            

            foreach (Operario o in this._operarios)
                   sb.Append(Operario.Mostar(o));
            

            return sb.ToString();
        }
        
        private int ObtenerIndice()
        {
            int auxIndex = -1;

            for (int i = 0; i < this._operarios.Length; i++)
            {
                if (this._operarios[i] == null)
                {
                    auxIndex = i;
                    break;
                }
            }

            return auxIndex;
        }   
        
        private int ObtenerIndiceOperario(Operario ope)
        {
            int auxIndex = -1;

            for (int i = 0; i < this._operarios.Length; i++)
            {
                if (this._operarios[i] == ope)
                {
                    auxIndex = i;
                    break;
                }
            }

            return auxIndex;
        } 

        public static bool operator == (Fabrica fbr, Operario ope)
        {
            foreach(Operario o in fbr._operarios) 
            {
                if (o == ope)
                    return true;
            }

            return false;
        }

        public static bool operator !=(Fabrica fbr, Operario ope)
        {
          return fbr == ope ? false : true;
        }
        public static Fabrica operator +(Fabrica fbr, Operario ope)
        {
            int auxIndex = fbr.ObtenerIndice();

            if (fbr.ObtenerIndice() == -1)
                Console.WriteLine("No hay más cupo!!!");

            else
                fbr._operarios[auxIndex] = ope;

            return fbr;
        }

        public static Fabrica operator -(Fabrica fbr, Operario ope)
        {
            if (fbr == ope)
               fbr._operarios[ fbr.ObtenerIndiceOperario(ope)] = null;

            return fbr;
        }

        private float RetornarCostos()
        {
            float acumulador = 0;

            foreach (Operario ope in this._operarios)
            {

                if (ope == null)
                    continue;

                acumulador += ope.getSalario();
            }

            return acumulador;
        }
    }
}
