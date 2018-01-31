using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            string pais = "Bananas y mandarinas";

            string retorno = Extensora.ProcesoString(pais);

            Console.WriteLine(retorno);

            Console.ReadLine();
        }
                
    }

    public static class Extensora
    {

        public static string ProcesoString(this string s)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in s)
            {
                if (c != 'A' && c !='a')
                    sb.Append(c);

            }
            return sb.ToString();
        }
    }
}
