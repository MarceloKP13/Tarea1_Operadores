using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Actividad
{
    internal class Program
    {
        //Desarrollar un programa que calcule el módulo (residuo)
        //de la división entre dos números ingresados por el usuario.
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            // Solicitar al usuario que ingrese el segundo número
            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            // Calcular el módulo (residuo) de la división
            int resultado = num1 % num2;

            // Mostrar el resultado
            Console.WriteLine($"El módulo de la division entre {num1} y {num2} es: {resultado}");

            Console.ReadKey();
        }
    }
}
