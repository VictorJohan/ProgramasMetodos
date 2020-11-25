using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProgramasMetodos.Clases
{
    public class MetodosNumericos
    {
        //Determina el error
        public static double Error(double valorV, double valorA)
        {
            return valorV - valorA;
        }

        //Determina el error relativo porcentual
        public static double ErrorRelativoPorcentual(double valorV, double valorA)
        {
            double resultado;
            resultado = (Error(valorV, valorA) / valorV) * 100;

            return resultado;
        }

        public static List<BiseccionObj> Biseccion(BiseccionObj biseccion)
        {
            List<BiseccionObj> lista = new List<BiseccionObj>();
            BiseccionObj aux;
            int iteracion = biseccion.Iteracion;
            
            for (int i = 1; i <= iteracion; i++)
            {
                biseccion.Xr = (biseccion.Xa + biseccion.Xb) / 2;
                biseccion.Fxa = Math.Round(Math.Pow(biseccion.Xa, 10) - 1, 6);
                biseccion.Fxr = Math.Round(Math.Pow(biseccion.Xr, 10) - 1, 6);
                biseccion.FxaFxr = biseccion.Fxa * biseccion.Fxr;
                biseccion.Et = Math.Round(Math.Abs((1 - biseccion.Xr) * 100), 2);
                biseccion.Iteracion = i;

                aux = biseccion;
                
                lista.Add(aux);
                biseccion = new BiseccionObj();
                if (lista.Count > 1)
                {
                    lista[lista.Count - 1].Ea = ErrorAproximado(lista);
                }
                biseccion.FxaFxr = aux.FxaFxr;

                

                if (biseccion.FxaFxr < 0)
                    biseccion.Xa = aux.Xa;
                else
                    biseccion.Xa = aux.Xr;

                if (biseccion.FxaFxr > 0)
                    biseccion.Xb = aux.Xb;
                else
                    biseccion.Xb = aux.Xr;
            }

            return lista;
        }

        private static double ErrorAproximado(List<BiseccionObj> lista)
        {
            int elemento = lista.Count;
            double Error;
            Error = Math.Abs(((lista[elemento - 1].Xr - lista[elemento - 2].Xr) / lista[elemento - 1].Xr) * 100);
            return Error;
        }
    }
}
