using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPP
{
    public class DerivadaDos : Base
    {
       
        public DerivadaDos() { }

        public DerivadaDos(int vversion, int vsubversion):base(vversion,vsubversion)
        {
            Base._subversion = vsubversion;
            Base._version = vversion;
        }

        public override string VersionFull
        {
            get
            {
                return this.MostrarVersion();
            }
        }

        public override string MostrarVersion()
        {
            return string.Format("{0}.{1}", _version, _subversion);
        }
    }
}
