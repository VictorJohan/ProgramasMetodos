using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramasMetodos.Clases.Secante
{
    public class Fx
    {
        MetodoSecante fx = new MetodoSecante();

        public double Fx0(string fn, double n)
        {
            string fun = fn;
            double vt = fx.ValorF(fun, n);
            return vt;
        }
    }
}
