using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Estanteria
{
    public class Gaseosa : Producto
    {
        protected float _litros;

        protected static bool DeConsumo;

        public override float CalcularCostoDeProduccion
        {
            get
            {
                double auxRet = base.Precio * 0.44;

                return (float)auxRet;
            }
        }

        static Gaseosa()
        {
            Gaseosa.DeConsumo = true;

        }
        public Gaseosa(Producto p, float litros) : base ((int)p, p.Marca,p.Precio)
        {      
            this._litros = litros;
           
        }


        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros) : base (codigoBarra, marca, precio)
        {
            this._litros = litros;
        }

        public override string ToString()
        {
            return this.MostrarGaseosa(this);
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        private string MostrarGaseosa(Gaseosa g)
        {

            return "MARCA: " + g._marca + "\nCÓDIGO DE BARRAS: " + g._codigoBarra + "\nPRECIO: " + g._precio + "\nLitros: " + g._litros;
        }


    }
}
