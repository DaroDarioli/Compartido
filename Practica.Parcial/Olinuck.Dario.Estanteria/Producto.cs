using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Estanteria
{
    public abstract class Producto
    {

    #region atributos 
        protected int _codigoBarra;

        protected EMarcaProducto _marca;

        protected float _precio;

        #endregion

        #region porpiedades
        public abstract float CalcularCostoDeProduccion
        {
            get;

        }
        public float Precio
        {
            get { return _precio; }
          
        }
        

        public EMarcaProducto Marca
        {
            get { return _marca; }
            
        }

        #endregion
        #region constructores
        public Producto(int codigoBarra, EMarcaProducto  marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        #endregion
        #region metodos
        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }


        public static explicit operator int(Producto p)
        {
            return p._codigoBarra;
        }
      
        public static implicit operator string(Producto p)
        {
            return p.MostrarProducto(p);
        }

        private string MostrarProducto(Producto p)
        {
            return "\nMARCA: " + this._marca + "\nCÓDIGO DE BARRAS: " + this._codigoBarra + "\nPRECIO: " + this._precio;
        }

        public static bool operator ==(Producto prodUno,EMarcaProducto marca)
        {
            return prodUno._marca == marca ? true : false;
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return prodUno == marca ? false : true; 
        }

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            return (prodUno._marca == prodDos._marca && prodUno._codigoBarra == prodDos._codigoBarra) ? true : false;
        }
        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return prodUno == prodDos ? false : true;
        }

        #endregion
        #region enumerados
        public enum EMarcaProducto { Favorita, Pitusas, Diversión, Naranjú, Swift };


        public enum ETipoProducto { Galletita, Gaseosa, Harina, Jugo, Todos }
        #endregion
    }


}
