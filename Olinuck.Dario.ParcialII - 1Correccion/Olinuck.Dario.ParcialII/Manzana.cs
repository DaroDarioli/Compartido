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
    public class Manzana : Fruta, ISerializable
    {
        public string _distribuidora;

        private string _rutaArchivo;
        public string RutaArchivo
        {
            set { this._rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); }
            get { return this._rutaArchivo; }

        }

        public string Tipo
        {
            get { return "Platano"; }
        }

        public override bool TieneCarozo
        {
            get { return true; }
        }


        public Manzana():base() { }
        public Manzana(float peso, ConsoleColor color, string distribuidora)
            : base(peso, color)
        {
            this._distribuidora = distribuidora;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "Distribuidora: " + this._distribuidora;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public bool SerializarXML()
        {
           
            try
            {
                XmlSerializer xm = new XmlSerializer(typeof(Manzana));
                XmlTextWriter w = new XmlTextWriter(this._rutaArchivo, Encoding.UTF8);
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
            Manzana m = new Manzana();
            try
            {
                XmlSerializer xm = new XmlSerializer(typeof(Manzana));
                XmlTextReader w = new XmlTextReader("E:\\ListaPersonaXML.xml");
                m = (Manzana)xm.Deserialize(w);
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
