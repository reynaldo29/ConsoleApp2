using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static int Resta(int a, int b)
        {
            return (a-b);
        }
        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }
        static void Primos()
        {
            Console.WriteLine(" Los 10 primeros numeros primos son: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29");

        }

        static int Celcius( int F) {
            return 5*(F-32)/9;
        }

        static int Farenheit(int C)
        {
            return (9*C/5) + 32;
        }
        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] 10 primeros numeros primos");
                Console.WriteLine("[5] Convertir de Farenheit Celcius");
                Console.WriteLine("[6] Convertir de Celcius a Farenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                     case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a2, b2, Resta(a2, b2));
                        Console.ReadKey();
                        break;
                      case "4":
                        Console.WriteLine("Calculando...");
                        Primos();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese temperatura en Farenheit ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La temperatura en Celcius es "+ Celcius(23));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Ingrese temperatura en Celcius ");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La temperatura en Farenheit es "+ Farenheit(f));
                        Console.ReadKey();
                        break;

                }
            } while (!opcion.Equals("0"));


        }
    }
}
