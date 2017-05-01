using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Parcial37
{
    class CuentaCorriente
    {
        private Usuario _dueño;

        private int _numeroDeCuenta;

        private double _saldo;

        public Usuario Duenio
        {
            get { return _dueño; }            
        }             

        public double Saldo
        {
            set { _saldo = value; }
            get { return _saldo; }
        }

        public CuentaCorriente(string nombre, string apellido, int dni, int cuenta,double saldo)
        {
            this._dueño = new Usuario(nombre, apellido, dni);
            this._numeroDeCuenta = cuenta;
            this._saldo = saldo;
        }

        public CuentaCorriente(Usuario unDueño, int cuenta, double saldo)
        {
            this._dueño = unDueño;
            this._numeroDeCuenta = cuenta;
            this._saldo = saldo;
        }

        public static explicit operator double(CuentaCorriente CC)
        {
            double retAux = CC._saldo;

            return retAux;
        }

        public static implicit operator CuentaCorriente(Usuario U)
        {
            CuentaCorriente cuenta = new CuentaCorriente(U, 0, 0);

            return cuenta;
        }

        public static bool operator == (CuentaCorriente AA,CuentaCorriente BB)
        {
            return AA._dueño.DNI == BB._dueño.DNI ? true : false;
        }

        public static bool operator !=(CuentaCorriente AA, CuentaCorriente BB)
        {
            return AA == BB? false : true;
        }

    }
}
