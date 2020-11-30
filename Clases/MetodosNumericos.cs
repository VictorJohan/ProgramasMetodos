using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows;

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

        //Metodo de Biseccion
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

        //Determina el error aproximado del metodo de biseccion
        private static double ErrorAproximado(List<BiseccionObj> lista)
        {
            int elemento = lista.Count;
            double Error;
            Error = Math.Abs(((lista[elemento - 1].Xr - lista[elemento - 2].Xr) / lista[elemento - 1].Xr) * 100);
            return Error;
        }
    
        public static List<TaylorObj> SerieTaylor(TaylorObj taylor)
        {
            List<TaylorObj> lista = new List<TaylorObj>();
            TaylorObj aux = new TaylorObj();
            int iterador = taylor.Iteracion;
            for(int i = 0; i < iterador; i++)
            {
                taylor.ValorT = Math.Pow(taylor.ValorX, i) / Factorial(i);
                taylor.Iteracion = i;
                aux.ValorT = taylor.ValorT;
                aux.Iteracion = taylor.Iteracion;
                aux.ValorX = taylor.ValorX;
                lista.Add(aux);
                aux = new TaylorObj();
                
            }

            return lista;
        }

        public static int Factorial(int valorI)
        {
            int fac = 1;

            for (int i = 1; i <= valorI; i++)
            {
                fac *= i;
            }

            return fac;
        }
        
    }
}
