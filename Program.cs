using PruebasUnitarias;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        Calculadora calc = new Calculadora();
        bool exit = false;

        Console.WriteLine("¡Bienvenido a la Calculadora Científica!");
        while (!exit)
        {
            Console.WriteLine("Por favor, seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Porcentaje");
            Console.WriteLine("7. Raíz Cuadrada");
            Console.WriteLine("8. Seno");
            Console.WriteLine("9. Coseno");
            Console.WriteLine("10. Tangente");
            Console.WriteLine("11. Logaritmo");
            Console.WriteLine("12. Factorial");
            Console.WriteLine("13. Limpiar");
            Console.WriteLine("14. Salir");
            Console.Write("\nOpción: ");


            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Ingrese el primer número: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el segundo número: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: " + calc.Suma(a, b));
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Ingrese el primer número: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el segundo número: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: " + calc.Resta(a, b));
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Ingrese el primer número: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el segundo número: ");
                            int b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: " + calc.Multiplicacion(a, b));
                            break;
                        }
                    case 4:
                        {
                            Console.Write("Ingrese el primer número: ");
                            int a = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el segundo número: ");
                            int b = int.Parse(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Resultado: " + calc.Division(a, b));
                            }
                            catch (DivideByZeroException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case 5:
                        {
                            Console.Write("Ingrese la base: ");
                            double a = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese el exponente: ");
                            double b = double.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: " + calc.Potencia(a, b));
                            break;
                        }
                    case 6:
                        {
                            Console.Write("Ingrese el total: ");
                            double total = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese el porcentaje: ");
                            double porcentaje = double.Parse(Console.ReadLine());
                            Console.WriteLine("Resultado: " + calc.Porcentaje(total, porcentaje));
                            break;
                        }
                    case 7:
                        {
                            Console.Write("Ingrese el número: ");
                            double a = double.Parse(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Resultado: " + calc.RaizCuadrada(a));
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case 8:
                        {
                            Console.Write("Ingrese el ángulo en grados: ");
                            double angle = double.Parse(Console.ReadLine());
                            Console.WriteLine("Seno: " + calc.Seno(angle));
                            break;
                        }
                    case 9:
                        {
                            Console.Write("Ingrese el ángulo en grados: ");
                            double angle = double.Parse(Console.ReadLine());
                            Console.WriteLine("Coseno: " + calc.Coseno(angle));
                            break;
                        }
                    case 10:
                        {
                            Console.Write("Ingrese el ángulo en grados: ");
                            double angle = double.Parse(Console.ReadLine());
                            Console.WriteLine("Tangente: " + calc.Tangente(angle));
                            break;
                        }
                    case 11:
                        {
                            Console.Write("Ingrese el número: ");
                            double a = double.Parse(Console.ReadLine());
                            Console.Write("Ingrese la base del logaritmo: ");
                            double newBase = double.Parse(Console.ReadLine());
                            Console.WriteLine("Logaritmo (" + newBase + "): " + calc.Logaritmo(a, newBase));
                            break;
                        }
                    case 12:
                        {
                            Console.Write("Ingrese el número para calcular el factorial: ");
                            int n = int.Parse(Console.ReadLine());
                            try
                            {
                                Console.WriteLine("Factorial: " + calc.Factorial(n));
                            }
                            catch (ArgumentException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            break;
                        }
                    case 13:
                        {
                            Console.Clear();
                            break;
                        }
                    case 14:
                        {
                            exit = true;
                            Console.WriteLine("Saliendo de la calculadora.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("¡Opción no válida! Por favor, intente de nuevo.");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Por favor intente de nuevo.");
            }

            Console.WriteLine();
        }

        Console.WriteLine("Gracias por usar la calculadora.");
    }
}
