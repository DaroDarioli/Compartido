using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Estanteria
{
    public class Estante
    {
        protected sbyte _capacidad;

        protected List<Producto> _productos;
        public float ValorEstanteTotal
        {
            get
            {
                float auxRet = 0;

                foreach (Producto p in this._productos)
                {
                    auxRet += p.Precio;
                }
                return auxRet;
            }
        }

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public Estante(sbyte capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }


        public float GetValorEstante(Producto.ETipoProducto tipo)
        {
            float auxRet = 0;

            foreach (Producto p in this._productos)
            {
                if ((p is Galletita) && (tipo == Producto.ETipoProducto.Galletita))
                    auxRet += p.Precio;

                if ((p is Gaseosa) && (tipo == Producto.ETipoProducto.Gaseosa))
                    auxRet += p.Precio;

                if ((p is Harina) && (tipo == Producto.ETipoProducto.Harina))
                    auxRet += p.Precio;

                if ((p is Jugo) && (tipo == Producto.ETipoProducto.Jugo))
                    auxRet += p.Precio;

                if (tipo == Producto.ETipoProducto.Todos)
                    auxRet += p.Precio;
            }
            return auxRet;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CAPACIDAD: " + e._capacidad);

            foreach (Producto p in e._productos)
            {

                sb.AppendLine(p.ToString());
                sb.AppendLine("");
            }

            return sb.ToString();

        }

        public static bool operator ==(Estante e, Producto prod)
        {
            foreach (Producto p in e._productos)
            {
                if ((prod.Marca == p.Marca) && (prod.Precio == p.Precio) && ((int)prod == (int)p))
                { 
                    return true;
                }
            }
          
                return false;
        }

        public static bool operator !=(Estante e, Producto prod)
        {
            if (e == prod)
                return false;

            else
                return true;
        }

        public static bool operator +(Estante e, Producto prod)
        {          

            if (e == prod)
            {
                return false;
            }

            else
            {
                e._productos.Add(prod);
                return true;
            }        
                      
        } 

        public static Estante operator -(Estante e, Producto prod)
        {                      
            Estante estanteAuxiliar = new Estante();

            foreach (Producto p in e._productos)
            {
                if (p != prod)
                {
                    estanteAuxiliar._productos.Add(p);
                }
            }
            return estanteAuxiliar;            
        }

        public static Estante operator -(Estante e, Producto.ETipoProducto tipo)
        {
                   
            Estante estanteAuxiliar = new Estante();

            foreach (Producto p in e._productos)
            {
                
                if ((p is Galletita) && (tipo != Producto.ETipoProducto.Galletita))
                {
                    estanteAuxiliar._productos.Add(p);
                }
                if ((p is Gaseosa) && (tipo != Producto.ETipoProducto.Gaseosa))
                {
                    estanteAuxiliar._productos.Add(p);
                }
                if ((p is Harina) && (tipo != Producto.ETipoProducto.Harina))
                {
                    estanteAuxiliar._productos.Add(p);
                }
                if ((p is Jugo) && (tipo != Producto.ETipoProducto.Jugo))
                {
                    estanteAuxiliar._productos.Add(p);
                }
                if (tipo == Producto.ETipoProducto.Todos)
                {
                    estanteAuxiliar._productos.Clear();
                }

            }

            return estanteAuxiliar;           
        }       
        
    }
}
