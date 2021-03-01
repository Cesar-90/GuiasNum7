using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2Guia7
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo op;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\t\tMenú \n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[A] Seno de X\t");
                Console.WriteLine("[B] Cos de x\t");
                Console.WriteLine("[C] Tan de x\t");
                Console.WriteLine("[D] Raíz cuadrada de x\t");
                Console.WriteLine("[E] Potencia de Y^x\t");
                Console.WriteLine("[F] Verificar si es par o impar\t");
                Console.WriteLine("[G] Salir del programa\t");
                Console.WriteLine("Seleccione una opción... ");
                double x, y;
                op = Console.ReadKey(true);
                
                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Seleccionó la opción A, ingrese un valor a X ");
                        x=double.Parse(Console.ReadLine());
                        Console.WriteLine($"El valor de seno X es {Math.Sin(x)}");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Seleccionó la opción B, ingrese valor a x ");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine($"El valor de seno X es {Math.Cos(x)}");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine("Seleccionó la opción C, ingrese valor a x ");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine($"El valor de seno X es {Math.Tan(x)}");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("Seleccionó la opción D, ingrese el valor de x");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine($"El valor de raiz cuadrada de X es {Math.Sqrt(x)}");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Seleccionó la opción E, ingrese el valor de la potencia x ");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine($"La potencia de Y es {x}");
                        Console.WriteLine("Ingrese valor para y ");
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Por lo tanto el resultado sera {Math.Pow(y, x)}");
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.F:
                        Console.WriteLine("Seleccionó la opción F, ingrese valor a x ");
                        x = double.Parse(Console.ReadLine());
                        if (x%2==0)
                        {
                            Console.WriteLine("El numero que selecciono es par");
                        }
                        else
                        {
                            Console.WriteLine("El numero es impar");
                        } 
                        Console.WriteLine("Presione una tecla para continuar");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.G:
                        Console.WriteLine("Seleccionó la opción G");
                        Console.WriteLine("Tenga buen día...");
                        Console.ReadKey();
                        break;
                }

            } while (op.Key != ConsoleKey.G);
            
        }
    }
}
