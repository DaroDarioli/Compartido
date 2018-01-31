using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Olinuck.Dario.Final
{
    [Serializable]
    public class Perro : Mascota, ISonido<Perro>
    {
        #region Propiedades

        public new Perro Animal
        {
            get { return this; }
        }

        public event DelegadoFinLadrido handler;            
        
        #endregion

        #region Constructores

        public Perro(string nombre) : base(nombre) {

            this.handler += Form1.FinLadrido;            
        }

        #endregion

        #region Métodos

        public override string EmitirSonido()
        {
            var thread = new Thread(new ThreadStart(this.handler));
            thread.Start();                        
            return "Ladrar";
        }

        #endregion
    }
}
