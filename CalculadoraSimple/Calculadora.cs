using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSimple
{
    public class Calculadora
    {
        public int Sumar(int v1, int v2)
        {
            return v1 + v2;
        }
        public int Sumar(string v1, string v2)
        {
            return Convert.ToInt16(v1) + Convert.ToInt16(v2);
        }
        public int SumarCero(string v1, string v2)
        {
            int valor1 = (v1.Equals("")) ? 0 : Convert.ToInt16(v1);
            int valor2 = (v2.Equals("")) ? 0 : Convert.ToInt16(v2);

            return valor1 + valor2;
        }
        public int Restar(int v1, int v2)
        {
            return v1 - v2;
        }
        public int Multiplicar(int v1, int v2)
        {
            return v1 * v2;
        }
        public int MultiplicarCero(int v1, int v2)
        {
            return v1==0 ? 0 : v2==0 ? 0 : v1*v2;
            
        }
        public double Raiz(int v1)
        {

            return Math.Round(Math.Sqrt(v1), 2);

        }
        public double Potencia(double v1, double v2)
        {

            return (long)Math.Pow(v1, v2);

        }
        public double Division(int v1, int v2)
        {

            return v1/v2;

        }
        public decimal DivisionSinDecimal(int v1, int v2)
        {
            decimal valor;
            valor= v1/v2;

            return Math.Truncate(valor);

        }
        public int Residuo(int v1, int v2)
        {

            return v1 % v2;

        }
    }
}
