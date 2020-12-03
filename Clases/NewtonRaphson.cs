using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramasMetodos.Clases
{
    public class NewtonRaphson
    {
        private static Double f(double x)
        {
            return (x*x) + (2*x) + 1;
        }

        private static Double g(double x)
        {
            return (2 * x) + 2;
        }

        public static String NewtonR(double x_0, double precision)
        {
            double x = x_0;

            while(f(x) > precision)
            {
                x = x - f(x) / g(x);
                if (f(x) <= precision)
                    return x + "";
            }

            return "No se hallo una raiz con la precision deseada.";
        }
    }
}
