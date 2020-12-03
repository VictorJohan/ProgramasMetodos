using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramasMetodos.Clases
{
    public class MetodoSecante
    {
        public string[] Elementos(string cadena)
        {
            string[] ele = cadena.Split('+', '-');
            char[] aux = cadena.ToCharArray();
            if (aux[0] == '-')
            {
                string[] ele2 = new string[ele.Length - 1];
                for (int i = 0; i < ele2.Length; i++)
                {
                    ele2[i] = ele[i + 1];
                }
                ele = ele2;
            }
            int j = 0;
            for (int i = 0; i < aux.Length; i++)
            {
                if (i == 0 && aux[i] != '-')
                {
                    j++;
                }
                if (aux[i] == '-')
                {
                    ele[j] = "-" + ele[j];
                    j++;
                }
                if (aux[i] == '+')
                {
                    j++;
                }
            }
            for (int k = 0; k < ele.Length; k++)
            {
                if (ele[k].ToCharArray()[ele[k].Length - 1] == '^' && ele[k + 1].ToCharArray()[0] == '-' && k < ele.Length - 1)
                {
                    string[] ele2 = new string[ele.Length - 1];
                    ele[k] = ele[k] + ele[k + 1];
                    ele[k + 1] = null;
                    int m = 0;
                    for (int i = 0; i < ele.Length; i++)
                    {
                        if (ele[i] != null)
                        {
                            ele2[m] = ele[i];
                            m++;
                        }
                    }
                    ele = ele2;
                }
                else
                {

                }
            }

            return ele;
        }

        public double ValorF(string fun, double Xi)
        {
            string[] ele = Elementos(fun);
            double pot = 0;
            double m = 0;
            double vt = 0;
            double er = 0;
            double c = 0;
            for (int i = 0; i < ele.Length; i++)
            {
                if (ele[i].Contains('l') && !ele[i].Contains('g') && !ele[i].Contains('e') && ele[i].Contains('x') && !ele[i].Contains('^') && !ele[i].Contains('c') && !ele[i].Contains('s'))
                {
                    string[] ln = ele[i].Split('l', 'n', 'x');
                    if (ln[0] == "" && ln.Length == 4 && ln[2] == "")
                    {
                        c = Math.Log(Xi, Math.E);
                    }
                    if (ln[0] == "-" && ln.Length == 4 && ln[2] == "")
                    {
                        c = Math.Log(Xi, Math.E) * -1;
                    }
                    if (ln[0] != "-" && ln[0] != "" && ln.Length == 4 && ln[2] == "")
                    {
                        c = Math.Log(Xi, Math.E) * double.Parse(ln[0]);
                    }
                    if (ln[0] == "" && ln.Length == 4 && ln[2] != "")
                    {
                        c = Math.Log((double.Parse(ln[2]) * Xi), Math.E);
                    }
                    if (ln[0] == "-" && ln[3] == "" && ln.Length == 5)
                    {
                        c = -Xi * Math.Log(Xi, Math.E);
                    }
                    if (ln[0] == "-" && ln[3] != "" && ln.Length == 5)
                    {
                        c = -Xi * Math.Log(double.Parse(ln[3]) * Xi, Math.E);
                    }
                    if (ln[0] == "" && ln[3] == "" && ln.Length == 5)
                    {
                        c = Xi * Math.Log(Xi, Math.E);
                    }
                    if (ln[0] == "" && ln[3] != "" && ln.Length == 5)
                    {
                        c = Xi * Math.Log(double.Parse(ln[3]) * Xi, Math.E);
                    }
                    if (ln[0] != "-" && ln[0] != "" && ln[3] == "" && ln.Length == 5)
                    {
                        c = double.Parse(ln[0]) * Xi * Math.Log(Xi, Math.E);
                    }
                    if (ln[0] != "-" && ln[0] != "" && ln[3] != "" && ln.Length == 5)
                    {
                        c = double.Parse(ln[0]) * Xi * Math.Log(double.Parse(ln[3]) * Xi, Math.E);
                    }
                    vt += c;
                }
                if (ele[i].Contains('l') && ele[i].Contains('g') && !ele[i].Contains('e') && ele[i].Contains('x') && !ele[i].Contains('^') && !ele[i].Contains('c') && !ele[i].Contains('s'))
                {
                    string[] lg = ele[i].Split('l', 'g', 'x');
                    if (lg[0] == "" && lg.Length == 4 && lg[2] == "")
                    {
                        c = Math.Log10(Xi);
                    }
                    if (lg[0] == "-" && lg.Length == 4 && lg[2] == "")
                    {
                        c = Math.Log10(Xi) * -1;
                    }
                    if (lg[0] != "-" && lg[0] != "" && lg.Length == 4 && lg[2] == "")
                    {
                        c = Math.Log10(Xi) * double.Parse(lg[0]);
                    }
                    if (lg[0] == "" && lg.Length == 4 && lg[2] != "")
                    {
                        c = Math.Log10((double.Parse(lg[2]) * Xi));
                    }
                    if (lg[0] == "-" && lg[3] == "" && lg.Length == 5)
                    {
                        c = -Xi * Math.Log10(Xi);
                    }
                    if (lg[0] == "-" && lg[3] != "" && lg.Length == 5)
                    {
                        c = -Xi * Math.Log10(double.Parse(lg[3]) * Xi);
                    }
                    if (lg[0] == "" && lg[3] == "" && lg.Length == 5)
                    {
                        c = Xi * Math.Log10(Xi);
                    }
                    if (lg[0] == "" && lg[3] != "" && lg.Length == 5)
                    {
                        c = Xi * Math.Log10(double.Parse(lg[3]) * Xi);
                    }
                    if (lg[0] != "-" && lg[0] != "" && lg[3] == "" && lg.Length == 5)
                    {
                        c = double.Parse(lg[0]) * Xi * Math.Log10(Xi);
                    }
                    if (lg[0] != "-" && lg[0] != "" && lg[3] != "" && lg.Length == 5)
                    {
                        c = double.Parse(lg[0]) * Xi * Math.Log10(double.Parse(lg[3]) * Xi);
                    }
                    vt += c;
                }
                if (ele[i].Contains('c') && !ele[i].Contains('e') && ele[i].Contains('x') && !ele[i].Contains('^') && !ele[i].Contains('l') && ele[i].Contains('o') && ele[i].Contains('s'))
                {
                    string[] cos = ele[i].Split('c', 'o', 's', 'x', '^');
                    if (cos[0] == "" && cos.Length != 6)
                    {
                        c = Math.Cos(Xi);
                    }
                    if (cos[0] == "-" && cos.Length != 6)
                    {
                        c = Math.Cos(Xi) * -1;
                    }
                    if (cos[0] != "-" && cos[0] != "" && cos.Length != 6)
                    {
                        c = Math.Cos(Xi) * double.Parse(cos[0]);
                    }
                    if (cos[0] == "" && cos.Length == 6)
                    {
                        c = Xi * Math.Cos(Xi);
                    }
                    if (cos[0] == "-" && cos.Length == 6)
                    {
                        c = Xi * Math.Cos(Xi) * -1;
                    }
                    if (cos[0] != "-" && cos[0] != "" && cos.Length == 6)
                    {
                        c = double.Parse(cos[0]) * Xi * Math.Cos(Xi);
                    }
                    vt += c;
                }
                if (ele[i].Contains('s') && ele[i].Contains('e') && !ele[i].Contains('e') && ele[i].Contains('x') && !ele[i].Contains('^') && !ele[i].Contains('l'))
                {
                    string[] sen = ele[i].Split('s', 'e', 'n', 'x', '^');
                    if (sen[0] == "" && sen.Length != 6)
                    {
                        c = Math.Sin(Xi);
                    }
                    if (sen[0] == "-" && sen.Length != 6)
                    {
                        c = Math.Sin(Xi) * -1;
                    }
                    if (sen[0] != "-" && sen[0] != "" && sen.Length != 6)
                    {
                        c = Math.Sin(Xi) * double.Parse(sen[0]);
                    }
                    if (sen[0] == "" && sen.Length == 6)
                    {
                        c = Xi * Math.Sin(Xi);
                    }
                    if (sen[0] == "-" && sen.Length == 6)
                    {
                        c = Xi * Math.Sin(Xi) * -1;
                    }
                    if (sen[0] != "-" && sen[0] != "" && sen.Length == 6)
                    {
                        c = double.Parse(sen[0]) * Xi * Math.Sin(Xi);
                    }
                    vt += c;
                }
                if (ele[i].Contains('e') && ele[i].Contains('x') && ele[i].Contains('^') && !ele[i].Contains('c') && !ele[i].Contains('l') && !ele[i].Contains('s'))
                {
                    string[] err = ele[i].Split('e', 'x', '^');
                    if (err.Length == 5)
                    {
                        if (err[0] == "" && err[3] != "-")
                        {
                            er = Xi * Math.Pow(Math.E, Xi);
                        }
                        if (err[0] == "-" && err[3] != "-")
                        {
                            er = -Xi * Math.Pow(Math.E, Xi);
                        }
                        if (err[0] != "-" && err[0] != "" && err[3] != "-")
                        {
                            er = Math.Pow(Math.E, Xi) * (double.Parse(err[0]) * Xi);
                        }
                        if (err[0] == "" && err[3] == "-")
                        {
                            er = Xi * Math.Pow(Math.E, -Xi);
                        }
                        if (err[0] == "-" && err[3] == "-")
                        {
                            er = -Xi * Math.Pow(Math.E, -Xi);
                        }
                        if (err[0] != "-" && err[0] != "" && err[3] == "-")
                        {
                            er = Math.Pow(Math.E, -Xi) * (double.Parse(err[0]) * Xi);
                        }
                    }
                    else
                    {
                        if (err[0] == "" && err[2] == "")
                        {
                            er = Math.Pow(Math.E, Xi);
                        }
                        if (err[0] == "-" && err[2] == "")
                        {
                            er = Math.Pow(Math.E, Xi) * -1;
                        }
                        if (err[0] != "-" && err[0] != "" && err[2] == "-")
                        {
                            er = Math.Pow(Math.E, Xi) * double.Parse(err[0]);
                        }
                        if (err[0] == "" && err[2] == "-")
                        {
                            er = Math.Pow(Math.E, -Xi);
                        }
                        if (err[0] != "-" && err[0] != "" && err[2] == "")
                        {
                            er = Math.Pow(Math.E, Xi) * double.Parse(err[0]);
                        }
                        if (err[0] == "" && err[2] != "" && err[2] != "-")
                        {
                            er = Math.Pow(Math.E, double.Parse(err[2]) * Xi);
                        }
                        if (err[0] == "-" && err[2] != "" && err[2] != "-")
                        {
                            er = Math.Pow(Math.E, double.Parse(err[2]) * Xi) * -1;
                        }
                        if (err[0] != "-" && err[0] != "" && err[2] != "" && err[2] != "-")
                        {
                            er = Math.Pow(Math.E, double.Parse(err[2]) * Xi) * double.Parse(err[0]);
                        }
                    }

                    vt += er;
                }
                if (!ele[i].Contains('l') && ele[i].Contains('x') && ele[i].Contains('^') && !ele[i].Contains('e') && !ele[i].Contains('c') && !ele[i].Contains('s'))
                {
                    string[] exp = ele[i].Split('x', '^');
                    pot = Math.Pow(Xi, double.Parse(exp[2]));
                    if (exp[0] == "")
                    {
                        pot = pot * 1;
                    }
                    if (exp[0] != "-" && exp[0] != "")
                    {
                        pot = pot * double.Parse(exp[0]);
                    }
                    if (exp[0] == "-")
                    {
                        pot = pot * -1;
                    }

                    vt += pot;
                }
                if (!ele[i].Contains('l') && ele[i].Contains('x') && !ele[i].Contains('^') && !ele[i].Contains('e') && !ele[i].Contains('c') && !ele[i].Contains('s'))
                {
                    string[] mult = ele[i].Split('x');
                    if (mult[0] == "")
                    {
                        m = 1 * Xi;
                    }
                    if (mult[0] == "-")
                    {
                        m = -1 * Xi;
                    }
                    if (mult[0] != "-" && mult[0] != "")
                    {
                        m = double.Parse(mult[0]) * Xi;
                    }


                    vt += m;
                }
                if (!ele[i].Contains('x') && !ele[i].Contains('^') && ele[i] != "0" && !ele[i].Contains('l') && !ele[i].Contains('s'))
                {
                    double a = double.Parse(ele[i]);

                    vt += a;
                }
                if (ele[i] == "0")
                {
                    vt += 0;
                }
            }
            return vt;

        }
    }
}
