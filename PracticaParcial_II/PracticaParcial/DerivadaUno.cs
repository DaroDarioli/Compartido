using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    public sealed class DerivadaUno : Base
    {

        private static int revision;

        static DerivadaUno(){
            revision = 1;

        }

        public DerivadaUno(int version, int subversion, int rev): base(version, subversion)
        {
            revision = rev;
            
        }

        public override string VersionFull
        {
            get
            {
                return this.MostrarVersion();
            }
        }

        protected override string MostrarVersion()
        {
            return base.MostrarVersion() + revision.ToString();
        }

       
    }
}
