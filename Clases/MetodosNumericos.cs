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
                    lista[lista.Count - 1].Ea = ErrorAproximado(lista[lista.Count - 1].Xr, lista[lista.Count - 2].Xr);
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

        //Determina el error aproximado del metodo de biseccion y posicion falsa
        private static double ErrorAproximado(double Xr1, double Xr2)
        {
            double Error;
            Error = Math.Abs(((Xr1 - Xr2) / Xr1) * 100);
            return Error;
        }
    
        //Serie de Taylor
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

        //Calcua el factorial de un numero.
        public static int Factorial(int valorI)
        {
            int fac = 1;

            for (int i = 1; i <= valorI; i++)
            {
                fac *= i;
            }

            return fac;
        }
        
        public static List<PosicionFalsaObj> PosicionFalsa(PosicionFalsaObj posicion)
        {
            List<PosicionFalsaObj> lista = new List<PosicionFalsaObj>();
            PosicionFalsaObj aux = new PosicionFalsaObj();
            int iteracion = posicion.Iteracion;

            for (int i = 1; i <= iteracion; i++)
            {
                posicion.Fxa = ((Math.PI * 1 - Math.Exp(-posicion.Xa)) / posicion.Xa) - 0.5;//ojo con el exp
                posicion.Fxb = ((Math.PI * 1 - Math.Exp(-posicion.Xb)) / posicion.Xb) - 0.5;
                posicion.Xr = posicion.Xb - ((posicion.Fxb * (posicion.Xb - posicion.Xa)) / (posicion.Fxb - posicion.Fxa));
                posicion.Fxr = ((Math.PI * 1 - Math.Exp(-posicion.Xr)) / posicion.Xr) - 0.5;
                posicion.FxaFxr = posicion.Fxa * posicion.Fxr;
                posicion.Iteracion = i;
                aux = posicion;
                lista.Add(aux);
                posicion = new PosicionFalsaObj();

                if (lista.Count > 1)
                {
                    lista[lista.Count - 1].Ea = ErrorAproximado(lista[lista.Count - 1].Xr, lista[lista.Count - 2].Xr);
                }

                posicion.FxaFxr = aux.FxaFxr;

                if (aux.FxaFxr < 0)
                    posicion.Xa = aux.Xa;
                else
                    posicion.Xa = aux.Xr;

                if (posicion.FxaFxr > 0)
                    posicion.Xb = aux.Xb;
                else
                    posicion.Xb = aux.Xr;
            }

            return lista;
        }

        
    
    }
}
