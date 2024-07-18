using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Actividad
{
    internal class Program
    {
        //Escribir un programa que compare dos números ingresados
        //por el usuario y muestre si son iguales, mayores o menores.
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            // Solicitar al usuario que ingrese el segundo número
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            // Comparar los números y mostrar el resultado
            if (num1 > num2)
            {
                Console.WriteLine($"{num1} es mayor que {num2}");
            }
            else if (num1 < num2)
            {
                Console.WriteLine($"{num1} es menor que {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} y {num2} son iguales");
            }
                Console.ReadKey();
        }
    }
}
