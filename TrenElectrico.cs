using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace PracticaJulio2
{
    [Serializable]
    public class TrenElectrico : Tren, IArchivos, ITexto<string>
    {

        private List<Pasajero> _pasajeros;

        public override string Destino
        {
            get { return base._destino; }

            set { base._destino = value; }
        }

        public override int CantidadPasajeros
        {
            get { return base._cantidadMaxPasajeros;  }

            set { base._cantidadMaxPasajeros = value; }
        }

        public override bool MotorEncendido
        {
            get { return base._motorEncendido; }
            set { base._motorEncendido = value; }
        }



        public override List<Pasajero> Pasajeros
        {
            get
            {
                return this._pasajeros; 
                    
            }
        }

        string ITexto<string>.Direccion
        {
            get;

            set;
            
        }

        #region Constructores

        public TrenElectrico() : base()
        {
            this._pasajeros = new List<Pasajero>();
        }

        public TrenElectrico(int cantidadPasajeros, string destino):base(cantidadPasajeros, destino)
        {
            this._pasajeros = new List<Pasajero>(5);
        }

        #endregion
        public override void Ingresar(Pasajero p)
        {

            if (this._cantidadMaxPasajeros > this._pasajeros.Count)
            {
                this._pasajeros.Add(p);
            }
            else
            {
                throw new PasajerosOverFlowException("sin lugar para pax");
            }
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cantidad maxima de pasajeros: " + this._cantidadMaxPasajeros.ToString());
            sb.AppendLine("Destino: " + this._destino);

            sb.AppendLine("\nListado Pasajeros\n");
            foreach (Pasajero p in this.Pasajeros)
            {
                sb.AppendLine(p.ToString());
            }


            return sb.ToString();

        }


        public bool ISerializar()
        {
            try
            {
                XmlSerializer xm = new XmlSerializer(typeof(List<Pasajero>));
                XmlTextWriter w = new XmlTextWriter("Pasaje2.xml", Encoding.UTF8);

                xm.Serialize(w, this._pasajeros);
                w.Close();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }
        }

        public bool IDeserializar()
        {
            List<Pasajero> lista = new List<Pasajero>();
            try
            {

                XmlSerializer xm = new XmlSerializer(typeof(List<Pasajero>));
                XmlTextReader w = new XmlTextReader("Pasaje.xml");
                lista = (List<Pasajero>)xm.Deserialize(w);
                w.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        void ITexto<string>.Facturar()
        {
            string objeto = typeof(TrenElectrico).Name + "\n" + "Fecha: " + DateTime.Now.ToString();
            try
            {
                StreamWriter sw = new StreamWriter(((ITexto<string>)this).Direccion, true);
                sw.WriteLine(objeto);
                sw.WriteLine("\n*****Detalles de pasaje grupal*****\n");
                sw.WriteLine(this.ToString());
                sw.Close();

            }
            catch
            {
                throw new MiExcepcion("No se pudo facturar");
            }
        }


        bool ITexto<string>.Leer(out List<string> datos)
        {
            StringBuilder sb = new StringBuilder();
            datos = new List<string>();
            bool allRight = true;
            string linea;

            try
            {
                using (StreamReader sr = new StreamReader(((ITexto<string>)this).Direccion))
                { 
                    while ((linea = sr.ReadLine()) != null)
                    {                       
                        datos.Add(linea);
                    }
                }
            }
            catch
            {
                allRight = false;
            }

            return allRight;

        }      
         
    }
}
