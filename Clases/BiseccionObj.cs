using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramasMetodos.Clases
{
    public class BiseccionObj
    {
        public int Iteracion { get; set; }
        public double Xa { get; set; }
        public double Xb { get; set; }
        public double Xr { get; set; }
        public double Fxa { get; set; }
        public double Fxr { get; set; }
        public double FxaFxr { get; set; }
        public double Ea { get; set; }
        public double Et { get; set; }
    }
}
