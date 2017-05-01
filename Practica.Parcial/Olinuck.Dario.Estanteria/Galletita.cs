using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Estanteria
{
    public class Galletita : Producto
    {
        protected float _peso;

        protected static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get
            {
                double auxRet = base.Precio * 0.33;

                return (float)auxRet;
            }
        }

        static Galletita()
        {
            Galletita.DeConsumo = true;

        }

        public Galletita(int codigoBarra, float precio, EMarcaProducto marca, float peso) : base (codigoBarra, marca, precio)
        {
            this._peso = peso;
        }

        public override string ToString()
        {
            return this.MostrarGalletita(this);
        }

        public override string Consumir()
        {
            return "Comestible";
        }

        private string MostrarGalletita(Galletita g)
        {
            
            return "MARCA: " + g._marca + "\nCÓDIGO DE BARRAS: " + g._codigoBarra + "\nPRECIO: " + g._precio + "\nPeso: " + g._peso;
        }




    }

   
}
