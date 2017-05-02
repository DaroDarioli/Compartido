using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lavadero
{
    public class Lavadero1
    {
        private List<Vehiculo> _vehiculos;

        private float _precioAuto, _precioMoto, _precioCamion;

        public List<Vehiculo> Lista
        {
            get { return this._vehiculos; }
            
        }


        public List<Vehiculo> GetLista()
        {
            return this._vehiculos;
        }



        public string Mostrar
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("*** LavaRap  ***");
                sb.AppendLine("Precio Motocicleta: " + this._precioMoto);
                sb.AppendLine("Precio Auto: " + this._precioAuto);
                sb.AppendLine("Precio Camión: " + this._precioCamion);
                sb.AppendLine("\t\t\tVehículos\n\n");

                foreach(Vehiculo v in _vehiculos)
                {
                    if (v is Auto) sb.AppendLine(((Auto)v).MostraAuto());

                    if (v is Moto) sb.AppendLine(((Moto)v).MostrarMoto());

                    if (v is Camion) sb.AppendLine(((Camion)v).MostarCamion());
                         
                }
                return sb.ToString();
            }
        }

        
        public double MostrarTotalFacturado(EVehiculos tipo)
        {
            double auxRet = 0;

            foreach (Vehiculo v in _vehiculos)
            {
                if ((tipo == EVehiculos.Auto) && (v is Auto))
                    auxRet += this._precioAuto;

                if ((tipo == EVehiculos.Moto) && (v is Moto))
                    auxRet += this._precioMoto;

                if ((tipo == EVehiculos.Camion) &&(v is Camion))
                    auxRet += this._precioCamion;
            }
            return auxRet;
        }

        public double MostrarTotalFacturado()
        {
            double auxRet = 0;

            foreach(Vehiculo v in _vehiculos)
            {
                if (v is Auto)
                    auxRet += this._precioAuto;

                if (v is Moto)
                    auxRet += this._precioMoto;

                if (v is Camion)
                    auxRet += this._precioCamion;
            }


            return auxRet;
        }


        private Lavadero1()
        {
            this._vehiculos = new List<Vehiculo>();
        }
         
        public Lavadero1(float precioAuto, float precioMoto, float precioCamion) : this ()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        public static bool operator == (Lavadero1 L, Vehiculo V)
        {
            return (L._vehiculos.Contains(V))? true : false;
        }


        public static bool operator !=(Lavadero1 L, Vehiculo V)
        {
            return (L ==V) ? false : true;
        }

        public static Lavadero1 operator + (Lavadero1 L, Vehiculo V)
        {
            if (L == V)
            {
                Console.WriteLine("El artículo ya se encuentra cargado!!");
               
            }
            else
                L._vehiculos.Add(V);

            return L;

        }

        public static Lavadero1 operator -(Lavadero1 L, Vehiculo V)
        {
            if (L != V)
            {
                Console.WriteLine("El artículo no se encuentra en la lista!!");
            }
            else
                L._vehiculos.Remove(V);
            

            return L;
        }

        public static int OrdenarVehiculosPorPatente(Vehiculo A,Vehiculo B)
        {            
            return string.Compare(B.Patente, A.Patente);
        }

        public static int OrdenarVehiculosPorMArca(Vehiculo A, Vehiculo B)
        {
            return string.Compare(A.Marca.ToString(),B.Marca.ToString());
        }

        public enum EVehiculos {  Auto, Camion, Moto}
        
    }

    
}
