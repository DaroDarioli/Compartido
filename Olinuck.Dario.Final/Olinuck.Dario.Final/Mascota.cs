
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Final
{
    [Serializable]
    public class Mascota:ISonido<Mascota>
    {
        #region Atributos

        static int patas;
        public string _nombre;

        #endregion

        #region Propiedades

        public Mascota Animal
        {
            get { return new Mascota(); }
        }

        public static int Patas
        {
            get { return patas; }
        }

        public string Nombre
        {
            get { return this._nombre; }
        }

        #endregion

        //verificar herencia constructores
        #region Constructores  

        static Mascota()
        {
            patas = 8;
        }

        public Mascota() { }

        public Mascota(string nombre)
        {
            this._nombre = nombre;
        }

       
        #endregion

        public virtual string EmitirSonido()
        {
            throw new SinSonidoException("No emite sonido");
        }

    }
}
