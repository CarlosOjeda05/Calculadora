using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    public class Calculadora
    {

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Resta(int a, int b)
        {
            return a - b;
        }

        public int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        public float Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("No puedes dividir entre 0.");
            }
            return (float)a / b;
        }
        public double Potencia(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Porcentaje(double total, double porcentaje)
        {
            return (total * porcentaje) / 100.0;
        }

        public double RaizCuadrada(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("No puedes calcular la raíz cuadrada de un número negativo.");
            }
            return Math.Sqrt(a);
        }

        public double Seno(double angleInDegrees)
        {
            return Math.Sin(angleInDegrees * Math.PI / 180.0);
        }

        public double Coseno(double angleInDegrees)
        {
            return Math.Cos(angleInDegrees * Math.PI / 180.0);
        }

        public double Tangente(double angleInDegrees)
        {
            return Math.Tan(angleInDegrees * Math.PI / 180.0);
        }

        public double Logaritmo(double a, double newBase)
        {
            return Math.Log(a, newBase);
        }

        public double LogaritmoNatural(double a)
        {
            return Math.Log(a);
        }

        public int Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("No se puede calcular el factorial de un número negativo.");
            }

            int result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}