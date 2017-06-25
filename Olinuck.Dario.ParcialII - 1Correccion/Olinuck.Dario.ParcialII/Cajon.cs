using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Olinuck.Dario.ParcialII
{
    [Serializable]
    public class Cajon<T> : ISerializable
    {

        private int _capacidad;

        private List<T> _frutas;

        private float _precioUnitario;


        public string _rutaArchivo;
        public string RutaArchivo
        {
            set { this._rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "ArchivoFrutas.xml";  }
            get { return this._rutaArchivo; }
        }



        public List<T> Frutas
        {
            get { return this._frutas; }
        }

        public float PrecioTotal
        {
            get
            {                
                int contador = 0;

                foreach(T c in this._frutas)
                {
                    contador++;
                                        
                }

                return contador * this._precioUnitario;            
            
            }
        }

        private Cajon()
        {
            this._frutas = new List<T>();
        }

        public Cajon(int capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(int capacidad, float precio)
            : this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public static Cajon<T> operator +(Cajon<T> c, T a)
        {

            if (c._frutas.Count >= c._capacidad)
            {
                throw new CajonLlenoException("el cajon esta lleno");
            }
            else
            {
               c._frutas.Add(a);
               
            }

            return c;

        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("Capacidad: " + this._capacidad);
            sb.AppendLine("Precio total: "+ this.PrecioTotal.ToString());
                      
            foreach (T a in this._frutas)
            {
                sb.AppendLine(a.ToString());
            }

            return sb.ToString();            
            
        }


        public bool SerializarXML()
        {
            string aux = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "ArchivoFrutas.xml";

            try
            {
                XmlSerializer xm = new XmlSerializer(typeof(Cajon<T>));
               // XmlTextWriter w = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8); ---> tira ruta nula, corregir
                XmlTextWriter w = new XmlTextWriter(aux, Encoding.UTF8);
                xm.Serialize(w, this);
                w.Close();
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;

            }

        }

        public bool DeserializarXML()
        {
            Cajon<T> cajon = new Cajon<T>();
            try
            {

                XmlSerializer xm = new XmlSerializer(typeof(Cajon<T>));
                XmlTextReader w = new XmlTextReader("E:\\ListaPersonaXML.xml");
                cajon = (Cajon<T>)xm.Deserialize(w);
                w.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
    }
}
