using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal_20200874.Clases
{



    class CalculadoraPrestamo

    {

        private double Monto;
        private double Agno;

        private float cuota;

        public CalculadoraPrestamo (double monto1, double ag){
            Monto = monto1;
            Agno = ag;


         }

        public double Cuota(/*double montoP, double ag*/)
        {
           // double to = montoP;

            double montoPorciento = Agno / 100;

            double montoTotal = Monto * montoPorciento;

            double valor = montoTotal + Monto;


            return valor;
        }

        public double INTERES()

        {
            double montoPorciento1 = Agno / 100;
            double montoTotal1 = Monto * montoPorciento1;

            return montoTotal1;
        }


            
    }
}
