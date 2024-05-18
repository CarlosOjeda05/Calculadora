using PruebasUnitarias;
using System;

public class Program
{
    public static void Main()
    {
        Calculadora calc = new Calculadora();
        bool exit = false;

        while (!exit)
        {
            Console.Write("\n\n\n\n");
            Console.WriteLine("Seleccione una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potencia");
            Console.WriteLine("6. Porcentaje");
            Console.WriteLine("7. Raíz Cuadrada");
            Console.WriteLine("8. Salir");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("Opción: ");


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
                            exit = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion no encontrada.");
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
