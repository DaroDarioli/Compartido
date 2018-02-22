using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void EsImpar(Object o, EventArgs e);

    public class Galpon
    {
        List<Deposito<Producto>> lista = new List<Deposito<Producto>>();
        public int cantidad;

        public EsImpar impar;

        public EventArgs e = new EventArgs();
       
        public bool Valida2
        {
            

            get
            {
                if ((this.cantidad % 2) == 0)
                {
                    return true;
                }
                else if (this.cantidad % 2 == 1)
                {

                    this.impar(this.cantidad,e);
                    return false;
                }
                else
                {
                    throw new ArgumentException("ES cero!!");

                }
            }
        }



        public int Cantidad
        {
            set
            {
                if(!ReferenceEquals(this.cantidad,null))
                {
                    throw new YaAsignadaException();
                }
                else
                {
                    this.cantidad = value;
                }

            }
        }

        public bool Valida
        {
            get
            {
                if ((this.cantidad % 2) == 0)
                {
                    return true;
                }
                else if(this.cantidad % 2 == 1)
                {
                    
                        return false;
                } 
                else
                {
                    throw new EsCeroException();
                    
                }
            }
        }
    }
}
