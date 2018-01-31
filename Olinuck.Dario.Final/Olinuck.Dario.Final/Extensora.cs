using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olinuck.Dario.Final
{
    public static class Extensora
    {
        public static string QuitarA(this string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c != 'A' && c != 'a')
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
