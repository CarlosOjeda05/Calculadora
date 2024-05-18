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
    }
}