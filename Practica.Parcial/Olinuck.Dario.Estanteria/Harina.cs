using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Estanteria
{
    public class Harina : Producto
    {
        private ETipoHarina _tipo;

        protected static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get
            {
                double auxRet = base.Precio * 0.60;

                return (float)auxRet;
            }
        }

        static Harina()
        {
            Harina.DeConsumo = false;

        }

        public Harina(int codigoBarra, float precio, EMarcaProducto marca, ETipoHarina tipo) : base (codigoBarra, marca, precio)
        {
            this._tipo = tipo;
        }

        public override string ToString()
        {
            return this.MostraHarina(this);
        }

        public override string Consumir()
        {
            return "Comestible";
        }

        private string MostraHarina(Harina  g)
        {

            return "MARCA: " + g._marca + "\nCÓDIGO DE BARRAS: " + g._codigoBarra + "\nPRECIO: " + g._precio + "\nTipo: " + g._tipo;
        }

        public enum ETipoHarina { CuatroCeros, Integral}
    }

   
}
