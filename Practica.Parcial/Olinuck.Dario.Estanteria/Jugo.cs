using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Estanteria
{
    public class Jugo : Producto
    {
        protected ESaborJugo _sabor;

        protected static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get { 
                    double auxRet = base.Precio * 0.4;

                    return (float)auxRet; }
        }

        static Jugo()
        {
            Jugo.DeConsumo = true;
            
        }

        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESaborJugo sabor) : base (codigoBarra, marca, precio)
        {
            this._sabor = sabor;
        }

        public override string ToString()
        {
            return "MARCA: " + this._marca + "\nCÓDIGO DE BARRAS: " + this._codigoBarra + "\nPRECIO: " + this._precio + "\nSABOR: " + this._sabor;
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        public enum ESaborJugo { Pasable, Asqueroso}


    }

    
}
