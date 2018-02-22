using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public sealed class DerivadaUno : Base
    {
        protected int _revision;

        public override string VersionFull
        {
            get
            {
                return this.MostrarVersion();
            }
        }

        public DerivadaUno(int vversion, int vsubversion, int vrevision) : base(vversion, vsubversion)
        {
            this._revision = vrevision;
        }

        public override string MostrarVersion()
        {
            return base.MostrarVersion() + this._revision;
        }
    }
}
