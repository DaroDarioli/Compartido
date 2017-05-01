using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Parcial37
{
    class Banco
    {
        private DateTime _date;

        private List<CuentaCorriente> _listaCuentas;

        private string _razonSocial;

        public Banco(string razonsocial, DateTime date)
        {
            this._date = date;
            this._razonSocial = razonsocial;
            this._listaCuentas = new List<CuentaCorriente>();
        }

        public void MostrarBanco()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Apertura: ");
            sb.AppendLine(this._date.ToString());
            sb.Append("Empresa: ");
            sb.AppendLine(this._razonSocial);
            sb.AppendLine("\nCuetnas: \n");

            foreach (CuentaCorriente c in _listaCuentas)
            {
                sb.AppendLine("Saldo: " + (double)c);
                sb.AppendLine(c.Duenio.Mostrar(c.Duenio));
            }
                


        }

        public static Banco operator +(Banco BB, CuentaCorriente CC)
        {
            if (BB._listaCuentas.Contains(CC))
                Console.WriteLine("Ya existe una cuenta corriente para el usuario");

            else
            {
                BB._listaCuentas.Add(CC);
                Console.WriteLine("Se ha agregado una cuenta corriente");
            }
           

            return BB;
        }


        public static Banco operator -(Banco BB, CuentaCorriente CC)
        {
            BB._listaCuentas.Remove(CC);
            return BB;
        }

    }
}