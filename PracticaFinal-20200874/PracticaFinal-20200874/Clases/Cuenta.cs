using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal_20200874.Clases
{
    class Cuenta
    {
        private int NumeroDeCuenta;
        private float Balance;

        public Cuenta(float Bal)
        {
            Balance = Bal;
        }

        public Cuenta()
        {

        }

        public float getBalance()
        {
            return Balance;
        }
        public int getNumero()
        {
            Random numero = new Random();
            NumeroDeCuenta = numero.Next(100000, 500000);
            return NumeroDeCuenta;
        }

        public float getDeposito(float D){

            Balance = Balance + D;
            return Balance;

        }

        public float getRetiro(float R)
        {

            Balance = Balance - R;
            return Balance;

        }

       





    }
}
