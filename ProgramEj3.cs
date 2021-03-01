using System;

namespace Ejercicio3Guia7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            Console.WriteLine("Ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());

            if ((num1 % 2 == 0) == false)
            {
                if (num1 < num2)
                    num1++;
                if (num1 > num2)
                    num1--;
                Console.Write(num1 + ", ");
            }
            if (num2 > num1)
            {
                for (int x = num1; x < (num2 - 2); x += 2)
                {
                    num1 += 2;
                    Console.Write(num1 + ", ");
                }
            }
            else if (num1 > num2)
            {
                for (int x = num1; x > (num2 + 2); x -= 2)
                {
                    num1 -= 2;
                    Console.Write(num1 + ", ");
                }
            }
            Console.ReadKey();
        }
    }
}